using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYBANHANG.DAO;
using System.Diagnostics;
using System.IO;
using QUANLYBANHANG.DTO;

namespace QUANLYBANHANG.GUI.tabChucNang
{
    public partial class ucBaoCaoKhoHang : UserControl
    {
        //tạo event lưu nhật ký hệ thống
        public delegate void dBCKhoHang(cNhatKyHeThong diary);
        public event dBCKhoHang ThemNhatKyHeThong;

        // username
        string user;

        // tên chức năng hiện tại
        string TenChucNang = "Báo Cáo Kho Hàng";

        public ucBaoCaoKhoHang(VaiTro_ChucNang pqbc, string un)
        {
            InitializeComponent();

            user = un;

            Load += UcBaoCaoKhoHang_Load;

            btnXuat.Click += BtnXuat_Click;
            btnIn.Click += BtnIn_Click;
            btnRPTHH.Click += BtnRPTHH_Click;

            bbiXuat.ItemClick += BtnXuat_Click;
            bbiIn.ItemClick += BtnIn_Click;

            bbiXuat.CloseRadialMenuOnItemClick = true;
            bbiIn.CloseRadialMenuOnItemClick = true;

            gvBCKhoHang.ShowingEditor += GvBCKhoHang_ShowingEditor;
            gvBCKhoHang.PopupMenuShowing += GvBCKhoHang_PopupMenuShowing;
        }

        private void BtnRPTHH_Click(object sender, EventArgs e)
        {
            frmPRT r = new frmPRT();
            r.ShowDialog();
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

        private void GvBCKhoHang_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            e.Allow = false;
            rdmBC.ShowPopup(gcBCKhoHang.PointToScreen(e.Point));
        }

        private void GvBCKhoHang_ShowingEditor(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void BtnIn_Click(object sender, EventArgs e)
        {
            if (!gcBCKhoHang.IsPrintingAvailable)
            {
                MessageBox.Show("Lỗi không thể In", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AddNhatKy("In");
                Cursor.Current = Cursors.WaitCursor;
                gcBCKhoHang.ShowPrintPreview();
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
                        gcBCKhoHang.ExportToXls(FilePath);
                        break;
                    case ".xlsx":
                        gcBCKhoHang.ExportToXlsx(FilePath);
                        break;
                    case ".pdf":
                        gcBCKhoHang.ExportToPdf(FilePath);
                        break;
                    default:
                        break;
                }

                if (File.Exists(FilePath))
                {
                    AddNhatKy("Xuất");
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
            saveFileDialogExcel.FileName = "document bao cao";
        }

        private void UcBaoCaoKhoHang_Load(object sender, EventArgs e)
        {
            AddNhatKy("Xem");
            FillGridView();
        }

        private void FillGridView()
        {
            string sql = "select hh.MaHangHoa, kho.TenKho, hh.TenHang, dv.TenDVTinh, hh.TonHienTai, hh.GiaBanLe, nh.TenNhomHang, hh.ConQuanLy " +
                "from HANGHOA hh, KHOHANG kho, NHOMHANG nh, DONVITINH dv " +
                "where hh.KhoMacDinh=kho.MaKho and hh.PhanLoai=nh.MaNhomHang and hh.DonVi=dv.MaDVTinh";
            DataTable dt = Execute.LayDuLieuBang(sql);
            gcBCKhoHang.DataSource = dt;
            gvBCKhoHang.ExpandAllGroups();
        }
    }
}
