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
    public partial class ucBangKeThuTien : UserControl
    {
        //
        public delegate void dBangKe();
        public event dBangKe Xuat;

        public ucBangKeThuTien()
        {
            InitializeComponent();

            Load += UcBangKeThuTien_Load;

            btnXuat.Click += BtnXuat_Click;
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
                        gcBangKeThuTien.ExportToXls(FilePath);
                        break;
                    case ".xlsx":
                        gcBangKeThuTien.ExportToXlsx(FilePath);
                        break;
                    case ".pdf":
                        gcBangKeThuTien.ExportToPdf(FilePath);
                        break;
                    default:
                        break;
                }

                if (File.Exists(FilePath))
                {
                    Xuat();

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

        private void UcBangKeThuTien_Load(object sender, EventArgs e)
        {
            FillGridView();
        }

        private void FillGridView()
        {
            string sql = "select pt.*, kh.TenKH " +
                "from PHIEUTHUTIEN pt, KHACH_HANG kh " +
                "where pt.MaKH=kh.MaKH";

            DataTable dt = Execute.LayDuLieuBang(sql);
            gcBangKeThuTien.DataSource = dt;
            gvBangKeThuTien.ExpandAllGroups();
        }
    }
}
