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
    public partial class ucKhuVuc : DevExpress.XtraEditors.XtraUserControl
    {
        //tạo event lưu nhật ký hệ thống
        public delegate void NhatKyHeThong(cNhatKyHeThong nk);
        public event NhatKyHeThong ThemNhatKyHeThong;

        NGHIEPVU_KHUVUC nv_kv = new NGHIEPVU_KHUVUC();

        //chỉ số dòng hiện tại
        int CurRowIndex;

        // username
        string user;

        // tên chức năng
        string TenChucNang = "Khu Vực";

        public ucKhuVuc(VaiTro_ChucNang phanquyenkv, string username)
        {
            InitializeComponent();

            Load += new EventHandler(ucKhuVuc_Load);

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
            gvKhuVuc.FocusedRowChanged += GvKhuVuc_FocusedRowChanged;
            gvKhuVuc.DoubleClick += BtnSua_Click;
            gvKhuVuc.ShowingEditor += GvKhuVuc_ShowingEditor;

            //show radial menu
            gvKhuVuc.PopupMenuShowing += GvKhuVuc_PopupMenuShowing;

            //phân quyền dựa vào bảng vai trò chức năng đã được gửi qua
            if (phanquyenkv != null)
            {
                if (phanquyenkv.Them == 0)
                {
                    btnThem.Enabled = false;
                    bbiThem.Enabled = false;
                }
                if (phanquyenkv.Xoa == 0)
                {
                    btnXoa.Enabled = false;
                    bbiXoa.Enabled = false;
                }
                if (phanquyenkv.Sua == 0)
                {
                    btnSua.Enabled = false;
                    bbiSua.Enabled = false;
                    gvKhuVuc.DoubleClick -= BtnSua_Click;
                }
            }

        }

        private void GvKhuVuc_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (CurRowIndex >= 0)
            {
                e.Allow = false;
                rdmKhuVuc.ShowPopup(gcKhuVuc.PointToScreen(e.Point));
            }
        }

        private void GvKhuVuc_ShowingEditor(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void GvKhuVuc_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            CurRowIndex = int.Parse(e.FocusedRowHandle.ToString());
        }

        private void BbiDong_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.rdmKhuVuc.HidePopup();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (CurRowIndex >= 0)
            {
                string maKV = gvKhuVuc.GetRowCellValue(CurRowIndex, "MaKhuVuc").ToString();
                string tenKV = gvKhuVuc.GetRowCellValue(CurRowIndex, "TenKhuVuc").ToString();

                DialogResult dr = MessageBox.Show(string.Format("Bạn có chắc chắn muốn xóa Khu Vực:\n\n\t{0}", tenKV), "Thông báo hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    nv_kv.XoaKhuVuc(maKV);
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
                KhuVuc kv = LayKVDangChon();

                frmThemKhuVuc frmSua = new frmThemKhuVuc(kv);
                frmSua.CapNhatThanhCong += FillGridView;
                frmSua.CapNhatThanhCong += NhatKyCapNhat;
                frmSua.ShowDialog();
            }
        }

        private KhuVuc LayKVDangChon()
        {
            KhuVuc kv = new KhuVuc();

            kv.MaKhuVuc = gvKhuVuc.GetRowCellValue(CurRowIndex, "MaKhuVuc").ToString();
            kv.TenKhuVuc = gvKhuVuc.GetRowCellValue(CurRowIndex, "TenKhuVuc").ToString();
            kv.GhiChu = gvKhuVuc.GetRowCellValue(CurRowIndex, "GhiChu").ToString();
            kv.ConQuanLy = bool.Parse(gvKhuVuc.GetRowCellValue(CurRowIndex, "ConQuanLy").ToString());

            return kv;
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            frmThemKhuVuc frmthem = new frmThemKhuVuc();
            frmthem.ThemThanhCong += FillGridView;
            frmthem.ThemThanhCong += NhatKyThem;
            frmthem.ShowDialog();
        }

        private void NhatKyCapNhat()
        {
            AddNhatKy("Cập Nhật");
        }

        private void NhatKyThem()
        {
            AddNhatKy("Thêm");
        }

        private void ucKhuVuc_Load(object sender, EventArgs e)
        {
            // thêm nhật ký
            AddNhatKy("Xem");
            //
            FillGridView();
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

        private void FillGridView()
        {
            string sql = "select * from KHUVUC";
            DataTable kv = Execute.LayDuLieuBang(sql);
            gcKhuVuc.DataSource = kv;
        }
    }
}
