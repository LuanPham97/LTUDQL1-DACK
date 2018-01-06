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
    public partial class ucBoPhan : DevExpress.XtraEditors.XtraUserControl
    {
        //tạo event lưu nhật ký hệ thống
        public delegate void NhatKyHeThong(cNhatKyHeThong diary);
        public event NhatKyHeThong ThemNhatKyHeThong;

        // username
        string user;

        // tên chức năng hiện tại
        string TenChucNang = "Bộ Phận";

        NGHIEPVU_BOPHAN nv_bp = new NGHIEPVU_BOPHAN();

        //chỉ số dòng hiện tại
        int CurRowIndex;

        public ucBoPhan(VaiTro_ChucNang phanquyenbp, string username)
        {
            InitializeComponent();
            Load += new EventHandler(ucBoPhan_Load);

            user = username;

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
            gvBoPhan.FocusedRowChanged += GvBoPhan_FocusedRowChanged;
            gvBoPhan.DoubleClick += BtnSua_Click;
            gvBoPhan.ShowingEditor += GvBoPhan_ShowingEditor;

            //show radial menu
            gvBoPhan.PopupMenuShowing += GvBoPhan_PopupMenuShowing;

            //phân quyền dựa vào bảng vai trò chức năng đã được gửi qua
            if (phanquyenbp != null)
            {
                if (phanquyenbp.Them == 0)
                {
                    btnThem.Enabled = false;
                    bbiThem.Enabled = false;
                }
                if (phanquyenbp.Xoa == 0)
                {
                    btnXoa.Enabled = false;
                    bbiXoa.Enabled = false;
                }
                if (phanquyenbp.Sua == 0)
                {
                    btnSua.Enabled = false;
                    bbiSua.Enabled = false;
                    gvBoPhan.DoubleClick -= BtnSua_Click;
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

        private void GvBoPhan_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (CurRowIndex >= 0)
            {
                e.Allow = false;
                rdmBoPhan.ShowPopup(gcBoPhan.PointToScreen(e.Point));
            }
        }

        private void GvBoPhan_ShowingEditor(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void GvBoPhan_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            CurRowIndex = int.Parse(e.FocusedRowHandle.ToString());
        }

        private void BbiDong_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.rdmBoPhan.HidePopup();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (CurRowIndex >= 0)
            {
                string maBP = gvBoPhan.GetRowCellValue(CurRowIndex, "MaBoPhan").ToString();
                string tenBP = gvBoPhan.GetRowCellValue(CurRowIndex, "TenBoPhan").ToString();

                DialogResult dr = MessageBox.Show(string.Format("Bạn có chắc chắn muốn xóa Bộ Phận:\n\n\t{0}", tenBP), "Thông báo hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    nv_bp.XoaBoPhan(maBP);
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
                BoPhan bp = LayBPDangChon();

                frmThemBoPhan frmSua = new frmThemBoPhan(bp);
                frmSua.CapNhatThanhCong += FillGridView;
                frmSua.CapNhatThanhCong += NhatKySua;
                frmSua.ShowDialog();
            }
        }

        private void NhatKySua()
        {
            AddNhatKy("Cập Nhật");
        }

        private BoPhan LayBPDangChon()
        {
            BoPhan bp = new BoPhan();

            bp.MaBoPhan = gvBoPhan.GetRowCellValue(CurRowIndex, "MaBoPhan").ToString();
            bp.TenBoPhan = gvBoPhan.GetRowCellValue(CurRowIndex, "TenBoPhan").ToString();
            bp.GhiChu = gvBoPhan.GetRowCellValue(CurRowIndex, "GhiChu").ToString();
            bp.ConQuanLy = bool.Parse(gvBoPhan.GetRowCellValue(CurRowIndex, "ConQuanLy").ToString());

            return bp;
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            frmThemBoPhan frmthem = new frmThemBoPhan();
            frmthem.ThemThanhCong += FillGridView;
            frmthem.ThemThanhCong += NhatKyThem;
            frmthem.ShowDialog();
        }

        private void NhatKyThem()
        {
            AddNhatKy("Thêm");
        }

        private void ucBoPhan_Load(object sender, EventArgs e)
        {
            AddNhatKy("Xem");
            FillGridView();
        }

        private void FillGridView()
        {
            string sql = "select * from BOPHAN";
            DataTable bp = Execute.LayDuLieuBang(sql);
            gcBoPhan.DataSource = bp;
        }
    }
}
