using QUANLYBANHANG.BUS;
using QUANLYBANHANG.DAO;
using QUANLYBANHANG.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYBANHANG.GUI
{
    public partial class frmThemSuaKhachHang : Form
    {
        NGHIEPVU_KHACHHANG nv_kh = new NGHIEPVU_KHACHHANG();

        public frmThemSuaKhachHang()
        {
            InitializeComponent();

            Load += FrmThemSuaKhachHang_Load;

            //xử lý button
            btnDong.Click += BtnDong_Click;
            btnLuu.Click += BtnLuu_Click;
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenKhachHang.Text))
            {
                MessageBox.Show("Không được bỏ trống Tên Khách Hàng", "Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                KhachHang kh = new KhachHang();
                kh.MaKH = txtMaKhachHang.Text;
                kh.LaKhachLe = rbKhachLe.Checked ? 1 : 0;
                kh.ConQuanLy = cbConQuanLy.Checked ? 1 : 0;
                kh.MaKV = lkueKhuVuc.EditValue.ToString();
                kh.TenKH = txtTenKhachHang.Text;
                kh.DiaChi = txtDiaChi.Text;
                kh.MaSoThue = txtMaSoThue.Text;
                kh.Fax = txtFax.Text;
                kh.DienThoai = txtDienThoai.Text;
                kh.Mobile = txtMobile.Text;
                kh.Email = txtEmail.Text;
                kh.Website = txtWebSite.Text;
                kh.TaiKhoan = txtTaiKhoan.Text;
                kh.NganHang = txtNganHang.Text;
                kh.GioiHanNo = ceGioiHanNo.EditValue != null ? int.Parse(ceGioiHanNo.EditValue.ToString()) : 0;
                kh.NoHienTai = 0;
                kh.ChietKhau = ceChietKhau.EditValue != null ? int.Parse(ceChietKhau.EditValue.ToString()) : 0;
                kh.AccSkype = txtNickSkype.Text;
                kh.AccYahoo = txtNickYahoo.Text;
                kh.NguoiLienHe = txtNguoiLienHe.Text;

                int kq = nv_kh.ThemKhachHang(kh);
                if (kq >= 1)
                    MessageBox.Show("Thêm Khách Hàng thành công");
                else
                    MessageBox.Show("Thêm Khách Hàng thất bại");
            }
        }

        private void BtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmThemSuaKhachHang_Load(object sender, EventArgs e)
        {
            GenerateMaKH();
            FillCbKhuVuc();
            txtNoHienTai.Text = "0";
        }

        private void GenerateMaKH()
        {
            string sql = "sp_LayMaKHTiepTheo";

            Provider p = new Provider();
            p.Connect();

            SqlParameter ma = new SqlParameter("@kq", SqlDbType.VarChar, 10);
            ma.Direction = ParameterDirection.Output;

            p.ExecuteNonQuery(CommandType.StoredProcedure, sql, ma);

            p.Disconnect();

            txtMaKhachHang.Text = ma.Value.ToString();

            txtMaKhachHang.ReadOnly = true;
        }

        private void FillCbKhuVuc()
        {
            string sql = "select MaKhuVuc, TenKhuVuc from KHUVUC";
            DataTable dt = Execute.LayDuLieuBang(sql);

            lkueKhuVuc.Properties.DataSource = dt;
            lkueKhuVuc.Properties.ValueMember = "MaKhuVuc";
            lkueKhuVuc.Properties.DisplayMember = "TenKhuVuc";
            lkueKhuVuc.ItemIndex = 0;
        }
    }
}
