﻿using QUANLYBANHANG.BUS;
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
    public partial class frmThemBoPhan : Form
    {
        NGHIEPVU_BOPHAN nv_bp = new NGHIEPVU_BOPHAN();

        //event khi thêm thành công
        public delegate void ThemBoPhan();
        public event ThemBoPhan KhiThemThanhCong;

        // lưu trạng thái là đang thêm đang sửa
        bool isInsert;

        //dùng để thêm
        public frmThemBoPhan()
        {
            InitializeComponent();

            isInsert = true;
            this.Text = "Thêm Bộ Phận";

            // button
            btnLuu.Click += BtnLuu_Click;
            btnDong.Click += BtnDong_Click;
        }

        //dùng để sửa
        public frmThemBoPhan(BoPhan bp)
        {
            InitializeComponent();

            isInsert = false;
            this.Text = "Cập nhật Bộ Phận";

            // button
            btnLuu.Click += BtnLuu_Click;
            btnDong.Click += BtnDong_Click;

            FillBoPhan(bp);
        }

        private void FillBoPhan(BoPhan bp)
        {
            txtMaBoPhan.Text = bp.MaBoPhan;
            txtMaBoPhan.ReadOnly = true;
            txtTenBoPhan.Text = bp.TenBoPhan;
            txtGhiChu.Text = bp.GhiChu;
            cbConQuanLy.Checked = bp.ConQuanLy;
        }

        private void BtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaBoPhan.Text)||string.IsNullOrEmpty(txtTenBoPhan.Text))
                MessageBox.Show("Không được bỏ trống Tên hoặc Mã");
            else
            {
                BoPhan bp = new BoPhan();
                bp.MaBoPhan = txtMaBoPhan.Text;
                bp.TenBoPhan = txtTenBoPhan.Text;
                bp.GhiChu = txtGhiChu.Text;
                bp.ConQuanLy = cbConQuanLy.Checked;

                if (isInsert == true)
                {
                    int kq = nv_bp.ThemBoPhan(bp);
                    if (kq >= 1)
                    {
                        KhiThemThanhCong();
                        MessageBox.Show("Thêm thành công");
                    }
                    else
                        MessageBox.Show("Thất Bại");
                }
                else
                {
                    int kq = nv_bp.CapNhatBoPhan(bp);
                    if (kq >= 1)
                    {
                        KhiThemThanhCong();
                        MessageBox.Show("Cập nhật thành công");
                    }
                    else
                        MessageBox.Show("Thất Bại");
                }
            }
        }
    }
}
