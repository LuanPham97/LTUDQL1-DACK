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
    public partial class ucNhanVien : DevExpress.XtraEditors.XtraUserControl
    {
        NGHIEPVU_NHANVIEN nv_nv = new NGHIEPVU_NHANVIEN();

        //chỉ số dòng hiện tại
        int CurRowIndex;

        public ucNhanVien(VaiTro_ChucNang phanquyennv)
        {
            InitializeComponent();
            Load += new EventHandler(ucNhanVien_Load);

            //sự kiện button
            btnThem.Click += BtnThem_Click;
            btnSua.Click += BtnSua_Click;
            btnXoa.Click += BtnXoa_Click;

            //button radial menu
            bbiDong.ItemClick += BbiDong_ItemClick1;
            bbiThem.ItemClick += BtnThem_Click;
            bbiSua.ItemClick += BtnSua_Click;
            bbiXoa.ItemClick += BtnXoa_Click;

            //radial menu
            bbiSua.CloseRadialMenuOnItemClick = true;
            bbiThem.CloseRadialMenuOnItemClick = true;
            bbiXoa.CloseRadialMenuOnItemClick = true;

            // lấy chỉ số dòng hiện tại
            gvNhanVien.FocusedRowChanged += GvNhanVien_FocusedRowChanged;
            gvNhanVien.DoubleClick += BtnSua_Click;
            gvNhanVien.ShowingEditor += GvNhanVien_ShowingEditor;

            //show radial menu
            gvNhanVien.PopupMenuShowing += GvNhanVien_PopupMenuShowing;

            //phân quyền dựa vào bảng vai trò chức năng đã được gửi qua
            if (phanquyennv != null)
            {
                if (phanquyennv.Them == 0)
                {
                    btnThem.Enabled = false;
                    bbiThem.Enabled = false;
                }
                if (phanquyennv.Xoa == 0)
                {
                    btnXoa.Enabled = false;
                    bbiXoa.Enabled = false;
                }
                if (phanquyennv.Sua == 0)
                {
                    btnSua.Enabled = false;
                    bbiSua.Enabled = false;
                    gvNhanVien.DoubleClick -= BtnSua_Click;
                }
            }
        }

        private void GvNhanVien_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (CurRowIndex >= 0)
            {
                e.Allow = false;
                rdmNhanVien.ShowPopup(gcNhanVien.PointToScreen(e.Point));
            }
        }

        private void GvNhanVien_ShowingEditor(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void GvNhanVien_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            CurRowIndex = int.Parse(e.FocusedRowHandle.ToString());
        }

        private void BbiDong_ItemClick1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.rdmNhanVien.HidePopup();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (CurRowIndex >= 0)
            {
                string maNV = gvNhanVien.GetRowCellValue(CurRowIndex, "MaNhanVien").ToString();
                string tenNV = gvNhanVien.GetRowCellValue(CurRowIndex, "TenNhanVien").ToString();

                DialogResult dr = MessageBox.Show(string.Format("Bạn có chắc chắn muốn xóa Nhân Viên:\n\n\t{0}", tenNV), "Thông báo hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    nv_nv.XoaNhanVien(maNV);
                    FillGridView();
                    MessageBox.Show("Đã Xóa");
                }
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (CurRowIndex >= 0)
            {
                NhanVien nv = LayNVDangChon();

                frmThemNhanVien frmSua = new frmThemNhanVien(nv);
                frmSua.KhiThemThanhCong += FillGridView;
                frmSua.ShowDialog();
            }
        }

        private NhanVien LayNVDangChon()
        {
            NhanVien nv = new NhanVien();

            nv.MaNhanVien = gvNhanVien.GetRowCellValue(CurRowIndex, "MaNhanVien").ToString();
            nv.TenNhanVien = gvNhanVien.GetRowCellValue(CurRowIndex, "TenNhanVien").ToString();
            nv.ConQuanLy = bool.Parse(gvNhanVien.GetRowCellValue(CurRowIndex, "ConQuanLy").ToString());
            nv.ChucVu = gvNhanVien.GetRowCellValue(CurRowIndex, "ChucVu").ToString();
            nv.DiaChi = gvNhanVien.GetRowCellValue(CurRowIndex, "DiaChi").ToString();
            nv.Email = gvNhanVien.GetRowCellValue(CurRowIndex, "Email").ToString();
            nv.DienThoai = gvNhanVien.GetRowCellValue(CurRowIndex, "DienThoai").ToString();
            nv.DiDong = gvNhanVien.GetRowCellValue(CurRowIndex, "DiDong").ToString();
            nv.BoPhan = gvNhanVien.GetRowCellValue(CurRowIndex, "BoPhan").ToString();
            nv.NguoiQuanLy = gvNhanVien.GetRowCellValue(CurRowIndex, "NguoiQuanLy").ToString();

            return nv;
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            frmThemNhanVien frmthem = new frmThemNhanVien();
            frmthem.KhiThemThanhCong += FillGridView;
            frmthem.ShowDialog();
        }

        private void ucNhanVien_Load(object sender, EventArgs e)
        {
            FillGridView();
        }

        private void FillGridView()
        {
            string sql = "select * from NHANVIEN";
            DataTable nv = Execute.LayDuLieuBang(sql);
            gcNhanVien.DataSource = nv;
        }
    }
}
