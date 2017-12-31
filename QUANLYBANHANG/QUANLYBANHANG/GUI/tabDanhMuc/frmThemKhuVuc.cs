﻿using QUANLYBANHANG.BUS;
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

        //event khi thêm kho hàng thành công
        public delegate void ThemKhuVuc();
        public event ThemKhuVuc KhiThemThanhCong;

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
        public frmThemKhuVuc(KhuVuc kv)
        {
            InitializeComponent();

            isInsert = false;
            this.Text = "Cập nhật Khu Vực";

            // button
            btnLuu.Click += BtnLuu_Click;
            btnDong.Click += BtnDong_Click;

            FillDuLieuKhuVuc(kv);
        }

        private void FillDuLieuKhuVuc(KhuVuc kv)
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
                KhuVuc kv = new KhuVuc();
                kv.MaKhuVuc = txtMaKhuVuc.Text;
                kv.TenKhuVuc = txtTenKhuVuc.Text;
                kv.GhiChu = txtGhiChu.Text;
                kv.ConQuanLy = cbConQuanLy.Checked;

                if (isInsert == true)
                {
                    int kq = nv_kv.ThemKhuVuc(kv);
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
                    int kq = nv_kv.CapNhatKhuVuc(kv);
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

        private void FrmThemKhuVuc_Load(object sender, EventArgs e)
        {
            GenerateMaKhuVuc();
        }

        private void GenerateMaKhuVuc()
        {
            string sql = "sp_LayMaKhuVuc";

            Provider p = new Provider();
            p.Connect();

            SqlParameter ma = new SqlParameter("@kq", SqlDbType.VarChar, 10);
            ma.Direction = ParameterDirection.Output;

            p.ExecuteNonQuery(CommandType.StoredProcedure, sql, ma);

            p.Disconnect();

            txtMaKhuVuc.Text = ma.Value.ToString();
            txtMaKhuVuc.ReadOnly = true;
        }
    }
}
