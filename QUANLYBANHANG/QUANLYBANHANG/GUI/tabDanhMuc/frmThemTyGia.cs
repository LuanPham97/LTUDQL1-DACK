using QUANLYBANHANG.BUS;
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
    public partial class frmThemTyGia : Form
    {
        NGHIEPVU_TYGIA nv_tg = new NGHIEPVU_TYGIA();

        //event khi thêm thành công
        public delegate void dTyGia();
        public event dTyGia ThemThanhCong;
        public event dTyGia CapNhatThanhCong;

        // lưu trạng thái là đang thêm đang sửa
        bool isInsert;

        //dùng để thêm
        public frmThemTyGia()
        {
            InitializeComponent();

            isInsert = true;
            this.Text = "Thêm Tiền Tệ";

            // button
            btnLuu.Click += BtnLuu_Click;
            btnDong.Click += BtnDong_Click;
        }

        //dùng để sửa
        public frmThemTyGia(TyGia tg)
        {
            InitializeComponent();

            isInsert = false;
            this.Text = "Cập nhật Tiền Tệ";

            // button
            btnLuu.Click += BtnLuu_Click;
            btnDong.Click += BtnDong_Click;

            FillTyGia(tg);
        }

        private void FillTyGia(TyGia tg)
        {
            txtMaTyGia.Text = tg.MaTyGia;
            txtMaTyGia.ReadOnly = true;
            txtTenTyGia.Text = tg.TenTyGia;
            ceTyGiaQuyDoi.Value = tg.TyGiaQuyDoi;
            cbConQuanLy.Checked = tg.ConQuanLy;
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenTyGia.Text) || string.IsNullOrEmpty(txtMaTyGia.Text))
                MessageBox.Show("Không được bỏ trống Tên hoặc Mã");
            else
            {
                TyGia tg = new TyGia();
                tg.MaTyGia = txtMaTyGia.Text;
                tg.TenTyGia = txtTenTyGia.Text;
                tg.TyGiaQuyDoi = int.Parse(ceTyGiaQuyDoi.Value.ToString());
                tg.ConQuanLy = cbConQuanLy.Checked;

                if (isInsert == true)
                {
                    if (nv_tg.KiemTraMaTonTai(txtMaTyGia.Text) == true)
                    {
                        MessageBox.Show("Mã này đã tồn tại, vui lòng nhập mã khác", "Trùng Lặp Mã", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        int kq = nv_tg.ThemTyGia(tg);
                        if (kq >= 1)
                        {
                            ThemThanhCong();
                            MessageBox.Show("Thêm thành công");
                        }
                        else
                            MessageBox.Show("Thất Bại");
                    }
                }
                else
                {
                    int kq = nv_tg.CapNhatTyGia(tg);
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
    }
}
