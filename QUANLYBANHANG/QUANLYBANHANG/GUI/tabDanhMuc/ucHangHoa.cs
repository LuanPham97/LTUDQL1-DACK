using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYBANHANG.BUS;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using QUANLYBANHANG.DTO;

namespace QUANLYBANHANG.GUI
{
    public partial class ucHangHoa : UserControl
    {
        //tạo event lưu nhật ký hệ thống
        public delegate void NhatKyHeThong(cNhatKyHeThong diary);
        public event NhatKyHeThong ThemNhatKyHeThong;

        // username
        string user;

        // tên chức năng hiện tại
        string TenChucNang = "Hàng Hóa";

        NGHIEPVU_HANGHOA nv_hh = new NGHIEPVU_HANGHOA();

        int CurRowIndex;

        public ucHangHoa(VaiTro_ChucNang phanquyenHH, string un)
        {
            InitializeComponent();

            Load += new EventHandler(ucHangHoa_Load);

            user = un;

            //khu vực định nghĩa sự kiện button
            btnThem.Click += new EventHandler(btnThem_click);
            btnSua.Click += new EventHandler(btnSua_click);
            btnXoa.Click += new EventHandler(btnXoa_click);

            //button radial menu
            bbiDong.ItemClick += BbiDong_ItemClick;
            bbiThem.ItemClick += btnThem_click;
            bbiSua.ItemClick += btnSua_click;
            bbiXoa.ItemClick += btnXoa_click;

            rdmHangHoa.AutoExpand = true;
            bbiSua.CloseRadialMenuOnItemClick = true;
            bbiThem.CloseRadialMenuOnItemClick = true;
            bbiXoa.CloseRadialMenuOnItemClick = true;

            // lấy chỉ số dòng hiện tại
            gvHangHoa.FocusedRowChanged += gvHangHoa_FocusedRowChanged;
            gvHangHoa.DoubleClick += new EventHandler(btnSua_click);
            gvHangHoa.ShowingEditor += new CancelEventHandler(gvHangHoa_ShowingEditor);

            //show radial menu
            gvHangHoa.PopupMenuShowing += GvHangHoa_PopupMenuShowing;

            //phân quyền dựa vào bảng vai trò chức năng đã được gửi qua
            if (phanquyenHH != null)
            {
                if (phanquyenHH.Them == 0)
                {
                    btnThem.Enabled = false;
                    bbiThem.Enabled = false;
                }
                if (phanquyenHH.Xoa == 0)
                {
                    btnXoa.Enabled = false;
                    bbiXoa.Enabled = false;
                }
                if (phanquyenHH.Sua == 0)
                {
                    btnSua.Enabled = false;
                    bbiSua.Enabled = false;
                    gvHangHoa.DoubleClick -= btnSua_click;
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
            this.rdmHangHoa.HidePopup();
        }

        private void GvHangHoa_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            if (CurRowIndex >= 0)
            {
                e.Allow = false;
                rdmHangHoa.ShowPopup(gcHangHoa.PointToScreen(e.Point));
            }
        }

        private void gvHangHoa_ShowingEditor(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void btnXoa_click(object sender, EventArgs e)
        {
            if (CurRowIndex >= 0)
            {
                string MaHH = gvHangHoa.GetRowCellValue(CurRowIndex, "MaHangHoa").ToString();
                string TenHH = gvHangHoa.GetRowCellValue(CurRowIndex, "TenHang").ToString();

                DialogResult dr = MessageBox.Show(string.Format("Bạn có chắc chắn muốn xóa sản phẩm:\n\n\t{0}", TenHH), "Thông báo hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    nv_hh.XoaHangHoa(MaHH);
                    FillGridView();
                    AddNhatKy("Xóa");
                    MessageBox.Show("Đã Xóa");
                }
            }
        }

        private void gvHangHoa_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            CurRowIndex = int.Parse(e.FocusedRowHandle.ToString());
        }

        private void btnSua_click(object sender, EventArgs e)
        {
            if (CurRowIndex >= 0)
            {
                HangHoa hh = LayHangHoaDangChon();

                frmThemSuaHangHoa frmSua = new frmThemSuaHangHoa(hh);
                frmSua.CapNhatThanhCong += FillGridView;
                frmSua.CapNhatThanhCong += NhatKySua;
                frmSua.ShowDialog();
            }
        }

        private HangHoa LayHangHoaDangChon()
        {
            HangHoa hh = new HangHoa();

            hh.MaHangHoa = gvHangHoa.GetRowCellValue(CurRowIndex, "MaHangHoa").ToString();
            hh.LoaiHangHoa = gvHangHoa.GetRowCellValue(CurRowIndex, "LoaiHangHoa").ToString();
            hh.KhoMacDinh = gvHangHoa.GetRowCellValue(CurRowIndex, "KhoMacDinh").ToString();
            hh.PhanLoai = gvHangHoa.GetRowCellValue(CurRowIndex, "PhanLoai").ToString();
            hh.MaVachNSX = gvHangHoa.GetRowCellValue(CurRowIndex, "MaVachNSX").ToString();
            hh.TenHang = gvHangHoa.GetRowCellValue(CurRowIndex, "TenHang").ToString();
            hh.DonVi = gvHangHoa.GetRowCellValue(CurRowIndex, "DonVi").ToString();
            hh.XuatXu = gvHangHoa.GetRowCellValue(CurRowIndex, "XuatXu").ToString();

            if (gvHangHoa.GetRowCellValue(CurRowIndex, "TonKhoToiThieu").ToString() == "")
                hh.TonKhoToiThieu = 0;
            else
                hh.TonKhoToiThieu = int.Parse(gvHangHoa.GetRowCellValue(CurRowIndex, "TonKhoToiThieu").ToString());

            if (gvHangHoa.GetRowCellValue(CurRowIndex, "TonHienTai").ToString() == "")
                hh.TonHienTai = 0;
            else
                hh.TonHienTai = int.Parse(gvHangHoa.GetRowCellValue(CurRowIndex, "TonHienTai").ToString());

            hh.NhaCungCap = gvHangHoa.GetRowCellValue(CurRowIndex, "NhaCungCap").ToString();

            if (gvHangHoa.GetRowCellValue(CurRowIndex, "GiaMua").ToString() == "")
                hh.GiaMua = 0;
            else
                hh.GiaMua = int.Parse(gvHangHoa.GetRowCellValue(CurRowIndex, "GiaMua").ToString());

            if (gvHangHoa.GetRowCellValue(CurRowIndex, "GiaBanLe").ToString() == "")
                hh.GiaBanLe = 0;
            else
                hh.GiaBanLe = int.Parse(gvHangHoa.GetRowCellValue(CurRowIndex, "GiaBanLe").ToString());

            if (gvHangHoa.GetRowCellValue(CurRowIndex, "GiaBanSi").ToString() == "")
                hh.GiaBanSi = 0;
            else
                hh.GiaBanSi = int.Parse(gvHangHoa.GetRowCellValue(CurRowIndex, "GiaBanSi").ToString());

            hh.ConQuanLy = gvHangHoa.GetRowCellValue(CurRowIndex, "ConQuanLy").ToString() == "True" ? true : false;

            return hh;
        }

        private void btnThem_click(object sender, EventArgs e)
        {
            frmThemSuaHangHoa frmThem = new frmThemSuaHangHoa();
            frmThem.ThemThanhCong += FillGridView;
            frmThem.ThemThanhCong += NhatKyThem;
            frmThem.ShowDialog();
        }

        private void ucHangHoa_Load(object sender, EventArgs e)
        {
            AddNhatKy("Xem");
            FillGridView();
        }

        public void FillGridView()
        {
            string sql = "select hh.*, nh.TenNhomHang, dv.TenDVTinh, kho.TenKho " +
                "from HANGHOA hh, NHOMHANG nh, DONVITINH dv, KHOHANG kho " +
                "where hh.DonVi=dv.MaDVTinh and hh.PhanLoai=nh.MaNhomHang and hh.KhoMacDinh = kho.MaKho";
            DataTable hh = nv_hh.LayDuLieuHangHoa(sql);
            gcHangHoa.DataSource = hh;
            gvHangHoa.ExpandAllGroups();
        }
    }
}
