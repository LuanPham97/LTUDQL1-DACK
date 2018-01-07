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
using System.IO;
using System.Drawing;
using System.Configuration;

namespace QUANLYBANHANG.GUI.tabChucNang
{
    public partial class ucNhatKyHeThong : DevExpress.XtraEditors.XtraUserControl
    {
        List<cNhatKyHeThong> lstDiary;

        public ucNhatKyHeThong(List<cNhatKyHeThong> lstnk)
        {
            InitializeComponent();

            lstDiary = lstnk;

            Load += UcNhatKyHeThong_Load;
        }


        private void UcNhatKyHeThong_Load(object sender, EventArgs e)
        {
            FillGridView(lstDiary);
        }

        private void FillGridView(List<cNhatKyHeThong> lstDiary)
        {
            foreach (cNhatKyHeThong c in lstDiary)
            {
                string[] row = new string[] { c.NguoiDung, c.MayTinh, c.ThoiGian.ToString(), c.ChucNang, c.HanhDong };
                gvNhatKy.Rows.Add(row);
            }
        }
    }
}
