using QUANLYBANHANG.BUS;
using QUANLYBANHANG.DAO;
using QUANLYBANHANG.DTO;
using QUANLYBANHANG.GUI.tabDanhMuc;
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

        //event khi thêm khách hàng thành công
        public delegate void dKhachHang();
        public event dKhachHang ThemThanhCong;
        public event dKhachHang CapNhatThanhCong;

        // lưu trạng thái là đang thêm đang sửa
        bool isInsert;

        //thêm
        public frmThemSuaKhachHang()
        {
            InitializeComponent();

            isInsert = true;
            this.Text = "Thêm Khách Hàng";
            Load += FrmThemSuaKhachHang_Load;

            //xử lý button
            btnDong.Click += BtnDong_Click;
            btnLuu.Click += BtnLuu_Click;

            lkueKhuVuc.ButtonClick += LkueKhuVuc_ButtonClick;
        }

        private void LkueKhuVuc_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                frmThemKhuVuc kv = new frmThemKhuVuc();
                kv.ThemThanhCong += FillCbKhuVuc;
                kv.ShowDialog();
            }
        }

        //sửa
        public frmThemSuaKhachHang(DTO.KhachHang kh)
        {
            InitializeComponent();


            isInsert = false;
            this.Text = "Cập Nhật Khách Hàng";

            FillCbKhuVuc();
            txtNoHienTai.Text = "0";

            //xử lý button
            btnDong.Click += BtnDong_Click;
            btnLuu.Click += BtnLuu_Click;

            FillDuLieu(kh);

            lkueKhuVuc.ButtonClick += LkueKhuVuc_ButtonClick;
        }

        private void FillDuLieu(DTO.KhachHang kh)
        {
            rbKhachLe.Checked = kh.LaKhachLe;
            cbConQuanLy.Checked = kh.ConQuanLy;
            txtMaKhachHang.Text = kh.MaKH;
            txtMaKhachHang.ReadOnly = true;
            lkueKhuVuc.EditValue = kh.MaKhuVuc;
            txtTenKhachHang.Text = kh.TenKH;
            txtDiaChi.Text = kh.DiaChi;
            txtMaSoThue.Text = kh.MaSoThue;
            txtFax.Text = kh.Fax;
            txtDienThoai.Text = kh.DienThoai;
            txtMobile.Text = kh.Mobile;
            txtEmail.Text = kh.Email;
            txtWebSite.Text = kh.Website;
            txtTaiKhoan.Text = kh.TaiKhoan;
            txtNganHang.Text = kh.NganHang;
            ceGioiHanNo.Value = kh.GioiHanNo;
            txtNoHienTai.Text = kh.NoHienTai.ToString();
            ceChietKhau.Value = kh.ChietKhau;
            txtNickYahoo.Text = kh.AccYahoo;
            txtNickSkype.Text = kh.AccSkype;
            txtNguoiLienHe.Text = kh.NguoiLienHe;
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenKhachHang.Text))
            {
                MessageBox.Show("Không được bỏ trống Tên Khách Hàng", "Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DTO.KhachHang kh = new DTO.KhachHang();
                kh.MaKH = txtMaKhachHang.Text;
                kh.LaKhachLe = rbKhachLe.Checked;
                kh.ConQuanLy = cbConQuanLy.Checked;
                kh.MaKhuVuc = lkueKhuVuc.EditValue.ToString();
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

                if (isInsert == true)
                {
                    int kq = nv_kh.ThemKhachHang(kh);
                    if (kq >= 1)
                    {
                        ThemThanhCong();
                        MessageBox.Show("Thêm Khách Hàng thành công");
                    }
                    else
                        MessageBox.Show("Thêm Khách Hàng thất bại");
                }
                else
                {
                    int kq = nv_kh.CapNhatKhachHang(kh);
                    if (kq >= 1)
                    {
                        CapNhatThanhCong();
                        MessageBox.Show("Cập nhật Khách Hàng thành công");
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

        private void FrmThemSuaKhachHang_Load(object sender, EventArgs e)
        {
            txtMaKhachHang.Text = Execute.GenerateMa("sp_LayMaKHTiepTheo");
            txtMaKhachHang.ReadOnly = true;
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
    }
}
