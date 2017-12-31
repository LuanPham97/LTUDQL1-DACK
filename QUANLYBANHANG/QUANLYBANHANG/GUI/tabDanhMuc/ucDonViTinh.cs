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
using QUANLYBANHANG.DTO;
using QUANLYBANHANG.DAO;

namespace QUANLYBANHANG.GUI
{
    public partial class ucDonViTinh : DevExpress.XtraEditors.XtraUserControl
    {
        public ucDonViTinh(VaiTro_ChucNang phanquyendvt)
        {
            InitializeComponent();
            Load += new EventHandler(ucDonViTinh_Load);
        }

        private void ucDonViTinh_Load(object sender, EventArgs e)
        {
            FillGridView();

            gvDonViTinh.ExpandAllGroups();
        }

        private void FillGridView()
        {
            string sql = "select * from DONVITINH";
            DataTable dvt = Execute.LayDuLieuBang(sql);
            gcDonViTinh.DataSource = dvt;
            gvDonViTinh.ExpandAllGroups();
        }



    }
}
