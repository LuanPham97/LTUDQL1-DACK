using QUANLYBANHANG.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYBANHANG.GUI.tabHeThong
{
    public partial class frmSaoLuuDuLieu : Form
    {
        //tạo event lưu nhật ký hệ thống
        public delegate void NhatKyHeThong(cNhatKyHeThong diary);
        public event NhatKyHeThong ThemNhatKyHeThong;

        // username
        string user;

        // tên chức năng hiện tại
        string TenChucNang = "Sao Lưu";

        public frmSaoLuuDuLieu(string un)
        {
            InitializeComponent();

            user = un;
            Load += FrmSaoLuuDuLieu_Load;

            btnOpenFile.Click += BtnOpenFile_Click;
            btnDong.Click += btnDong_click;
            btnThucHien.Click += BtnThucHien_Click;
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

        private void FrmSaoLuuDuLieu_Load(object sender, EventArgs e)
        {
            AddNhatKy("Xem");
            GenerateTxtTenTapTin();

            fbdSaoLuu.SelectedPath = "d:\\";
            txtDuongDan.Text = fbdSaoLuu.SelectedPath;
        }

        private void GenerateTxtTenTapTin()
        {
            string db = "QuanLyBanHang_DoAn";

            string date = DateTime.Now.Day.ToString() + "." +
                DateTime.Now.Month.ToString() + "." +
                DateTime.Now.Year.ToString();

            string time = DateTime.Now.Hour.ToString() + "." +
                DateTime.Now.Minute.ToString();

            string txt = db + "_" + date + "_" + time + ".bak";

            txtTenTapTin.Text = txt;
        }

        private void BtnThucHien_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            string duongDanFinal = "";
            string duongDan = txtDuongDan.Text;
            string tenTapTin = txtTenTapTin.Text;
            string Database = "QuanLyBanHang_DoAn";

            if (tenTapTin.Contains(":") || tenTapTin.Contains("\\") || tenTapTin.Contains("/") ||
                tenTapTin.Contains("*") || tenTapTin.Contains("?") || tenTapTin.Contains("\"") ||
                tenTapTin.Contains("<") || tenTapTin.Contains(">") || tenTapTin.Contains("|"))
            {
                string t = "\\ / : * ? \" < > |";
                MessageBox.Show(string.Format("A name can't contain any of the following characters:\n\t{0}", t), "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Directory.Exists(duongDan) == false)
            {
                MessageBox.Show("Thư mục không tồn tại, vui lòng chọn lại");
                return;
            }

            duongDanFinal = tenTapTin.EndsWith(".bak") == true ? (duongDan + "\\" + tenTapTin) : (duongDan + "\\" + tenTapTin + ".bak");

            //nếu file tồn tại thì xóa file cũ
            if (File.Exists(duongDanFinal))
            {
                File.Delete(duongDanFinal);
            }

            Execute.BackUpDatabase(duongDanFinal, Database);

            AddNhatKy("Thực Hiện");

            Process.Start(duongDan);

            lblSaoLuu.Text = "Sao lưu thành công!";
        }

        private void btnDong_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOpenFile_Click(object sender, EventArgs e)
        {
            DialogResult result = fbdSaoLuu.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtDuongDan.Text = fbdSaoLuu.SelectedPath;
            }
        }
    }
}
