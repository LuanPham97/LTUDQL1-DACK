using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYBANHANG.DTO;

namespace QUANLYBANHANG.GUI.tabChucNang.TraTien
{
    public partial class ucTraTien : UserControl
    {
        //tạo event lưu nhật ký hệ thống
        public delegate void NhatKyHeThong(cNhatKyHeThong diary);
        public event NhatKyHeThong ThemNhatKyHeThong;

        // tên chức năng hiện tại
        string TenChucNang = "Trả Tiền";

        VaiTro_ChucNang vtcn;
        string user;

        public ucTraTien(VaiTro_ChucNang pqtt, string un)
        {
            InitializeComponent();

            vtcn = pqtt;
            user = un;

            Load += UcTraTien_Load;

            btnDSPChi.Click += BtnDSPChi_Click;
            btnDSPCongNo.Click += BtnDSPCongNo_Click;
        }

        private void BtnDSPCongNo_Click(object sender, EventArgs e)
        {
            GoiDSCongNo();
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

        private void NhatKyXuat()
        {
            AddNhatKy("Xuất");
        }

        private void Dscn_KhoiDong()
        {
            AddNhatKy("Xem");
        }

        private void NhatKyThem()
        {
            AddNhatKy("Lập phiếu và Lưu");
        }

        private void BtnDSPChi_Click(object sender, EventArgs e)
        {
            GoiDSPChi();
        }

        private void GoiDSPChi()
        {
            splitContainer1.Panel2.Controls.Clear();
            ucBangKePhieuChi bkpc = new ucBangKePhieuChi();
            bkpc.Dock = DockStyle.Fill;
            bkpc.Xuat += NhatKyXuat;
            splitContainer1.Panel2.Controls.Add(bkpc);
        }

        private void UcTraTien_Load(object sender, EventArgs e)
        {
            GoiDSCongNo();
        }

        private void GoiDSCongNo()
        {
            splitContainer1.Panel2.Controls.Clear();
            ucDSCongNoTra dscn = new ucDSCongNoTra(vtcn, user);
            dscn.Dock = DockStyle.Fill;
            dscn.KhoiDong += Dscn_KhoiDong;
            dscn.Luu += NhatKyThem;
            dscn.Xuat += NhatKyXuat;
            splitContainer1.Panel2.Controls.Add(dscn);
        }
    }
}
