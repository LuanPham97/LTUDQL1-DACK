using QUANLYBANHANG.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYBANHANG.GUI.tabChucNang
{
    public partial class frmPRT : Form
    {
        public frmPRT()
        {
            InitializeComponent();
        }

        private void frmPRT_Load(object sender, EventArgs e)
        {
            string sql = "select * from HANGHOA";
            DataTable dt = Execute.LayDuLieuBang(sql);


            rptHH rpt = new rptHH();
            rpt.SetDataSource(dt);

            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
