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
        public ucTonKho(VaiTro_ChucNang pqtk)
        {
            InitializeComponent();

            Load += UcTonKho_Load;

            btnXuat.Click += BtnXuat_Click;
            btnIn.Click += BtnIn_Click;
            btnXem.Click += BtnXem_Click;
            btnXemAll.Click += BtnXemAll_Click;

            gvTonKho.ShowingEditor += GvTonKho_ShowingEditor;

            //phân quyền dựa vào bảng vai trò chức năng đã được gửi qua
            if (pqtk != null)
            {
                if (pqtk.Xuat == 0)
                {
                    btnXuat.Enabled = false;
                }
            }
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
