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
using System.IO;
using System.Diagnostics;

namespace QUANLYBANHANG.GUI.tabChucNang.TraTien
{
    public partial class ucBangKePhieuChi : UserControl
    {
        //
        public delegate void dBangKe();
        public event dBangKe Xuat;

        public ucBangKePhieuChi()
        {
            InitializeComponent();

            Load += UcBangKePhieuChi_Load;

            btnXuat.Click += BtnXuat_Click;
        }

        private void BtnXuat_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            saveFileDialogExcel.Filter = "Microsoft Excel (2003)(*.xls)|*.xls|Microsoft Excel (2010) (*.xlsx)|*.xlsx |PDF File (*.pdf)|*.pdf";
            saveFileDialogExcel.Title = "Save as";
            saveFileDialogExcel.FileName = "document";
            DialogResult dr = saveFileDialogExcel.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string FilePath = saveFileDialogExcel.FileName;
                string fileExtension = new FileInfo(FilePath).Extension;

                switch (fileExtension)
                {
                    case ".xls":
                        gcBangKeChiTien.ExportToXls(FilePath);
                        break;
                    case ".xlsx":
                        gcBangKeChiTien.ExportToXlsx(FilePath);
                        break;
                    case ".pdf":
                        gcBangKeChiTien.ExportToPdf(FilePath);
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

        private void UcBangKePhieuChi_Load(object sender, EventArgs e)
        {
            FillGridView();
        }

        private void FillGridView()
        {
            string sql = "select pc.*, ncc.TenNCC " +
                "from PHIEUCHITIEN pc, NHACUNGCAP ncc " +
                "where pc.MaNCC=ncc.MaNCC";

            DataTable dt = Execute.LayDuLieuBang(sql);
            gcBangKeChiTien.DataSource = dt;
            gvBangKeChiTien.ExpandAllGroups();
        }
    }
}
