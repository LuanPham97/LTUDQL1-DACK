using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QUANLYBANHANG.DAO;
using QUANLYBANHANG.DTO;
using QUANLYBANHANG.BUS;

namespace QUANLYBANHANG.GUI.tabDanhMuc
{
    public partial class ucKhoHang : DevExpress.XtraEditors.XtraUserControl
    {
        public ucKhoHang(VaiTro_ChucNang pqkh)
        {
            InitializeComponent();

            Load += UcKhoHang_Load;

            //sự kiện button
            btnThem.Click += BtnThem_Click;
        
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            frmThemKhoHang frmtkh = new frmThemKhoHang();
            frmtkh.KhiThemThanhCong += FillGridView;
            frmtkh.ShowDialog();
        }

        private void UcKhoHang_Load(object sender, EventArgs e)
        {
            FillGridView();
        }

        private void FillGridView()
        {
            string sql = "select * from KHOHANG";
            DataTable dt = Execute.LayDuLieuBang(sql);
            gcKhoHang.DataSource = dt;
        }
    }
}
