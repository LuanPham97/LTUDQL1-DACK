using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QUANLYBANHANG.DAO;
using QUANLYBANHANG.DTO;
using QUANLYBANHANG.BUS;
using DevExpress.XtraBars;

namespace QUANLYBANHANG.GUI.tabDanhMuc
{
    public partial class ucNhaCungCap : DevExpress.XtraEditors.XtraUserControl
    {
        //tạo event lưu nhật ký hệ thống
        public delegate void NhatKyHeThong(cNhatKyHeThong diary);
        public event NhatKyHeThong ThemNhatKyHeThong;

        // username
        string user;

        // tên chức năng hiện tại
        string TenChucNang = "Nhà Cung Cấp";

        NGHIEPVU_NHACUNGCAP nv_ncc = new NGHIEPVU_NHACUNGCAP();

        //chỉ số dòng hiện tại
        int CurRowIndex;


        public ucNhaCungCap(VaiTro_ChucNang phanquyenncc, string un)
        {
            InitializeComponent();
            Load += new EventHandler(ucNhaCungCap_Load);

            user = un;

            //sự kiện button
            btnThem.Click += BtnThem_Click;
            btnSua.Click += BtnSua_Click;
            btnXoa.Click += BtnXoa_Click;

            //button radial menu
            bbiDong.ItemClick += BbiDong_ItemClick;
            bbiThem.ItemClick += BtnThem_Click;
            bbiSua.ItemClick += BtnSua_Click;
            bbiXoa.ItemClick += BtnXoa_Click;

            //radial menu
            bbiSua.CloseRadialMenuOnItemClick = true;
            bbiThem.CloseRadialMenuOnItemClick = true;
            bbiXoa.CloseRadialMenuOnItemClick = true;

            // lấy chỉ số dòng hiện tại
            gvNhaCungCap.FocusedRowChanged += GvNhaCungCap_FocusedRowChanged;
            gvNhaCungCap.DoubleClick += BtnSua_Click;
            gvNhaCungCap.ShowingEditor += GvNhaCungCap_ShowingEditor;

            //show radial menu
            gvNhaCungCap.PopupMenuShowing += GvNhaCungCap_PopupMenuShowing;

            //phân quyền dựa vào bảng vai trò chức năng đã được gửi qua
            if (phanquyenncc != null)
            {
                if (phanquyenncc.Them == 0)
                {
                    btnThem.Enabled = false;
                    bbiThem.Enabled = false;
                }
                if (phanquyenncc.Xoa == 0)
                {
                    btnXoa.Enabled = false;
                    bbiXoa.Enabled = false;
                }
                if (phanquyenncc.Sua == 0)
                {
                    btnSua.Enabled = false;
                    bbiSua.Enabled = false;
                    gvNhaCungCap.DoubleClick -= BtnSua_Click;
                }
            }
        }

        private void AddNhatKy(string hanhDong)
        {
            cNhatKyHeThong nk = new cNhatKyHeThong();
            nk.NguoiDung = user;
            nk.MayTinh = System.Environment.MachineName;
            nk.ThoiGian = DateTime.Now;
            nk.ChucNang = TenChucNang;
            nk.HanhDong = hanhDong;

            ThemNhatKyHeThong(nk);
        }

        private void NhatKySua()
        {
            AddNhatKy("Cập Nhật");
        }

        private void NhatKyThem()
        {
            AddNhatKy("Thêm");
        }

        private void GvNhaCungCap_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (CurRowIndex >= 0)
            {
                e.Allow = false;
                rdmNhaCC.ShowPopup(gcNhaCungCap.PointToScreen(e.Point));
            }
        }

        private void GvNhaCungCap_ShowingEditor(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void GvNhaCungCap_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            CurRowIndex = int.Parse(e.FocusedRowHandle.ToString());
        }

        private void BbiDong_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.rdmNhaCC.HidePopup();
        }

        public void ucNhaCungCap_Load(object sender, EventArgs e)
        {
            AddNhatKy("Xem");
            FillGridView();
        }

        public void FillGridView()
        {
            string sql = "select ncc.*,kv.TenKhuVuc from NHACUNGCAP ncc,KHUVUC kv where ncc.KhuVuc = kv.MaKhuVuc";
            DataTable ncc = Execute.LayDuLieuBang(sql);
            gcNhaCungCap.DataSource = ncc;
            gvNhaCungCap.ExpandAllGroups();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (CurRowIndex >= 0)
            {
                string mancc = gvNhaCungCap.GetRowCellValue(CurRowIndex, "MaNCC").ToString();
                string tenncc = gvNhaCungCap.GetRowCellValue(CurRowIndex, "TenNCC").ToString();

                DialogResult dr = MessageBox.Show(string.Format("Bạn có chắc chắn muốn xóa Nhà Cung Cấp:\n\n\t{0}", tenncc), "Thông báo hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    nv_ncc.XoaNCC(mancc);
                    FillGridView();
                    AddNhatKy("Xóa");
                    MessageBox.Show("Đã Xóa");
                }
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (CurRowIndex >= 0)
            {
                NhaCC ncc = LayNCCDangChon();

                frmThemNhaCungCap frmSua = new frmThemNhaCungCap(ncc);
                frmSua.CapNhatThanhCong += FillGridView;
                frmSua.CapNhatThanhCong += NhatKySua;
                frmSua.ShowDialog();
            }
        }

        private NhaCC LayNCCDangChon()
        {
            NhaCC ncc = new NhaCC();

            ncc.MaNCC = gvNhaCungCap.GetRowCellValue(CurRowIndex, "MaNCC").ToString();
            ncc.TenNCC = gvNhaCungCap.GetRowCellValue(CurRowIndex, "TenNCC").ToString();
            ncc.ConQuanLy = bool.Parse(gvNhaCungCap.GetRowCellValue(CurRowIndex, "ConQuanLy").ToString());
            ncc.KhuVuc = gvNhaCungCap.GetRowCellValue(CurRowIndex, "KhuVuc").ToString();
            ncc.DiaChi = gvNhaCungCap.GetRowCellValue(CurRowIndex, "DiaChi").ToString();
            ncc.MaSoThue = gvNhaCungCap.GetRowCellValue(CurRowIndex, "MaSoThue").ToString();
            ncc.Fax = gvNhaCungCap.GetRowCellValue(CurRowIndex, "Fax").ToString();
            ncc.DienThoai = gvNhaCungCap.GetRowCellValue(CurRowIndex, "DienThoai").ToString();
            ncc.Mobile = gvNhaCungCap.GetRowCellValue(CurRowIndex, "Mobile").ToString();
            ncc.Email = gvNhaCungCap.GetRowCellValue(CurRowIndex, "Email").ToString();
            ncc.Website = gvNhaCungCap.GetRowCellValue(CurRowIndex, "Website").ToString();
            ncc.TaiKhoan = gvNhaCungCap.GetRowCellValue(CurRowIndex, "TaiKhoan").ToString();
            ncc.NganHang = gvNhaCungCap.GetRowCellValue(CurRowIndex, "NganHang").ToString();
            ncc.GioiHanNo = int.Parse(gvNhaCungCap.GetRowCellValue(CurRowIndex, "GioiHanNo").ToString());
            ncc.NoHienTai = int.Parse(gvNhaCungCap.GetRowCellValue(CurRowIndex, "NoHienTai").ToString());
            ncc.ChietKhau = int.Parse(gvNhaCungCap.GetRowCellValue(CurRowIndex, "ChietKhau").ToString());
            ncc.ChucVu = gvNhaCungCap.GetRowCellValue(CurRowIndex, "ChucVu").ToString();
            ncc.NguoiLienHe = gvNhaCungCap.GetRowCellValue(CurRowIndex, "NguoiLienHe").ToString();

            return ncc;
        }


        private void BtnThem_Click(object sender, EventArgs e)
        {
            frmThemNhaCungCap frmthem = new frmThemNhaCungCap();
            frmthem.ThemThanhCong += FillGridView;
            frmthem.ThemThanhCong += NhatKyThem;
            frmthem.ShowDialog();
        }
    }
}
