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
    public partial class frmThemKhuVuc : Form
    {
        NGHIEPVU_KHUVUC nv_kv = new NGHIEPVU_KHUVUC();

        //event khi thêm khu vực thành công
        public delegate void dKhuVuc();
        public event dKhuVuc ThemThanhCong;
        public event dKhuVuc CapNhatThanhCong;

        // lưu trạng thái là đang thêm đang sửa
        bool isInsert;

        //dùng để thêm
        public frmThemKhuVuc()
        {
            InitializeComponent();

            isInsert = true;
            Load += FrmThemKhuVuc_Load;
            this.Text = "Thêm Khu Vực";

            // button
            btnLuu.Click += BtnLuu_Click;
            btnDong.Click += BtnDong_Click;
        }

        //dùng để sửa
        public frmThemKhuVuc(DTO.KhuVuc kv)
        {
            InitializeComponent();

            isInsert = false;
            this.Text = "Cập nhật Khu Vực";

            // button
            btnLuu.Click += BtnLuu_Click;
            btnDong.Click += BtnDong_Click;

            FillDuLieuKhuVuc(kv);
        }

        private void FillDuLieuKhuVuc(DTO.KhuVuc kv)
        {
            txtMaKhuVuc.Text = kv.MaKhuVuc;
            txtMaKhuVuc.ReadOnly = true;
            txtTenKhuVuc.Text = kv.TenKhuVuc;
            txtGhiChu.Text = kv.GhiChu;
            cbConQuanLy.Checked = kv.ConQuanLy;
        }

        private void BtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenKhuVuc.Text))
                MessageBox.Show("Không được bỏ trống Tên khu vực");
            else
            {
                DTO.KhuVuc kv = new DTO.KhuVuc();
                kv.MaKhuVuc = txtMaKhuVuc.Text;
                kv.TenKhuVuc = txtTenKhuVuc.Text;
                kv.GhiChu = txtGhiChu.Text;
                kv.ConQuanLy = cbConQuanLy.Checked;

                if (isInsert == true)
                {
                    int kq = nv_kv.ThemKhuVuc(kv);
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
                    int kq = nv_kv.CapNhatKhuVuc(kv);
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

        private void FrmThemKhuVuc_Load(object sender, EventArgs e)
        {
            txtMaKhuVuc.Text = Execute.GenerateMa("sp_LayMaKhuVuc");
            txtMaKhuVuc.ReadOnly = true;
        }
    }
}
