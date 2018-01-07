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
using System.Diagnostics;
using DevExpress.XtraPrinting;
using DevExpress.XtraGrid.Views.Grid;
using System.IO;

namespace QUANLYBANHANG.GUI.tabChucNang
{
    public partial class ucTonKho : DevExpress.XtraEditors.XtraUserControl
    {

        //tạo event lưu nhật ký hệ thống
        public delegate void NhatKyHeThong(cNhatKyHeThong diary);
        public event NhatKyHeThong ThemNhatKyHeThong;

        // username
        string user;

        // tên chức năng hiện tại
        string TenChucNang = "Tồn Kho";

        public ucTonKho(VaiTro_ChucNang pqtk, string un)
        {
            InitializeComponent();

            user = un;
            Load += UcTonKho_Load;

            // button
            btnXuat.Click += BtnXuat_Click;
            btnIn.Click += BtnIn_Click;
            btnXem.Click += BtnXem_Click;
            btnXemAll.Click += BtnXemAll_Click;

            // button radial menu
            bbiIn.ItemClick += BtnIn_Click;
            bbiXuat.ItemClick += BtnXuat_Click;
            bbiXemAll.ItemClick += BtnXemAll_Click;
            bbiXem.ItemClick += BtnXem_Click;

            //radial menu
            bbiIn.CloseRadialMenuOnItemClick = true;
            bbiXem.CloseRadialMenuOnItemClick = true;
            bbiXemAll.CloseRadialMenuOnItemClick = true;
            bbiXuat.CloseRadialMenuOnItemClick = true;

            gvTonKho.ShowingEditor += GvTonKho_ShowingEditor;
            gvTonKho.PopupMenuShowing += GvTonKho_PopupMenuShowing;

            //phân quyền dựa vào bảng vai trò chức năng đã được gửi qua
            if (pqtk != null)
            {
                if (pqtk.Xuat == 0)
                {
                    btnXuat.Enabled = false;
                }
            }
        }

        private void GvTonKho_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            e.Allow = false;
            rdmTonKho.ShowPopup(gcTonKho.PointToScreen(e.Point));
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

        private void BtnXemAll_Click(object sender, EventArgs e)
        {
            lkueKho.EditValue = null;
            FillGridView(null);
        }

        private void BtnXem_Click(object sender, EventArgs e)
        {
            if (lkueKho.EditValue != null)
            {
                FillGridView(lkueKho.EditValue.ToString());
            }
        }

        private void BtnIn_Click(object sender, EventArgs e)
        {
            if (!gcTonKho.IsPrintingAvailable)
            {
                MessageBox.Show("Lỗi không thể In", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AddNhatKy("In");
                Cursor.Current = Cursors.WaitCursor;
                gcTonKho.ShowPrintPreview();
            }
        }

        private void BtnXuat_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            PreOpenFileDialog();
            DialogResult dr = saveFileDialogExcel.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string FilePath = saveFileDialogExcel.FileName;
                string fileExtension = new FileInfo(FilePath).Extension;

                switch (fileExtension)
                {
                    case ".xls":
                        gcTonKho.ExportToXls(FilePath);
                        break;
                    case ".xlsx":
                        gcTonKho.ExportToXlsx(FilePath);
                        break;
                    case ".pdf":
                        gcTonKho.ExportToPdf(FilePath);
                        break;
                    default:
                        break;
                }

                if (File.Exists(FilePath))
                {
                    AddNhatKy("Xuất File");

                    if (MessageBox.Show("Bạn có muốn mở file lên không?", "Mở File Đã Xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            Process.Start(FilePath);
                        }
                        catch
                        {
                            MessageBox.Show("Không thể mở file");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("File chưa được lưu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void PreOpenFileDialog()
        {
            saveFileDialogExcel.Filter = "Microsoft Excel (2003)(*.xls)|*.xls|Microsoft Excel (2010) (*.xlsx)|*.xlsx |PDF File (*.pdf)|*.pdf";
            saveFileDialogExcel.Title = "Save as";
            saveFileDialogExcel.FileName = "document";
        }

        private void GvTonKho_ShowingEditor(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void UcTonKho_Load(object sender, EventArgs e)
        {
            AddNhatKy("Xem");
            FillCbKho();
            FillGridView(null);
        }

        private void FillCbKho()
        {
            string sql = "select TenKho, MaKho from KHOHANG";

            DataTable dt = Execute.LayDuLieuBang(sql);

            lkueKho.Properties.DataSource = dt;
            lkueKho.Properties.ValueMember = "MaKho";
            lkueKho.Properties.DisplayMember = "TenKho";
            lkueKho.ItemIndex = -1;
        }

        private void FillGridView(string maKho)
        {
            string temp;
            if (string.IsNullOrEmpty(maKho))
            {
                temp = "";
            }
            else
            {
                temp = string.Format("and hh.KhoMacDinh = '{0}'", maKho);
            }

            string sql = "select kho.TenKho, hh.MaHangHoa, hh.TenHang, dv.TenDVTinh, hh.TonHienTai, nh.TenNhomHang, hh.ConQuanLy " +
                "from HANGHOA hh, KHOHANG kho, DONVITINH dv, NHOMHANG nh " +
                string.Format("where hh.KhoMacDinh=kho.MaKho and hh.DonVi=dv.MaDVTinh and hh.PhanLoai=nh.MaNhomHang {0}", temp);

            gcTonKho.DataSource = Execute.LayDuLieuBang(sql);
            gvTonKho.ExpandAllGroups();
        }
    }
}
