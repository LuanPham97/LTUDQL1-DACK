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
using QUANLYBANHANG.DTO;
using QUANLYBANHANG.DAO;
using QUANLYBANHANG.BUS;
using DevExpress.XtraBars;

namespace QUANLYBANHANG.GUI.tabDanhMuc
{
    public partial class ucNhomHang : DevExpress.XtraEditors.XtraUserControl
    {
        //tạo event lưu nhật ký hệ thống
        public delegate void NhatKyHeThong(cNhatKyHeThong diary);
        public event NhatKyHeThong ThemNhatKyHeThong;

        // username
        string user;

        // tên chức năng hiện tại
        string TenChucNang = "Nhóm Hàng";

        NGHIEPVU_NHOMHANG nv_nh = new NGHIEPVU_NHOMHANG();

        //chỉ số dòng hiện tại
        int CurRowIndex;

        public ucNhomHang(VaiTro_ChucNang phanquyennh, string un)
        {
            InitializeComponent();

            user = un;

            Load += new EventHandler(ucNhomHang_Load);

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
            gvNhomHang.FocusedRowChanged += GvNhomHang_FocusedRowChanged;
            gvNhomHang.DoubleClick += BtnSua_Click;
            gvNhomHang.ShowingEditor += GvNhomHang_ShowingEditor;

            //show radial menu
            gvNhomHang.PopupMenuShowing += GvNhomHang_PopupMenuShowing;

            //phân quyền dựa vào bảng vai trò chức năng đã được gửi qua
            if (phanquyennh != null)
            {
                if (phanquyennh.Them == 0)
                {
                    btnThem.Enabled = false;
                    bbiThem.Enabled = false;
                }
                if (phanquyennh.Xoa == 0)
                {
                    btnXoa.Enabled = false;
                    bbiXoa.Enabled = false;
                }
                if (phanquyennh.Sua == 0)
                {
                    btnSua.Enabled = false;
                    bbiSua.Enabled = false;
                    gvNhomHang.DoubleClick -= BtnSua_Click;
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

        private void GvNhomHang_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (CurRowIndex >= 0)
            {
                e.Allow = false;
                rdmNhomHang.ShowPopup(gcNhomHang.PointToScreen(e.Point));
            }
        }

        private void GvNhomHang_ShowingEditor(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void GvNhomHang_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            CurRowIndex = int.Parse(e.FocusedRowHandle.ToString());
        }

        private void BbiDong_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.rdmNhomHang.HidePopup();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (CurRowIndex >= 0)
            {
                string maNH = gvNhomHang.GetRowCellValue(CurRowIndex, "MaNhomHang").ToString();
                string tenNH = gvNhomHang.GetRowCellValue(CurRowIndex, "TenNhomHang").ToString();

                DialogResult dr = MessageBox.Show(string.Format("Bạn có chắc chắn muốn xóa Nhóm Hàng:\n\n\t{0}", tenNH), "Thông báo hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    nv_nh.XoaNhomHang(maNH);
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
                NhomHang nh = LayNHDangChon();

                frmThemNhomHang frmSua = new frmThemNhomHang(nh);
                frmSua.CapNhatThanhCong += FillGridView;
                frmSua.CapNhatThanhCong += NhatKySua;
                frmSua.ShowDialog();
            }
        }

        private NhomHang LayNHDangChon()
        {
            NhomHang nh = new NhomHang();

            nh.MaNhomHang = gvNhomHang.GetRowCellValue(CurRowIndex, "MaNhomHang").ToString();
            nh.TenNhomHang = gvNhomHang.GetRowCellValue(CurRowIndex, "TenNhomHang").ToString();
            nh.GhiChu = gvNhomHang.GetRowCellValue(CurRowIndex, "GhiChu").ToString();
            nh.ConQuanLy = bool.Parse(gvNhomHang.GetRowCellValue(CurRowIndex, "ConQuanLy").ToString());

            return nh;
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            frmThemNhomHang frmthem = new frmThemNhomHang();
            frmthem.ThemThanhCong += FillGridView;
            frmthem.ThemThanhCong += NhatKyThem;
            frmthem.ShowDialog();
        }

        private void ucNhomHang_Load(object sender, EventArgs e)
        {
            AddNhatKy("Xem");
            FillGridView();
        }

        private void FillGridView()
        {
            string sql = "select * from NHOMHANG";
            DataTable nh = Execute.LayDuLieuBang(sql);
            gcNhomHang.DataSource = nh;
        }
    }
}
