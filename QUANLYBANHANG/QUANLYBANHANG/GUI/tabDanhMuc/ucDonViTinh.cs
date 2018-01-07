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
using QUANLYBANHANG.GUI.tabDanhMuc;
using DevExpress.XtraBars;

namespace QUANLYBANHANG.GUI
{
    public partial class ucDonViTinh : DevExpress.XtraEditors.XtraUserControl
    {
        //tạo event lưu nhật ký hệ thống
        public delegate void NhatKyHeThong(cNhatKyHeThong diary);
        public event NhatKyHeThong ThemNhatKyHeThong;

        // username
        string user;

        // tên chức năng hiện tại
        string TenChucNang = "Đơn Vị Tính";

        NGHIEPVU_DONVITINH nv_dvt = new NGHIEPVU_DONVITINH();

        //chỉ số dòng hiện tại
        int CurRowIndex;


        public ucDonViTinh(VaiTro_ChucNang phanquyendvt, string un)
        {
            InitializeComponent();
            Load += new EventHandler(ucDonViTinh_Load);

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
            gvDonViTinh.FocusedRowChanged += GvDonViTinh_FocusedRowChanged;
            gvDonViTinh.DoubleClick += BtnSua_Click;
            gvDonViTinh.ShowingEditor += GvDonViTinh_ShowingEditor;

            //show radial menu
            gvDonViTinh.PopupMenuShowing += GvDonViTinh_PopupMenuShowing;

            //phân quyền dựa vào bảng vai trò chức năng đã được gửi qua
            if (phanquyendvt != null)
            {
                if (phanquyendvt.Them == 0)
                {
                    btnThem.Enabled = false;
                    bbiThem.Enabled = false;
                }
                if (phanquyendvt.Xoa == 0)
                {
                    btnXoa.Enabled = false;
                    bbiXoa.Enabled = false;
                }
                if (phanquyendvt.Sua == 0)
                {
                    btnSua.Enabled = false;
                    bbiSua.Enabled = false;
                    gvDonViTinh.DoubleClick -= BtnSua_Click;
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

        private void GvDonViTinh_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (CurRowIndex >= 0)
            {
                e.Allow = false;
                rdmDonViTinh.ShowPopup(gcDonViTinh.PointToScreen(e.Point));
            }
        }

        private void GvDonViTinh_ShowingEditor(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void GvDonViTinh_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            CurRowIndex = int.Parse(e.FocusedRowHandle.ToString());
        }

        private void BbiDong_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.rdmDonViTinh.HidePopup();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (CurRowIndex >= 0)
            {
                DonViTinh dvt = LayDVDangChon();

                frmThemDonViTinh frmSua = new frmThemDonViTinh(dvt);
                frmSua.CapNhatThanhCong += FillGridView;
                frmSua.CapNhatThanhCong += NhatKySua;
                frmSua.ShowDialog();
            }
        }

        private DonViTinh LayDVDangChon()
        {
            DonViTinh dvt = new DonViTinh();

            dvt.MaDVTinh = gvDonViTinh.GetRowCellValue(CurRowIndex, "MaDVTinh").ToString();
            dvt.TenDVTinh = gvDonViTinh.GetRowCellValue(CurRowIndex, "TenDVTinh").ToString();
            dvt.GhiChu = gvDonViTinh.GetRowCellValue(CurRowIndex, "GhiChu").ToString();
            dvt.ConQuanLy = bool.Parse(gvDonViTinh.GetRowCellValue(CurRowIndex, "ConQuanLy").ToString());

            return dvt;
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            frmThemDonViTinh frmthem = new frmThemDonViTinh();
            frmthem.ThemThanhCong += FillGridView;
            frmthem.ThemThanhCong += NhatKyThem;
            frmthem.ShowDialog();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (CurRowIndex >= 0)
            {
                string maDVT = gvDonViTinh.GetRowCellValue(CurRowIndex, "MaDVTinh").ToString();
                string tenDVT = gvDonViTinh.GetRowCellValue(CurRowIndex, "TenDVTinh").ToString();

                DialogResult dr = MessageBox.Show(string.Format("Bạn có chắc chắn muốn xóa Đơn Vị Tính:\n\n\t{0}", tenDVT), "Thông báo hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    nv_dvt.XoaDVTinh(maDVT);
                    FillGridView();
                    AddNhatKy("Xóa");
                    MessageBox.Show("Đã Xóa");
                }
            }
        }

        private void ucDonViTinh_Load(object sender, EventArgs e)
        {
            AddNhatKy("Xem");
            FillGridView();
        }

        private void FillGridView()
        {
            string sql = "select * from DONVITINH";
            DataTable dvt = Execute.LayDuLieuBang(sql);
            gcDonViTinh.DataSource = dvt;
        }
    }
}
