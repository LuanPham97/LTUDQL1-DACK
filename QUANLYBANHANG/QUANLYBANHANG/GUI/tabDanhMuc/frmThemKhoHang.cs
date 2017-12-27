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

namespace QUANLYBANHANG.GUI.tabDanhMuc
{
    public partial class frmThemKhoHang : Form
    {
        NGHIEPVU_KHOHANG nv_kho = new NGHIEPVU_KHOHANG();

        //event khi thêm kho hàng thành công
        public delegate void ThemKhoHang();
        public event ThemKhoHang KhiThemThanhCong;


        public frmThemKhoHang()
        {
            InitializeComponent();

            Load += FrmThemKhoHang_Load;

            // button
            btnLuu.Click += BtnLuu_Click;
            btnDong.Click += BtnDong_Click;
        }

        private void BtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenKho.Text))
                MessageBox.Show("Không được bỏ trống Tên Kho");
            else
            {
                KhoHang kho = new KhoHang();
                kho.MaKho = txtMaKho.Text;
                kho.KyHieu = txtKiHieuKho.Text;
                kho.TenKho = txtTenKho.Text;
                kho.NguoiQuanLy = lkueNguoiQuanLy.EditValue != null ? lkueNguoiQuanLy.EditValue.ToString() : "";
                kho.NguoiLienHe = txtNguoiLienHe.Text;
                kho.DiaChi = txtDiaChi.Text;
                kho.Fax = txtFax.Text;
                kho.DienThoai = txtDienThoai.Text;
                kho.Email = txtEmail.Text;
                kho.DienGiai = txtDienGiai.Text;
                kho.ConQuanLy = cbConQuanLy.Checked;

                int kq = nv_kho.ThemKhoHang(kho);
                if(kq>=1)
                {
                    KhiThemThanhCong();
                    MessageBox.Show("Thêm thành công!");
                }
                else
                {
                    MessageBox.Show("Lỗi thêm");
                }
                  
            }
        }

        private void FrmThemKhoHang_Load(object sender, EventArgs e)
        {
            GenerateMaKho();
            FillCbNguoiQL();
        }

        private void FillCbNguoiQL()
        {
            string sql = "select TenNhanVien, MaNhanVien from NHANVIEN";
            DataTable dt = Execute.LayDuLieuBang(sql);

            lkueNguoiQuanLy.Properties.DataSource = dt;
            lkueNguoiQuanLy.Properties.ValueMember = "MaNhanVien";
            lkueNguoiQuanLy.Properties.DisplayMember = "TenNhanVien";
            lkueNguoiQuanLy.ItemIndex = -1;
        }

        private void GenerateMaKho()
        {
            string sql = "sp_LayMaKhoHang";

            Provider p = new Provider();
            p.Connect();

            SqlParameter ma = new SqlParameter("@kq", SqlDbType.VarChar, 10);
            ma.Direction = ParameterDirection.Output;

            p.ExecuteNonQuery(CommandType.StoredProcedure, sql, ma);

            p.Disconnect();

            txtMaKho.Text = ma.Value.ToString();
            txtMaKho.ReadOnly = true;
        }
    }
}
