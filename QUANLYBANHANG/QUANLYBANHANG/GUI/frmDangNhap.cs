using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYBANHANG.DTO;
using QUANLYBANHANG.BUS;

namespace QUANLYBANHANG.GUI
{
    public partial class frmDangNhap : Form
    {
        NGHIEPVU_NGUOIDUNG nv_nd = new NGHIEPVU_NGUOIDUNG();

        public frmDangNhap()
        {
            InitializeComponent();

            //load
            Load += FrmDangNhap_Load;

            //event các button
            btnThoat.Click += BtnThoat_Click;
            btnOK.Click += BtnOK_Click;
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            txtTenDangNhap.Text = Properties.Settings.Default.user;
            txtPass.Text = Properties.Settings.Default.pass;
            ckbNhoMK.Checked = Properties.Settings.Default.ckbNhoMK;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            string tendangnhap = txtTenDangNhap.Text;
            int kt = nv_nd.TonTaiDangNhap(tendangnhap, txtPass.Text);
            if (kt == 1)
            {
                //nhớ mật khẩu nếu được check
                Properties.Settings.Default.user = txtTenDangNhap.Text;
                Properties.Settings.Default.pass = 
                    ckbNhoMK.Checked == true ? txtPass.Text : "";
                Properties.Settings.Default.ckbNhoMK = ckbNhoMK.Checked;
                Properties.Settings.Default.Save();

                //this.Close();

                string mavt = nv_nd.LayMaVaiTro(tendangnhap);
                frmMain main = new frmMain(mavt, tendangnhap);
                main.KhiFormDong += CloseForm;
                main.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc Mật khẩu không đúng", "Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CloseForm()
        {
            this.Close();
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
