using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYBANHANG.GUI.tabTroGiup
{
    public partial class frmLienHe : Form
    {
        public frmLienHe()
        {
            InitializeComponent();

            Load += FrmLienHe_Load;

            btnKetThuc.Click += BtnKetThuc_Click;
        }

        private void BtnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLienHe_Load(object sender, EventArgs e)
        {
            txtTenDonVi.Text = "ĐH KHOA HỌC TỰ NHIÊN";
            txtDiaChi.Text = "227 Nguyễn Văn Cừ, P.4, Q.5, TPHCM";
            txtDienThoai.Text = "0972129697";

            string[] LinhVuc = new string[] { "1.Sản Xuất", "2.Thương Mại", "3.Dịch Vụ", "4.CNTT", "5.Khác" };
            cbLinhVuc.Items.AddRange(LinhVuc);
            cbLinhVuc.SelectedIndex = 0;

            string[] GioiTinh = new string[] { "Anh", "Chị" };
            cbNguoiLienHe.Items.AddRange(GioiTinh);
            cbNguoiLienHe.SelectedIndex = 0;

            txtNguoiLienHe.Text = "Phạm Đình Luân";
        }
    }
}
