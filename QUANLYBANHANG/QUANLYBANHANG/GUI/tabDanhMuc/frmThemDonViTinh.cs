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
    public partial class frmThemDonViTinh : Form
    {
        NGHIEPVU_DONVITINH nv_dvt = new NGHIEPVU_DONVITINH();

        //event khi thêm đơn vị tính thành công
        public delegate void dDonViTinh();
        public event dDonViTinh ThemThanhCong;
        public event dDonViTinh CapNhatThanhCong;

        // lưu trạng thái là đang thêm đang sửa
        bool isInsert;

        //dùng để thêm
        public frmThemDonViTinh()
        {
            InitializeComponent();

            isInsert = true;
            Load += FrmThemDonViTinh_Load;
            this.Text = "Thêm Đơn Vị Tính";

            // button
            btnLuu.Click += BtnLuu_Click;
            btnDong.Click += BtnDong_Click;
        }

        //dùng để sửa
        public frmThemDonViTinh(DTO.DonViTinh dvt)
        {
            InitializeComponent();

            isInsert = false;
            this.Text = "Cập nhật Đơn Vị Tính";

            // button
            btnLuu.Click += BtnLuu_Click;
            btnDong.Click += BtnDong_Click;

            FillDuLieu(dvt);
        }

        private void FillDuLieu(DTO.DonViTinh dvt)
        {
            txtMaDVTinh.Text = dvt.MaDVTinh;
            txtMaDVTinh.ReadOnly = true;
            txtTenDVTinh.Text = dvt.TenDVTinh;
            txtGhiChu.Text = dvt.GhiChu;
            cbConQuanLy.Checked = dvt.ConQuanLy;
        }

        private void BtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenDVTinh.Text))
                MessageBox.Show("Không được bỏ trống Tên Đơn Vị Tính");
            else
            {
                DTO.DonViTinh dvt = new DTO.DonViTinh();
                dvt.MaDVTinh = txtMaDVTinh.Text;
                dvt.TenDVTinh = txtTenDVTinh.Text;
                dvt.GhiChu = txtGhiChu.Text;
                dvt.ConQuanLy = cbConQuanLy.Checked;

                if (isInsert == true)
                {
                    int kq = nv_dvt.ThemDVTinh(dvt);
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
                    int kq = nv_dvt.CapNhatDVTinh(dvt);
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

        private void FrmThemDonViTinh_Load(object sender, EventArgs e)
        {
            txtMaDVTinh.Text = Execute.GenerateMa("sp_LayMaDonViTinh");
            txtMaDVTinh.ReadOnly = true;
        }
    }
}
