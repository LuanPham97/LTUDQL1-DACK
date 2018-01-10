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

namespace QUANLYBANHANG.GUI.tabChucNang
{
    public partial class ucThuTien : DevExpress.XtraEditors.XtraUserControl
    {
        //tạo event lưu nhật ký hệ thống
        public delegate void NhatKyHeThong(cNhatKyHeThong diary);
        public event NhatKyHeThong ThemNhatKyHeThong;

        // tên chức năng hiện tại
        string TenChucNang = "Thu Tiền";

        VaiTro_ChucNang vtcn;
        string user;

        public ucThuTien(VaiTro_ChucNang pqtt, string un)
        {
            InitializeComponent();

            vtcn = pqtt;
            user = un;

            Load += UcThuTien_Load;

            btnDSPThu.Click += BtnDSPThu_Click;
            btnDSPCongNo.Click += BtnDSPCongNo_Click;
        }

        private void BtnDSPCongNo_Click(object sender, EventArgs e)
        {
            GoiDSCongNo();
        }

        private void UcThuTien_Load(object sender, EventArgs e)
        {
            GoiDSCongNo();
        }

        private void GoiDSCongNo()
        {
            splitContainer1.Panel2.Controls.Clear();
            ucDSCongNo dscn = new ucDSCongNo(vtcn, user);
            dscn.Dock = DockStyle.Fill;
            dscn.KhoiDong += Dscn_KhoiDong;
            dscn.Luu += NhatKyThem;
            dscn.Xuat += NhatKyXuat;
            splitContainer1.Panel2.Controls.Add(dscn);
        }

        private void Dscn_KhoiDong()
        {
            AddNhatKy("Xem");
        }

        private void AddNhatKy(string hanhDong)
        {
            cNhatKyHeThong nk = new cNhatKyHeThong();
            nk.NguoiDung = user;
            nk.MayTinh = System.Environment.MachineName;
            nk.ThoiGian = DateTime.Now;
            nk.ChucNang = TenChucNang;
            nk.HanhDong = hanhDong;

            ThemNhatKyHeThong(nk);
        }

        private void NhatKyThem()
        {
            AddNhatKy("Lập phiếu và Lưu");
        }

        private void BtnDSPThu_Click(object sender, EventArgs e)
        {
            GoiDSPThu();
        }

        private void GoiDSPThu()
        {
            splitContainer1.Panel2.Controls.Clear();
            ucBangKeThuTien bktt = new ucBangKeThuTien();
            bktt.Dock = DockStyle.Fill;
            bktt.Xuat += NhatKyXuat;
            splitContainer1.Panel2.Controls.Add(bktt);
        }

        private void NhatKyXuat()
        {
            AddNhatKy("Xuất");
        }
    }
}
