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
        public ucBanHang2(VaiTro_ChucNang vtpq)
        {
            InitializeComponent();

            Load += UcBanHang2_Load;

            //sự kiện thay đổi dữ liệu khi chọn cb khách hàng
            lkueMaKH.EditValueChanged += LkueMaKH_EditValueChanged;
            lkueTenKH.EditValueChanged += LkueTenKH_EditValueChanged;

            //sự kiện ô thay đổi dữ liệu khi người dùng chọn mã
        }

            //var col = e.Column.FieldName;
            //if (col == "TatCa")
            //{
            //    var tmp = tlQuyenHan.EditingValue;

            //    if ((bool)tmp == true)
            //    {
            //        tlQuyenHan.FocusedNode.SetValue(2, false);
            //        tlQuyenHan.FocusedNode.SetValue(3, false);
            //        tlQuyenHan.FocusedNode.SetValue(4, false);
            //        tlQuyenHan.FocusedNode.SetValue(5, false);
            //        tlQuyenHan.FocusedNode.SetValue(6, false);
            //        tlQuyenHan.FocusedNode.SetValue(7, false);
            //        tlQuyenHan.FocusedNode.SetValue(8, false);
            //    }
            //    else if ((bool)tmp == false)
            //    {
            //        tlQuyenHan.FocusedNode.SetValue(2, true);
            //        tlQuyenHan.FocusedNode.SetValue(3, true);
            //        tlQuyenHan.FocusedNode.SetValue(4, true);
            //        tlQuyenHan.FocusedNode.SetValue(5, true);
            //        tlQuyenHan.FocusedNode.SetValue(6, true);
            //        tlQuyenHan.FocusedNode.SetValue(7, true);
            //        tlQuyenHan.FocusedNode.SetValue(8, true);
            //    }
            //}
            //else
            //{
            //    var tmp = tlQuyenHan.EditingValue;

            //    if ((bool)tmp == true)
            //    {
            //        tlQuyenHan.FocusedNode.SetValue(1, false);
            //    }
            //}

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
        }

        private void FillGridView()
        {
            string sql;
            DataTable dt = null;

            //fill cb ma hang
            sql = "select MaHangHoa, TenHang, TonHienTai from HANGHOA";
            dt = Execute.LayDuLieuBang(sql);
            RepositoryItemLookUpEdit rlkue = new RepositoryItemLookUpEdit();
            rlkue.DataSource = dt;
            rlkue.ValueMember = "MaHangHoa";
            rlkue.DisplayMember = "MaHangHoa";
            colMaHang.ColumnEdit = rlkue;

            //fill cb ten hang
            colTenHang.ColumnEdit = rlkue;
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
