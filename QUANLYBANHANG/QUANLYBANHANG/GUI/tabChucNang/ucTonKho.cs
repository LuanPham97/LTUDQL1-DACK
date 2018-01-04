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

namespace QUANLYBANHANG.GUI.tabChucNang
{
    public partial class ucTonKho : DevExpress.XtraEditors.XtraUserControl
    {
        public ucTonKho(VaiTro_ChucNang pqtk)
        {
            InitializeComponent();

            Load += UcTonKho_Load;

            gvTonKho.ShowingEditor += GvTonKho_ShowingEditor;

            //phân quyền dựa vào bảng vai trò chức năng đã được gửi qua
            if (pqtk != null)
            {
                if (pqtk.Xuat == 0)
                {
                    btnXuat.Enabled = false;
                }
            }
        }

        private void GvTonKho_ShowingEditor(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void UcTonKho_Load(object sender, EventArgs e)
        {
            FillCbKho();
            FillGridView();
        }

        private void FillCbKho()
        {
            string sql = "select TenKho, MaKho from KHOHANG";

            DataTable dt = Execute.LayDuLieuBang(sql);

            lkueKho.Properties.DataSource = dt;
            lkueKho.Properties.ValueMember = "MaKho";
            lkueKho.Properties.DisplayMember = "TenKho";
            lkueKho.ItemIndex = -1;
        }

        private void FillGridView()
        {
            string sql = "select kho.TenKho, hh.MaHangHoa, hh.TenHang, dv.TenDVTinh, hh.TonHienTai, nh.TenNhomHang, hh.ConQuanLy " +
                "from HANGHOA hh, KHOHANG kho, DONVITINH dv, NHOMHANG nh " +
                "where hh.KhoMacDinh=kho.MaKho and hh.DonVi=dv.MaDVTinh and hh.PhanLoai=nh.MaNhomHang";

            gcTonKho.DataSource = Execute.LayDuLieuBang(sql);
            gvTonKho.ExpandAllGroups();
        }
    }
}
