using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYBANHANG.DAO;
using QUANLYBANHANG.DTO;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;

namespace QUANLYBANHANG.GUI
{
    public partial class ucBanHang2 : UserControl
    {
        //vị trí dòng, cột đang chọn
        int rowIndex = -1;
        int colIndex = -1;

        public ucBanHang2(VaiTro_ChucNang vtpq)
        {
            InitializeComponent();

            Load += UcBanHang2_Load;

            //sự kiện thay đổi dữ liệu khi chọn cb khách hàng
            lkueMaKH.EditValueChanged += LkueMaKH_EditValueChanged;
            lkueTenKH.EditValueChanged += LkueTenKH_EditValueChanged;

            //sự kiện ô thay đổi dữ liệu khi người dùng chọn mã hoặc tên hàng
            gvPhieuXuat.CellValueChanged += GvPhieuXuat_CellValueChanged;
            gvPhieuXuat.CellEnter += GvPhieuXuat_CellEnter;
            gvPhieuXuat.KeyUp += GvPhieuXuat_KeyUp;

            //xử lý lỗi khi người dùng nhập liệu sai
            gvPhieuXuat.DataError += GvPhieuXuat_DataError;

            //1000 separator

            //sự kiện các txt phía dưới
        }

        //tính tổng tiền thanh toán
        private long TinhTongTienThanhToan()
        {
            long kq = 0;
            for (int i = 0; i < gvPhieuXuat.Rows.Count; i++)
            {
                if(gvPhieuXuat.Rows[i].Cells["colThanhToan"].Value != null)
                    kq += (long)gvPhieuXuat.Rows[i].Cells["colThanhToan"].Value;
            }

            return kq;
        }

        private void GvPhieuXuat_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Lỗi nhập liệu", "Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void GvPhieuXuat_KeyUp(object sender, KeyEventArgs e)
        {
            if (colIndex == 0 || colIndex == 1)
            {
                if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                {
                    int row = e.KeyCode == Keys.Enter ? rowIndex - 1 : rowIndex;

                    gvPhieuXuat.CurrentCell = gvPhieuXuat.Rows[row].Cells["colSoLuong"];
                }
            }

            else if (colIndex >= 3)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    gvPhieuXuat.CurrentCell = gvPhieuXuat.Rows[rowIndex].Cells[0];
                }
            }
        }

        private void GvPhieuXuat_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            colIndex = e.ColumnIndex;
        }

        private void GvPhieuXuat_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int col = e.ColumnIndex;

            //cột tên hàng hoặc mã hàng
            if (col == 0 || col == 1)
            {
                string mahang = col == 1 ? gvPhieuXuat.Rows[e.RowIndex].Cells["colMaHang"].Value.ToString() :
                    gvPhieuXuat.Rows[e.RowIndex].Cells["colTenHang"].Value.ToString();

                string tendonvi = null;
                long dongia = 0;
                LayThongTinHangHoa(mahang, ref tendonvi, ref dongia);

                if (col == 1)
                    gvPhieuXuat.Rows[e.RowIndex].Cells["colTenHang"].Value = mahang;
                else
                    gvPhieuXuat.Rows[e.RowIndex].Cells["colMaHang"].Value = mahang;

                gvPhieuXuat.Rows[e.RowIndex].Cells["colDonVi"].Value = tendonvi;
                gvPhieuXuat.Rows[e.RowIndex].Cells["colSoLuong"].Value = (long)1;
                gvPhieuXuat.Rows[e.RowIndex].Cells["colDonGia"].Value = dongia;
                gvPhieuXuat.Rows[e.RowIndex].Cells["colThanhTien"].Value = dongia;
                gvPhieuXuat.Rows[e.RowIndex].Cells["colCK"].Value = (long)0;
                gvPhieuXuat.Rows[e.RowIndex].Cells["colChietKhau"].Value = (long)0;
                gvPhieuXuat.Rows[e.RowIndex].Cells["colThanhToan"].Value = dongia;
            }


            // if thay đổi value của 1 trong các cột phía sau thì tính lại thành tiền và thanh toán
            else if (col >= 3 && col != 8)
            {
                if (col == 6 && gvPhieuXuat.Rows[e.RowIndex].Cells["colCK"].Value != null)
                {
                    long ck = (long)gvPhieuXuat.Rows[e.RowIndex].Cells["colCK"].Value;
                    if (ck > 100)
                        gvPhieuXuat.Rows[e.RowIndex].Cells["colCK"].Value = 100;
                    else if (ck < 0)
                        gvPhieuXuat.Rows[e.RowIndex].Cells["colCK"].Value = 0;
                }

                //tính thành tiền
                long thanhtien = 0;
                if(gvPhieuXuat.Rows[e.RowIndex].Cells["colSoLuong"].Value!=null && gvPhieuXuat.Rows[e.RowIndex].Cells["colDonGia"].Value != null)
                {
                    thanhtien = long.Parse(gvPhieuXuat.Rows[e.RowIndex].Cells["colSoLuong"].Value.ToString()) * long.Parse(gvPhieuXuat.Rows[e.RowIndex].Cells["colDonGia"].Value.ToString());
                }
                gvPhieuXuat.Rows[e.RowIndex].Cells["colThanhTien"].Value = thanhtien;

                // tính giá tiền chiết khấu
                long chietKhau = 0;
                if (gvPhieuXuat.Rows[e.RowIndex].Cells["colCK"].Value != null)
                {
                    chietKhau = (long.Parse(gvPhieuXuat.Rows[e.RowIndex].Cells["colThanhTien"].Value.ToString()) * long.Parse(gvPhieuXuat.Rows[e.RowIndex].Cells["colCK"].Value.ToString())) / 100;
                }
                gvPhieuXuat.Rows[e.RowIndex].Cells["colChietKhau"].Value = chietKhau;

                // tính thanh toán
                long thanhtoan = 0;
                thanhtoan = long.Parse(gvPhieuXuat.Rows[e.RowIndex].Cells["colThanhTien"].Value.ToString()) - long.Parse(gvPhieuXuat.Rows[e.RowIndex].Cells["colChietKhau"].Value.ToString());
                gvPhieuXuat.Rows[e.RowIndex].Cells["colThanhToan"].Value = thanhtoan;
            }

            //thanh toan
            else if (col == 8)
            {
                nmrThanhTien.Value = TinhTongTienThanhToan();
            }
        }

        private void LayThongTinHangHoa(string mahang, ref string tdv, ref long dg)
        {
            string sql = "sp_LayTenDonViTinh";

            Provider p = new Provider();
            p.Connect();

            SqlParameter tendv = new SqlParameter("@tendv", SqlDbType.NVarChar, 50);
            tendv.Direction = ParameterDirection.Output;
            SqlParameter dongia = new SqlParameter("@dongia", SqlDbType.Int);
            dongia.Direction = ParameterDirection.Output;

            p.ExecuteNonQuery(CommandType.StoredProcedure, sql,
                new SqlParameter { ParameterName = "@mahh", Value = mahang }, tendv, dongia);

            tdv = tendv.Value.ToString();
            dg = long.Parse(dongia.Value.ToString());

            p.Disconnect();
        }

        private void LkueTenKH_EditValueChanged(object sender, EventArgs e)
        {
            lkueMaKH.EditValue = lkueTenKH.EditValue;
            FilltxtKhachHang(lkueMaKH.EditValue.ToString());
        }

        private void LkueMaKH_EditValueChanged(object sender, EventArgs e)
        {
            lkueTenKH.EditValue = lkueMaKH.EditValue;
            FilltxtKhachHang(lkueTenKH.EditValue.ToString());
        }

        private void FilltxtKhachHang(string makh)
        {
            string sql = "sp_LayThongTinKhachHang";

            Provider p = new Provider();
            p.Connect();

            SqlParameter diachi = new SqlParameter("@diachi", SqlDbType.NVarChar, 100);
            diachi.Direction = ParameterDirection.Output;
            SqlParameter dt = new SqlParameter("@dt", SqlDbType.VarChar, 13);
            dt.Direction = ParameterDirection.Output;

            p.ExecuteNonQuery(CommandType.StoredProcedure, sql, diachi, dt,
                new SqlParameter { ParameterName = "@makh", Value = makh });

            txtDiaChi.Text = diachi.Value.ToString();
            txtSDT.Text = dt.Value.ToString();

            p.Disconnect();
        }

        private void UcBanHang2_Load(object sender, EventArgs e)
        {
            FillThongTinKhachHang();
            FillCbNhanVien();
            FillCbKhoXuat();
            FillDateEdit();
            FillCbDKTT();//điều khoản thanh toán
            FillCbHTTT();//hình thức thanh toán
            txtMaPhieu.Text = GenerateMaPhieu();
            txtMaPhieu.ReadOnly = true;
            FillGridView();

            // format 1000 separator
            gvPhieuXuat.Columns["colThanhToan"].DefaultCellStyle.Format = "#,###";
            gvPhieuXuat.Columns["colChietKhau"].DefaultCellStyle.Format = "#,###";
            gvPhieuXuat.Columns["colThanhTien"].DefaultCellStyle.Format = "#,###";
            gvPhieuXuat.Columns["colDonGia"].DefaultCellStyle.Format = "#,###";


            //gvPhieuXuat.Columns["colThanhToan"].DefaultCellStyle.NullValue = "0";
            //gvPhieuXuat.Columns["colThanhToan"].DefaultCellStyle.NullValue = "0";
        }

        private void FillGridView()
        {
            string sql;
            DataTable dt = null;

            sql = "select MaHangHoa, TenHang from HANGHOA";
            dt = Execute.LayDuLieuBang(sql);

            //fill cb ma hang
            colMaHang.DataSource = dt;
            colMaHang.ValueMember = "MaHangHoa";
            colMaHang.DisplayMember = "MaHangHoa";
            //fill cb ten hang
            colTenHang.DataSource = dt;
            colTenHang.ValueMember = "MaHangHoa";
            colTenHang.DisplayMember = "TenHang";

            //
            colSoLuong.ValueType = typeof(long);
            colDonGia.ValueType = typeof(long);
            colThanhTien.ValueType = typeof(long);
            colChietKhau.ValueType = typeof(long);
            colCK.ValueType = typeof(long);
            colThanhToan.ValueType = typeof(long);
        }

        private string GenerateMaPhieu()
        {
            string sql = "sp_LayMaPhieuXuat";

            Provider p = new Provider();
            p.Connect();

            SqlParameter ma = new SqlParameter("@kq", SqlDbType.VarChar, 10);
            ma.Direction = ParameterDirection.Output;

            p.ExecuteNonQuery(CommandType.StoredProcedure, sql, ma);

            p.Disconnect();

            return ma.Value.ToString();
        }

        private void FillCbDKTT()
        {
            string[] dktt = { "Công Nợ", "Thanh toán ngay" };

            cbDKTT.Items.AddRange(dktt);
            cbDKTT.SelectedIndex = 0;
        }

        private void FillCbHTTT()
        {
            string[] httt = { "Tiền Mặt", "Chuyển Khoản" };

            cbHTTT.Items.AddRange(httt);
            cbHTTT.SelectedIndex = 0;
        }

        private void FillCbNhanVien()
        {
            string sql = "select MaNhanVien, TenNhanVien from NHANVIEN";
            DataTable dt = Execute.LayDuLieuBang(sql);

            lkueMaNV.Properties.DataSource = dt;
            lkueMaNV.Properties.ValueMember = "MaNhanVien";
            lkueMaNV.Properties.DisplayMember = "TenNhanVien";
            lkueMaNV.ItemIndex = 0;
        }

        private void FillThongTinKhachHang()
        {
            string sql = "select MaKH, TenKH from KHACH_HANG";
            DataTable dt = Execute.LayDuLieuBang(sql);

            //cb mã kh
            lkueMaKH.Properties.DataSource = dt;
            lkueMaKH.Properties.ValueMember = "MaKH";
            lkueMaKH.Properties.DisplayMember = "MaKH";
            lkueMaKH.ItemIndex = 0;

            //cb tên kh
            lkueTenKH.Properties.DataSource = dt;
            lkueTenKH.Properties.ValueMember = "MaKH";
            lkueTenKH.Properties.DisplayMember = "TenKH";
            lkueTenKH.ItemIndex = 0;

            //địa chỉ

            //điện thoại

        }

        private void FillCbKhoXuat()
        {
            string sql = "select MaKho, TenKho from KHOHANG";
            DataTable dt = Execute.LayDuLieuBang(sql);

            lkueKho.Properties.DataSource = dt;
            lkueKho.Properties.ValueMember = "MaKho";
            lkueKho.Properties.DisplayMember = "TenKho";
            lkueKho.ItemIndex = 0;
        }

        private void FillDateEdit()
        {
            deNgayLap.EditValue = DateTime.Now;
            deNgayGiao.EditValue = DateTime.Now;
            deHanThanhToan.EditValue = DateTime.Now;
        }
    }
}
