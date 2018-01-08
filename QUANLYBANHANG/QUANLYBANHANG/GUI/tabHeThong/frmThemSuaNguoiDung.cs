using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYBANHANG.BUS;
using QUANLYBANHANG.DTO;

namespace QUANLYBANHANG.GUI.HeThong
{
    public partial class frmThemSuaNguoiDung : Form
    {
        NGHIEPVU_NHANVIEN nv_nv = new NGHIEPVU_NHANVIEN();
        NGHIEPVU_VAITRO nv_vt = new NGHIEPVU_VAITRO();
        NGHIEPVU_NGUOIDUNG nv_nd = new NGHIEPVU_NGUOIDUNG();

        //event khi thêm người dùng thành công
        public delegate void dNguoiDung();
        public event dNguoiDung ThemThanhCong;
        public event dNguoiDung CapNhatThanhCong;

        //event khi thêm vai trò thành công
        public delegate void ndVaiTro();
        public event ndVaiTro CapNhatVaiTro;

        // lưu trạng thái là đang thêm đang sửa
        int Cur_State = 1;

        // dùng để thêm
        public frmThemSuaNguoiDung()
        {
            InitializeComponent();

            Cur_State = 1;

            Load += new EventHandler(frmLoad_Them);
            btnDong.Click += new EventHandler(btnDong_click);
            btnLuu.Click += new EventHandler(btnLuu_click);

            lkueVaiTro.ButtonClick += LkueVaiTro_ButtonClick;
            lkueNhanVien.EditValueChanged += new EventHandler(lkueNhanVien_editValueChanged);

            this.Text = "Thêm Người Dùng";
        }

        private void LkueVaiTro_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 0)
            {
                frmThemSuaVaiTro vt = new frmThemSuaVaiTro();
                vt.ThemThanhCong += FillCbVaiTro;
                vt.ShowDialog();
            }
        }

        // dùng để sửa
        public frmThemSuaNguoiDung(NguoiDung nd)
        {
            InitializeComponent();

            this.Text = "Sửa Người Dùng";
            Cur_State = 0;

            btnDong.Click += new EventHandler(btnDong_click);
            btnLuu.Click += new EventHandler(btnLuu_click);

            lkueVaiTro.ButtonClick += LkueVaiTro_ButtonClick;
            lkueNhanVien.EditValueChanged += new EventHandler(lkueNhanVien_editValueChanged);

            FillDuLieu(nd);
        }

        private void FillDuLieu(NguoiDung nd)
        {
            FillCbNhanVien();
            FillCbVaiTro();

            lkueNhanVien.EditValue = nd.MaNV;
            txtDienGiai.Text = lkueNhanVien.Text;
            txtTaiKhoan.Text = nd.TenDangNhap;
            txtTaiKhoan.ReadOnly = true;
            txtMatKhau.Text = nd.Password;
            txtReMK.Text = txtMatKhau.Text;
            lkueVaiTro.EditValue = nd.MaVaiTro;
            ckbConQuanLy.Checked = nd.ConQuanLy;
        }

        private void lkueNhanVien_editValueChanged(object sender, EventArgs e)
        {
            txtDienGiai.Text = lkueNhanVien.Text;
        }

        private void frmLoad_Them(object sender, EventArgs e)
        {
            FillCbNhanVien();
            FillCbVaiTro();
        }

        private void FillCbVaiTro()
        {
            string sql = "select MaVaiTro, TenVaiTro from VAITRO";
            DataTable dt = nv_vt.LayDuLieuVaiTro(sql);

            lkueVaiTro.Properties.DataSource = dt;
            lkueVaiTro.Properties.ValueMember = "MaVaiTro";
            lkueVaiTro.Properties.DisplayMember = "TenVaiTro";
            lkueVaiTro.ItemIndex = 0;

            CapNhatVaiTro();
        }

        private void FillCbNhanVien()
        {
            string sql = "select nv.MaNhanVien, nv.TenNhanVien, bp.TenBoPhan from NHANVIEN nv, BOPHAN bp where nv.BoPhan = bp.MaBoPhan";
            DataTable dt = nv_nv.LayDuLieuNV(sql);

            lkueNhanVien.Properties.DataSource = dt;
            lkueNhanVien.Properties.ValueMember = "MaNhanVien";
            lkueNhanVien.Properties.DisplayMember = "TenNhanVien";
            lkueNhanVien.ItemIndex = 0;
        }

        private void btnDong_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_click(object sender, EventArgs e)
        {
            if (Cur_State == 1)
            {
                int KT_NguoiDung = nv_nd.DaTonTai(txtTaiKhoan.Text);
                if (KT_NguoiDung >= 1)
                {
                    MessageBox.Show("Tên người dùng đã tồn tại");
                }
            }
            if (string.Compare(txtMatKhau.Text, txtReMK.Text) != 0)
            {
                MessageBox.Show("Mật khẩu nhập lại không đúng");
            }
            else
            {
                if (string.IsNullOrEmpty(txtTaiKhoan.Text) || string.IsNullOrEmpty(txtMatKhau.Text))
                {
                    MessageBox.Show("Không được để trống tài khoản hoặc mật khẩu");
                }
                else
                {
                    NguoiDung nd = new NguoiDung();
                    nd.TenDangNhap = txtTaiKhoan.Text;
                    nd.Password = txtMatKhau.Text;
                    nd.MaNV = lkueNhanVien.EditValue.ToString();
                    nd.MaVaiTro = lkueVaiTro.EditValue.ToString();
                    nd.DienGiai = txtDienGiai.Text;
                    nd.ConQuanLy = ckbConQuanLy.Checked;

                    //thêm
                    if (Cur_State == 1)
                    {
                        int kq = nv_nd.ThemNguoiDung(nd);
                        if (kq >= 1)
                        {
                            ThemThanhCong();
                            MessageBox.Show("Thêm người dùng thành công");
                        }
                        else
                        {
                            MessageBox.Show("Thêm thất bại");
                        }
                    }

                    //sửa
                    else if (Cur_State == 0)
                    {
                        int kq = nv_nd.CapNhatNguoiDung(nd);
                        if (kq >= 1)
                        {
                            CapNhatThanhCong();
                            MessageBox.Show("Cập nhật người dùng thành công");
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thất bại");
                        }
                    }
                }
            }
        }
    }
}
