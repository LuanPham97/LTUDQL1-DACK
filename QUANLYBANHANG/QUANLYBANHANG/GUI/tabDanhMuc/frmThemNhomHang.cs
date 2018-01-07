using QUANLYBANHANG.BUS;
using QUANLYBANHANG.DAO;
using QUANLYBANHANG.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYBANHANG.GUI.tabDanhMuc
{
    public partial class frmThemNhomHang : Form
    {
        NGHIEPVU_NHOMHANG nv_nh = new NGHIEPVU_NHOMHANG();

        //event khi thêm thành công
        public delegate void dNhomHang();
        public event dNhomHang ThemThanhCong;
        public event dNhomHang CapNhatThanhCong;

        // lưu trạng thái là đang thêm đang sửa
        bool isInsert;

        //dùng để thêm
        public frmThemNhomHang()
        {
            InitializeComponent();

            isInsert = true;
            Load += FrmThemNhomHang_Load;
            this.Text = "Thêm Nhóm Hàng";

            // button
            btnLuu.Click += BtnLuu_Click;
            btnDong.Click += BtnDong_Click;
        }

        //dùng để sửa
        public frmThemNhomHang(DTO.NhomHang nh)
        {
            InitializeComponent();

            isInsert = false;
            this.Text = "Cập nhật Nhóm Hàng";

            // button
            btnLuu.Click += BtnLuu_Click;
            btnDong.Click += BtnDong_Click;

            FillNhomHang(nh);
        }

        private void FillNhomHang(DTO.NhomHang nh)
        {
            txtMaNhomHang.Text = nh.MaNhomHang;
            txtMaNhomHang.ReadOnly = true;
            txtTenNhomHang.Text = nh.TenNhomHang;
            txtGhiChu.Text = nh.GhiChu;
            cbConQuanLy.Checked = nh.ConQuanLy;
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenNhomHang.Text))
                MessageBox.Show("Không được bỏ trống Tên Nhóm Hàng");
            else
            {
                DTO.NhomHang nh = new DTO.NhomHang();
                nh.MaNhomHang = txtMaNhomHang.Text;
                nh.TenNhomHang = txtTenNhomHang.Text;
                nh.GhiChu = txtGhiChu.Text;
                nh.ConQuanLy = cbConQuanLy.Checked;

                if (isInsert == true)
                {
                    int kq = nv_nh.ThemNhomHang(nh);
                    if (kq >= 1)
                    {
                        ThemThanhCong();
                        MessageBox.Show("Thêm thành công");
                    }
                    else
                        MessageBox.Show("Thất Bại");
                }
                else
                {
                    int kq = nv_nh.CapNhatNhomHang(nh);
                    if (kq >= 1)
                    {
                        CapNhatThanhCong();
                        MessageBox.Show("Cập nhật thành công");
                    }
                    else
                        MessageBox.Show("Thất Bại");
                }
            }
        }

        private void BtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmThemNhomHang_Load(object sender, EventArgs e)
        {
            txtMaNhomHang.Text = Execute.GenerateMa("sp_LayMaNhomHang");
            txtMaNhomHang.ReadOnly = true;
        }
    }
}
