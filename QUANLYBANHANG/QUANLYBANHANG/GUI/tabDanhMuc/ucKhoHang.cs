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

namespace QUANLYBANHANG.GUI.tabDanhMuc
{
    public partial class ucKhoHang : DevExpress.XtraEditors.XtraUserControl
    {
        //tạo event lưu nhật ký hệ thống
        public delegate void NhatKyHeThong(cNhatKyHeThong diary);
        public event NhatKyHeThong ThemNhatKyHeThong;

        // username
        string user;

        // tên chức năng hiện tại
        string TenChucNang = "Kho Hàng";

        NGHIEPVU_KHOHANG nv_kho = new NGHIEPVU_KHOHANG();

        //chỉ số dòng hiện tại
        int CurRowIndex;

        public ucKhoHang(VaiTro_ChucNang pqkh, string un)
        {
            InitializeComponent();

            user = un;

            Load += UcKhoHang_Load;

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
            gvKhoHang.FocusedRowChanged += GvKhoHang_FocusedRowChanged;
            gvKhoHang.DoubleClick += BtnSua_Click;
            gvKhoHang.ShowingEditor += GvKhoHang_ShowingEditor;

            //show radial menu
            gvKhoHang.PopupMenuShowing += GvKhoHang_PopupMenuShowing;

            //phân quyền dựa vào bảng vai trò chức năng đã được gửi qua
            if (pqkh != null)
            {
                if (pqkh.Them == 0)
                {
                    btnThem.Enabled = false;
                    bbiThem.Enabled = false;
                }
                if (pqkh.Xoa == 0)
                {
                    btnXoa.Enabled = false;
                    bbiXoa.Enabled = false;
                }
                if (pqkh.Sua == 0)
                {
                    btnSua.Enabled = false;
                    bbiSua.Enabled = false;
                    gvKhoHang.DoubleClick -= BtnSua_Click;
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
        private void BbiDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.rdmKhoHang.HidePopup();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (CurRowIndex >= 0)
            {
                string maKho = gvKhoHang.GetRowCellValue(CurRowIndex, "MaKho").ToString();
                string tenKho = gvKhoHang.GetRowCellValue(CurRowIndex, "TenKho").ToString();

                DialogResult dr = MessageBox.Show(string.Format("Bạn có chắc chắn muốn xóa Kho:\n\n\t{0}", tenKho), "Thông báo hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    nv_kho.XoaKhoHang(maKho);
                    FillGridView();
                    AddNhatKy("Xóa");
                    MessageBox.Show("Đã Xóa");
                }
            }
        }

        private void GvKhoHang_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (CurRowIndex >= 0)
            {
                e.Allow = false;
                rdmKhoHang.ShowPopup(gcKhoHang.PointToScreen(e.Point));
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (CurRowIndex >= 0)
            {
                KhoHang kho = LayKhoDangChon();

                frmThemSuaKhoHang frmSua = new frmThemSuaKhoHang(kho);
                frmSua.CapNhatThanhCong += FillGridView;
                frmSua.CapNhatThanhCong += NhatKySua;
                frmSua.ShowDialog();
            }
        }

        private KhoHang LayKhoDangChon()
        {
            KhoHang kho = new KhoHang();

            kho.MaKho = gvKhoHang.GetRowCellValue(CurRowIndex, "MaKho").ToString();
            kho.TenKho = gvKhoHang.GetRowCellValue(CurRowIndex, "TenKho").ToString();
            kho.NguoiLienHe = gvKhoHang.GetRowCellValue(CurRowIndex, "NguoiLienHe").ToString();
            kho.DiaChi = gvKhoHang.GetRowCellValue(CurRowIndex, "DiaChi").ToString();
            kho.DienThoai = gvKhoHang.GetRowCellValue(CurRowIndex, "DienThoai").ToString();
            kho.KyHieu = gvKhoHang.GetRowCellValue(CurRowIndex, "KyHieu").ToString();
            kho.DienGiai = gvKhoHang.GetRowCellValue(CurRowIndex, "DienGiai").ToString();
            kho.ConQuanLy = bool.Parse(gvKhoHang.GetRowCellValue(CurRowIndex, "ConQuanLy").ToString());
            kho.Fax= gvKhoHang.GetRowCellValue(CurRowIndex, "Fax").ToString();
            kho.Email = gvKhoHang.GetRowCellValue(CurRowIndex, "Email").ToString();
            kho.NguoiQuanLy = gvKhoHang.GetRowCellValue(CurRowIndex, "NguoiQuanLy").ToString();

            return kho;
        }

        private void GvKhoHang_ShowingEditor(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void GvKhoHang_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            CurRowIndex = int.Parse(e.FocusedRowHandle.ToString());
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            frmThemSuaKhoHang frmtkh = new frmThemSuaKhoHang();
            frmtkh.ThemThanhCong += FillGridView;
            frmtkh.ThemThanhCong += NhatKyThem;
            frmtkh.ShowDialog();
        }

        private void UcKhoHang_Load(object sender, EventArgs e)
        {
            AddNhatKy("Xem");
            FillGridView();
        }

        private void FillGridView()
        {
            string sql = "select * from KHOHANG";
            DataTable dt = Execute.LayDuLieuBang(sql);
            gcKhoHang.DataSource = dt;
        }
    }
}
