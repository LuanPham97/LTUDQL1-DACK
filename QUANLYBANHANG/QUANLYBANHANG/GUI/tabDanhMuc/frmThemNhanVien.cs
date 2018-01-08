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
    public partial class frmThemNhanVien : Form
    {
        NGHIEPVU_NHANVIEN nv_nv = new NGHIEPVU_NHANVIEN();

        //event khi thêm thành công
        public delegate void dNhanVien();
        public event dNhanVien ThemThanhCong;
        public event dNhanVien CapNhatThanhCong;

        // lưu trạng thái là đang thêm đang sửa
        bool isInsert;

        //dùng để thêm
        public frmThemNhanVien()
        {
            InitializeComponent();

            isInsert = true;
            Load += FrmThemNhanVien_Load;
            this.Text = "Thêm Nhân Viên";

            // button
            btnLuu.Click += BtnLuu_Click;
            btnDong.Click += BtnDong_Click;

            lkueBoPhan.ButtonClick += LkueBoPhan_ButtonClick;
        }

        private void LkueBoPhan_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                frmThemBoPhan bp = new frmThemBoPhan();
                bp.ThemThanhCong += FillCbBoPhan;
                bp.ShowDialog();
            }
        }

        //dùng để sửa
        public frmThemNhanVien(DTO.NhanVien nv)
        {
            InitializeComponent();

            FillCbBoPhan();
            FillCbQuanLy();

            isInsert = false;

            this.Text = "Cập nhật Nhân Viên";

            // button
            btnLuu.Click += BtnLuu_Click;
            btnDong.Click += BtnDong_Click;

            FillNhanVien(nv);

            lkueBoPhan.ButtonClick += LkueBoPhan_ButtonClick;
        }

        private void FillNhanVien(DTO.NhanVien nv)
        {
            txtMaNhanVien.Text = nv.MaNhanVien;
            txtMaNhanVien.ReadOnly = true;
            cbConQuanLy.Checked = nv.ConQuanLy;
            txtTenNhanVien.Text = nv.TenNhanVien;
            txtChucVu.Text = nv.ChucVu;
            txtDiaChi.Text = nv.DiaChi;
            txtEmail.Text = nv.Email;
            txtDienThoai.Text = nv.DienThoai;
            txtDiDong.Text = nv.DiDong;
            lkueBoPhan.EditValue = nv.BoPhan;
            lkueQuanLy.EditValue = nv.NguoiQuanLy;
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenNhanVien.Text))
                MessageBox.Show("Không được bỏ trống Tên Nhân Viên");
            else
            {
                DTO.NhanVien nv = new DTO.NhanVien();
                nv.MaNhanVien = txtMaNhanVien.Text;
                nv.TenNhanVien = txtTenNhanVien.Text;
                nv.ChucVu = txtChucVu.Text;
                nv.DiaChi = txtDiaChi.Text;
                nv.Email = txtEmail.Text;
                nv.DienThoai = txtDienThoai.Text;
                nv.DiDong = txtDiDong.Text;
                nv.BoPhan = lkueBoPhan.EditValue != null ? lkueBoPhan.EditValue.ToString() : null;
                nv.NguoiQuanLy = lkueQuanLy.EditValue != null ? lkueQuanLy.EditValue.ToString() : null;
                nv.ConQuanLy = cbConQuanLy.Checked;

                if (isInsert == true)
                {
                    int kq = nv_nv.ThemNhanVien(nv);
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
                    int kq = nv_nv.CapNhatNhanVien(nv);
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

        private void FrmThemNhanVien_Load(object sender, EventArgs e)
        {
            txtMaNhanVien.Text = Execute.GenerateMa("sp_LayMaNhanVien");
            txtMaNhanVien.ReadOnly = true;

            FillCbBoPhan();
            FillCbQuanLy();
        }

        private void FillCbBoPhan()
        {
            string sql = "select TenBoPhan, MaBoPhan from BOPHAN";
            DataTable dt = Execute.LayDuLieuBang(sql);

            lkueBoPhan.Properties.DataSource = dt;
            lkueBoPhan.Properties.ValueMember = "MaBoPhan";
            lkueBoPhan.Properties.DisplayMember = "TenBoPhan";
            lkueBoPhan.ItemIndex = 0;
        }

        private void FillCbQuanLy()
        {
            string sql = "select TenNhanVien, MaNhanVien from NHANVIEN";
            DataTable dt = Execute.LayDuLieuBang(sql);

            lkueQuanLy.Properties.DataSource = dt;
            lkueQuanLy.Properties.ValueMember = "MaNhanVien";
            lkueQuanLy.Properties.DisplayMember = "TenNhanVien";
            lkueQuanLy.ItemIndex = -1;
        }
    }
}
