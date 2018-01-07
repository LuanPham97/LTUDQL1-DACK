using QUANLYBANHANG.BUS;
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
    public partial class frmDoiMatKhau : Form
    {
        //tạo event lưu nhật ký hệ thống
        public delegate void NhatKyHeThong(cNhatKyHeThong diary);
        public event NhatKyHeThong ThemNhatKyHeThong;

        // tên chức năng hiện tại
        string TenChucNang = "Đổi Mật Khẩu";

        NGHIEPVU_NGUOIDUNG nv_nd = new NGHIEPVU_NGUOIDUNG();

        string username;

        public frmDoiMatKhau(string tenDangNhap)
        {
            InitializeComponent();

            Load += FrmDoiMatKhau_Load;

            username = tenDangNhap;

            btnThoat.Click += BtnThoat_Click;
            btnDongY.Click += BtnDongY_Click;
        }

        private void FrmDoiMatKhau_Load(object sender, EventArgs e)
        {
            AddNhatKy("Truy Cập");
        }

        private void AddNhatKy(string hanhDong)
        {
            cNhatKyHeThong nk = new cNhatKyHeThong();
            nk.NguoiDung = username;
            nk.MayTinh = System.Environment.MachineName;
            nk.ThoiGian = DateTime.Now;
            nk.ChucNang = TenChucNang;
            nk.HanhDong = hanhDong;

            ThemNhatKyHeThong(nk);
        }

        private void BtnDongY_Click(object sender, EventArgs e)
        {
            string pass = nv_nd.GetPassword(username);
            string oldPass = txtMKCu.Text;

            if(string.Compare(pass, oldPass) != 0)
            {
                MessageBox.Show("Mật Khẩu cũ KHÔNG ĐÚNG", "Sai Mật Khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(string.Compare(txtMKMoi.Text, txtNhapLai.Text) != 0)
                {
                    MessageBox.Show("Mật khẩu nhập lại không trùng khớp!", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int kq = nv_nd.CapNhatMatKhau(username, txtMKMoi.Text);

                    if (kq >= 1)
                    {
                        AddNhatKy("Thành Công");
                        MessageBox.Show("Cập nhật Thành Công!");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật Thất Bại!");
                    }
                }
            }
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
