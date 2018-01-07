using QUANLYBANHANG.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYBANHANG.GUI.tabHeThong
{
    public partial class frmPhucHoiDuLieu : Form
    {
        //tạo event lưu nhật ký hệ thống
        public delegate void NhatKyHeThong(cNhatKyHeThong diary);
        public event NhatKyHeThong ThemNhatKyHeThong;

        // username
        string user;

        // tên chức năng hiện tại
        string TenChucNang = "Phục Hồi Dữ Liệu";

        public frmPhucHoiDuLieu(string un)
        {
            InitializeComponent();
            user = un;

            Load += FrmPhucHoiDuLieu_Load;

            btnOpenFile.Click += BtnOpenFile_Click;
            btnDong.Click += BtnDong_Click;
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

        private void BtnThucHien_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            string path = txtTenTapTin.Text;
            string Database = "QuanLyBanHang_DoAn";

            if (File.Exists(path) == false)
            {
                MessageBox.Show("Tập tin không tồn tại, vui lòng chọn lại");
                return;
            }
            else
            {
                Execute.RestoreDatabase(path, Database);
                AddNhatKy("Thực Hiện");
                lblPhucHoi.Text = "Phục hồi thành công!";
            }
        }

        private void BtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "BackUp Files (*.bak)|*.bak|All files (*.*)|*.*";

            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtTenTapTin.Text = openFileDialog1.FileName;
            }
        }

        private void FrmPhucHoiDuLieu_Load(object sender, EventArgs e)
        {
            AddNhatKy("Xem");
            string csdl = "QuanLyBanHang_DoAn";
            txtCSDL.Text = csdl;
            txtCSDL.ReadOnly = true;
        }
    }
}
