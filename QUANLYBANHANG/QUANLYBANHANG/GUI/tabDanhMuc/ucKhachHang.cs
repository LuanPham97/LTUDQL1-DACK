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

namespace QUANLYBANHANG.GUI
{
    public partial class ucKhachHang : DevExpress.XtraEditors.XtraUserControl
    {
        NGHIEPVU_KHACHHANG nv_kh = new NGHIEPVU_KHACHHANG();
        
        public ucKhachHang(VaiTro_ChucNang phanquyenKH)
        {
            InitializeComponent();

            Load += new EventHandler(ucKhachHang_Load);
        }

        public void ucKhachHang_Load(object sender, EventArgs e)
        {
            FillGridView();
        }

        public void FillGridView()
        {
            string sql = "select * from KHACH_HANG";
            DataTable kh = Execute.LayDuLieuBang(sql);
            gcKhachHang.DataSource = kh;
            gvKhachHang.ExpandAllGroups();
        }
    }
}
