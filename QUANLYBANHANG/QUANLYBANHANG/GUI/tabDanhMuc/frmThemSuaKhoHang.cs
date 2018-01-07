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
    public partial class frmThemSuaKhoHang : Form
    {
        NGHIEPVU_KHOHANG nv_kho = new NGHIEPVU_KHOHANG();

        //event khi thêm kho hàng thành công
        public delegate void dKhoHang();
        public event dKhoHang ThemThanhCong;
        public event dKhoHang CapNhatThanhCong;

        // lưu trạng thái là đang thêm đang sửa
        bool isInsert;

        //dùng để thêm
        public frmThemSuaKhoHang()
        {
            InitializeComponent();

            isInsert = true;
            Load += FrmThemKhoHang_Load;
            this.Text = "Thêm Kho Hàng";

            // button
            btnLuu.Click += BtnLuu_Click;
            btnDong.Click += BtnDong_Click;
        }

        //dùng để sửa
        public frmThemSuaKhoHang(KhoHang kho)
        {
            InitializeComponent();

            isInsert = false;
            FillCbNguoiQL();

            this.Text = "Cập nhật Kho Hàng";

            // button
            btnLuu.Click += BtnLuu_Click;
            btnDong.Click += BtnDong_Click;

            FillDuLieu(kho);
        }

        private void FillDuLieu(KhoHang kho)
        {
            txtMaKho.Text = kho.MaKho;
            txtMaKho.ReadOnly = true;
            txtKiHieuKho.Text = kho.KyHieu;
            txtTenKho.Text = kho.TenKho;
            lkueNguoiQuanLy.EditValue = kho.NguoiQuanLy;
            txtNguoiLienHe.Text = kho.NguoiLienHe;
            txtDiaChi.Text = kho.DiaChi;
            txtDienThoai.Text = kho.DienThoai;
            txtFax.Text = kho.Fax;
            txtEmail.Text = kho.Email;
            txtDienGiai.Text = kho.DienGiai;
            cbConQuanLy.Checked = kho.ConQuanLy;
        }

        private void BtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenKho.Text))
                MessageBox.Show("Không được bỏ trống Tên Kho");
            if(lkueNguoiQuanLy.EditValue==null)
                MessageBox.Show("Chưa chọn Người quản lý Kho");
            else
            {
                KhoHang kho = new KhoHang();
                kho.MaKho = txtMaKho.Text;
                kho.KyHieu = txtKiHieuKho.Text;
                kho.TenKho = txtTenKho.Text;
                kho.NguoiQuanLy = lkueNguoiQuanLy.EditValue.ToString();
                kho.NguoiLienHe = txtNguoiLienHe.Text;
                kho.DiaChi = txtDiaChi.Text;
                kho.Fax = txtFax.Text;
                kho.DienThoai = txtDienThoai.Text;
                kho.Email = txtEmail.Text;
                kho.DienGiai = txtDienGiai.Text;
                kho.ConQuanLy = cbConQuanLy.Checked;

                if (isInsert == true)
                {
                    int kq = nv_kho.ThemKhoHang(kho);
                    if (kq >= 1)
                    {
                        ThemThanhCong();
                        MessageBox.Show("Thêm thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Lỗi thêm");
                    }
                }
                else
                {
                    int kq = nv_kho.CapNhatKho(kho);
                    if (kq >= 1)
                    {
                        CapNhatThanhCong();
                        MessageBox.Show("Cập nhật thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Lỗi cập nhật");
                    }
                }
            }
        }

        private void FrmThemKhoHang_Load(object sender, EventArgs e)
        {
            txtMaKho.Text = Execute.GenerateMa("sp_LayMaKhoHang");
            txtMaKho.ReadOnly = true;
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
    }
}
