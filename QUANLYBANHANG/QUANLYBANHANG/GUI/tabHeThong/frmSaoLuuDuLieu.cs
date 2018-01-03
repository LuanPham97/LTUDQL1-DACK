using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYBANHANG.GUI.tabHeThong
{
    public partial class frmSaoLuuDuLieu : Form
    {
        public frmSaoLuuDuLieu()
        {
            InitializeComponent();

            btnOpenFile.Click += BtnOpenFile_Click;
            btnDong.Click += btnDong_click;
            btnThucHien.Click += BtnThucHien_Click;
        }

        private void BtnThucHien_Click(object sender, EventArgs e)
        {
            string duongDanCuoi = txtDuongDan.Text + "\\" + txtTenTapTin.Text;
            MessageBox.Show(duongDanCuoi);
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
