using QUANLYBANHANG.BUS;
using QUANLYBANHANG.DAO;
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
using QUANLYBANHANG.DTO;

namespace QUANLYBANHANG.GUI.tabDanhMuc
{
    public partial class frmThemNhaCungCap : Form
    {
        NGHIEPVU_NHACUNGCAP nv_ncc = new NGHIEPVU_NHACUNGCAP();

        //event khi thêm thành công
        public delegate void ThemNCC();
        public event ThemNCC KhiThemThanhCong;

        // lưu trạng thái là đang thêm đang sửa
        bool isInsert;

        //thêm
        public frmThemNhaCungCap()
        {
            InitializeComponent();

            isInsert = true;
            this.Text = "Thêm Nhà Cung Cấp";
            Load += FrmThemNhaCungCap_Load;

            //xử lý button
            btnDong.Click += BtnDong_Click;
            btnLuu.Click += BtnLuu_Click;
        }

        //sửa
        public frmThemNhaCungCap(NhaCC ncc)
        {
            InitializeComponent();


            isInsert = false;
            this.Text = "Cập Nhật Nhà Cung Cấp";

            FillCbKhuVuc();
            txtNoHienTai.Text = "0";

            //xử lý button
            btnDong.Click += BtnDong_Click;
            btnLuu.Click += BtnLuu_Click;

            FillDuLieu(ncc);
        }

        private void FillDuLieu(NhaCC ncc)
        {
            cbConQuanLy.Checked = ncc.ConQuanLy;
            txtMaNCC.Text = ncc.MaNCC;
            txtMaNCC.ReadOnly = true;
            lkueKhuVuc.EditValue = ncc.KhuVuc;
            txtTenNCC.Text = ncc.TenNCC;
            txtDiaChi.Text = ncc.DiaChi;
            txtMaSoThue.Text = ncc.MaSoThue;
            txtFax.Text = ncc.Fax;
            txtDienThoai.Text = ncc.DienThoai;
            txtMobile.Text = ncc.Mobile;
            txtEmail.Text = ncc.Email;
            txtWebsite.Text = ncc.Website;
            txtTaiKhoan.Text = ncc.TaiKhoan;
            txtNganHang.Text = ncc.NganHang;
            ceGioiHanNo.Value = ncc.GioiHanNo;
            txtNoHienTai.Text = ncc.NoHienTai.ToString();
            ceChietKhau.Value = ncc.ChietKhau;
            txtChucVu.Text = ncc.ChucVu;
            txtNguoiLienHe.Text = ncc.NguoiLienHe;
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenNCC.Text))
            {
                MessageBox.Show("Không được bỏ trống Tên Nhà Cung Cấp", "Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                NhaCC ncc = new NhaCC();
                ncc.MaNCC = txtMaNCC.Text;
                ncc.KhuVuc = lkueKhuVuc.EditValue.ToString();
                ncc.TenNCC = txtTenNCC.Text;
                ncc.DiaChi = txtDiaChi.Text;
                ncc.MaSoThue = txtMaSoThue.Text;
                ncc.Fax = txtFax.Text;
                ncc.DienThoai = txtDienThoai.Text;
                ncc.Mobile = txtMobile.Text;
                ncc.Email = txtEmail.Text;
                ncc.Website = txtWebsite.Text;
                ncc.TaiKhoan = txtTaiKhoan.Text;
                ncc.NganHang = txtNganHang.Text;
                ncc.GioiHanNo = ceGioiHanNo.EditValue != null ? int.Parse(ceGioiHanNo.EditValue.ToString()) : 0;
                ncc.NoHienTai = 0;
                ncc.ChietKhau = ceChietKhau.EditValue != null ? int.Parse(ceChietKhau.EditValue.ToString()) : 0;
                ncc.ChucVu = txtChucVu.Text;
                ncc.NguoiLienHe = txtNguoiLienHe.Text;
                ncc.ConQuanLy = cbConQuanLy.Checked;

                if (isInsert == true)
                {
                    int kq = nv_ncc.ThemNCC(ncc);
                    if (kq >= 1)
                    {
                        KhiThemThanhCong();
                        MessageBox.Show("Thêm Nhà Cung Cấp thành công");
                    }
                    else
                        MessageBox.Show("Thêm thất bại");
                }
                else
                {
                    int kq = nv_ncc.CapNhatNCC(ncc);
                    if (kq >= 1)
                    {
                        KhiThemThanhCong();
                        MessageBox.Show("Cập nhật Nhà Cung Cấp thành công");
                    }
                    else
                        MessageBox.Show("Thất bại");
                }
            }
        }

        private void BtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmThemNhaCungCap_Load(object sender, EventArgs e)
        {
            GenerateMaNCC();
            FillCbKhuVuc();
            txtNoHienTai.Text = "0";
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

        private void GenerateMaNCC()
        {
            string sql = "sp_LayMaNCC";

            Provider p = new Provider();
            p.Connect();

            SqlParameter ma = new SqlParameter("@kq", SqlDbType.VarChar, 10);
            ma.Direction = ParameterDirection.Output;

            p.ExecuteNonQuery(CommandType.StoredProcedure, sql, ma);

            p.Disconnect();

            txtMaNCC.Text = ma.Value.ToString();

            txtMaNCC.ReadOnly = true;
        }
    }
}
