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

namespace QUANLYBANHANG.GUI
{
    public partial class ucKhachHang : DevExpress.XtraEditors.XtraUserControl
    {
        //tạo event lưu nhật ký hệ thống
        public delegate void NhatKyHeThong(cNhatKyHeThong diary);
        public event NhatKyHeThong ThemNhatKyHeThong;

        // username
        string user;

        // tên chức năng hiện tại
        string TenChucNang = "Khách Hàng";

        NGHIEPVU_KHACHHANG nv_kh = new NGHIEPVU_KHACHHANG();

        //chỉ số dòng hiện tại
        int CurRowIndex;

        public ucKhachHang(VaiTro_ChucNang phanquyenKH, string un)
        {
            InitializeComponent();

            user = un;

            Load += new EventHandler(ucKhachHang_Load);

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
            gvKhachHang.FocusedRowChanged += GvKhachHang_FocusedRowChanged;
            gvKhachHang.DoubleClick += BtnSua_Click;
            gvKhachHang.ShowingEditor += GvKhachHang_ShowingEditor;

            //show radial menu
            gvKhachHang.PopupMenuShowing += GvKhachHang_PopupMenuShowing;

            //phân quyền dựa vào bảng vai trò chức năng đã được gửi qua
            if (phanquyenKH != null)
            {
                if (phanquyenKH.Them == 0)
                {
                    btnThem.Enabled = false;
                    bbiThem.Enabled = false;
                }
                if (phanquyenKH.Xoa == 0)
                {
                    btnXoa.Enabled = false;
                    bbiXoa.Enabled = false;
                }
                if (phanquyenKH.Sua == 0)
                {
                    btnSua.Enabled = false;
                    bbiSua.Enabled = false;
                    gvKhachHang.DoubleClick -= BtnSua_Click;
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

        private void GvKhachHang_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (CurRowIndex >= 0)
            {
                e.Allow = false;
                rdmKhachHang.ShowPopup(gcKhachHang.PointToScreen(e.Point));
            }
        }

        private void GvKhachHang_ShowingEditor(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void GvKhachHang_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            CurRowIndex = int.Parse(e.FocusedRowHandle.ToString());
        }

        private void BbiDong_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.rdmKhachHang.HidePopup();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (CurRowIndex >= 0)
            {
                string maKH = gvKhachHang.GetRowCellValue(CurRowIndex, "MaKH").ToString();
                string tenKH = gvKhachHang.GetRowCellValue(CurRowIndex, "TenKH").ToString();

                DialogResult dr = MessageBox.Show(string.Format("Bạn có chắc chắn muốn xóa Khách Hàng:\n\n\t{0}", tenKH), "Thông báo hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    nv_kh.XoaKhachHang(maKH);
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
                KhachHang kh = LayKHDangChon();

                frmThemSuaKhachHang frmSua = new frmThemSuaKhachHang(kh);
                frmSua.CapNhatThanhCong += FillGridView;
                frmSua.CapNhatThanhCong += NhatKySua;
                frmSua.ShowDialog();
            }
        }

        private KhachHang LayKHDangChon()
        {
            KhachHang kh = new KhachHang();

            kh.MaKH = gvKhachHang.GetRowCellValue(CurRowIndex, "MaKH").ToString();
            kh.TenKH = gvKhachHang.GetRowCellValue(CurRowIndex, "TenKH").ToString();
            kh.LaKhachLe = bool.Parse(gvKhachHang.GetRowCellValue(CurRowIndex, "LaKhachLe").ToString());
            kh.ConQuanLy = bool.Parse(gvKhachHang.GetRowCellValue(CurRowIndex, "ConQuanLy").ToString());
            kh.MaKhuVuc = gvKhachHang.GetRowCellValue(CurRowIndex, "MaKhuVuc").ToString();
            kh.DiaChi = gvKhachHang.GetRowCellValue(CurRowIndex, "DiaChi").ToString();
            kh.MaSoThue = gvKhachHang.GetRowCellValue(CurRowIndex, "MaSoThue").ToString();
            kh.Fax = gvKhachHang.GetRowCellValue(CurRowIndex, "Fax").ToString();
            kh.DienThoai = gvKhachHang.GetRowCellValue(CurRowIndex, "DienThoai").ToString();
            kh.Mobile = gvKhachHang.GetRowCellValue(CurRowIndex, "Mobile").ToString();
            kh.Email = gvKhachHang.GetRowCellValue(CurRowIndex, "Email").ToString();
            kh.Website = gvKhachHang.GetRowCellValue(CurRowIndex, "Website").ToString();
            kh.TaiKhoan = gvKhachHang.GetRowCellValue(CurRowIndex, "TaiKhoan").ToString();
            kh.NganHang = gvKhachHang.GetRowCellValue(CurRowIndex, "NganHang").ToString();
            kh.GioiHanNo = int.Parse(gvKhachHang.GetRowCellValue(CurRowIndex, "GioiHanNo").ToString());
            kh.NoHienTai = int.Parse(gvKhachHang.GetRowCellValue(CurRowIndex, "NoHienTai").ToString());
            kh.ChietKhau = int.Parse(gvKhachHang.GetRowCellValue(CurRowIndex, "ChietKhau").ToString());
            kh.AccYahoo = gvKhachHang.GetRowCellValue(CurRowIndex, "AccYahoo").ToString();
            kh.AccSkype = gvKhachHang.GetRowCellValue(CurRowIndex, "AccSkype").ToString();
            kh.NguoiLienHe = gvKhachHang.GetRowCellValue(CurRowIndex, "NguoiLienHe").ToString();

            return kh;

        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            frmThemSuaKhachHang frmtkh = new frmThemSuaKhachHang();
            frmtkh.ThemThanhCong += FillGridView;
            frmtkh.ThemThanhCong += NhatKyThem;
            frmtkh.ShowDialog();
        }

        public void ucKhachHang_Load(object sender, EventArgs e)
        {
            AddNhatKy("Xem");
            FillGridView();

            gvKhachHang.ExpandAllGroups();
        }

        public void FillGridView()
        {
            string sql = "select kh.*, kv.TenKhuVuc from KHACH_HANG kh, KHUVUC kv where kh.MaKhuVuc=kv.MaKhuVuc";
            DataTable kh = Execute.LayDuLieuBang(sql);
            gcKhachHang.DataSource = kh;
            gvKhachHang.ExpandAllGroups();
        }
    }
}
