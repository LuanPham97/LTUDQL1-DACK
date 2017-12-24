using QUANLYBANHANG.DAO;
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

namespace QUANLYBANHANG.GUI
{
    public partial class frmThemSuaKhachHang : Form
    {
        public frmThemSuaKhachHang()
        {
            InitializeComponent();

            Load += FrmThemSuaKhachHang_Load;

            //xử lý button
            btnDong.Click += BtnDong_Click;
        }

        private void BtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmThemSuaKhachHang_Load(object sender, EventArgs e)
        {
            GenerateMaKH();
            FillCbKhuVuc();
            txtNoHienTai.Text = "0";
        }

        private void GenerateMaKH()
        {
            string sql = "sp_LayMaKHTiepTheo";

            Provider p = new Provider();
            p.Connect();

            SqlParameter ma = new SqlParameter("@kq", SqlDbType.VarChar, 10);
            ma.Direction = ParameterDirection.Output;

            p.ExecuteNonQuery(CommandType.StoredProcedure, sql, ma);

            p.Disconnect();

            txtMaKhachHang.Text = ma.Value.ToString();

            txtMaKhachHang.ReadOnly = true;
        }

        private void FillCbKhuVuc()
        {
            string sql = "select MaKhuVuc, TenKhuVuc from KHUVUC";
            DataTable dt = Execute.LayDuLieuBang(sql);

            lkueKhuVuc.Properties.DataSource = dt;
            lkueKhuVuc.Properties.ValueMember = "MaKhuVuc";
            lkueKhuVuc.Properties.DisplayMember = "TenKhuVuc";
            lkueKhuVuc.ItemIndex = 0;
        }
    }
}
