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

namespace QUANLYBANHANG.GUI.tabDanhMuc
{
    public partial class ucTyGia : DevExpress.XtraEditors.XtraUserControl
    {
        //tạo event lưu nhật ký hệ thống
        public delegate void NhatKyHeThong(cNhatKyHeThong diary);
        public event NhatKyHeThong ThemNhatKyHeThong;

        // username
        string user;

        // tên chức năng hiện tại
        string TenChucNang = "Tỷ Giá";

        NGHIEPVU_TYGIA nv_tg = new NGHIEPVU_TYGIA();

        //chỉ số dòng hiện tại
        int CurRowIndex;

        public ucTyGia(VaiTro_ChucNang phanquyentg, string un)
        {
            InitializeComponent();

            user = un;

            Load += new EventHandler(ucTyGia_Load);

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
            gvTyGia.FocusedRowChanged += GvTyGia_FocusedRowChanged;
            gvTyGia.DoubleClick += BtnSua_Click;
            gvTyGia.ShowingEditor += GvTyGia_ShowingEditor;

            //show radial menu
            gvTyGia.PopupMenuShowing += GvTyGia_PopupMenuShowing;

            //phân quyền dựa vào bảng vai trò chức năng đã được gửi qua
            if (phanquyentg != null)
            {
                if (phanquyentg.Them == 0)
                {
                    btnThem.Enabled = false;
                    bbiThem.Enabled = false;
                }
                if (phanquyentg.Xoa == 0)
                {
                    btnXoa.Enabled = false;
                    bbiXoa.Enabled = false;
                }
                if (phanquyentg.Sua == 0)
                {
                    btnSua.Enabled = false;
                    bbiSua.Enabled = false;
                    gvTyGia.DoubleClick -= BtnSua_Click;
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
        private void GvTyGia_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (CurRowIndex >= 0)
            {
                e.Allow = false;
                rdmTyGia.ShowPopup(gcTyGia.PointToScreen(e.Point));
            }
        }

        private void GvTyGia_ShowingEditor(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void GvTyGia_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            CurRowIndex = int.Parse(e.FocusedRowHandle.ToString());
        }

        private void BbiDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.rdmTyGia.HidePopup();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (CurRowIndex >= 0)
            {
                string maTG = gvTyGia.GetRowCellValue(CurRowIndex, "MaTyGia").ToString();
                string tenTG = gvTyGia.GetRowCellValue(CurRowIndex, "TenTyGia").ToString();

                DialogResult dr = MessageBox.Show(string.Format("Bạn có chắc chắn muốn xóa Tỷ Giá:\n\n\t{0}", tenTG), "Thông báo hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    nv_tg.XoaTyGia(maTG);
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
                TyGia tg = LayTGDangChon();

                frmThemTyGia frmSua = new frmThemTyGia(tg);
                frmSua.CapNhatThanhCong += FillGridView;
                frmSua.CapNhatThanhCong += NhatKySua;
                frmSua.ShowDialog();
            }
        }

        private TyGia LayTGDangChon()
        {
            TyGia tg = new TyGia();

            tg.MaTyGia = gvTyGia.GetRowCellValue(CurRowIndex, "MaTyGia").ToString();
            tg.TenTyGia = gvTyGia.GetRowCellValue(CurRowIndex, "TenTyGia").ToString();
            tg.TyGiaQuyDoi = int.Parse(gvTyGia.GetRowCellValue(CurRowIndex, "TyGiaQuyDoi").ToString());
            tg.ConQuanLy = bool.Parse(gvTyGia.GetRowCellValue(CurRowIndex, "ConQuanLy").ToString());

            return tg;
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            frmThemTyGia frmthem = new frmThemTyGia();
            frmthem.ThemThanhCong += FillGridView;
            frmthem.ThemThanhCong += NhatKyThem;
            frmthem.ShowDialog();
        }

        private void ucTyGia_Load(object sender, EventArgs e)
        {
            AddNhatKy("Xem");
            FillGridView();
        }

        private void FillGridView()
        {
            string sql = "select * from TYGIA";
            DataTable tg = Execute.LayDuLieuBang(sql);
            gcTyGia.DataSource = tg;
        }
    }
}
