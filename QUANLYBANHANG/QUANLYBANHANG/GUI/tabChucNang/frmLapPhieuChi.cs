using QUANLYBANHANG.BUS;
using QUANLYBANHANG.DAO;
using QUANLYBANHANG.DTO;
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
    public partial class frmLapPhieuChi : Form
    {
        NGHIEPVU_PHIEUCHITIEN nv_pct = new NGHIEPVU_PHIEUCHITIEN();
        NGHIEPVU_PHIEUNHAP nv_pn = new NGHIEPVU_PHIEUNHAP();

        //event khi thêm thành công
        public delegate void dPhieuChi();
        public event dPhieuChi ThemThanhCong;
        public frmLapPhieuChi(PhieuChiTien pct)
        {
            InitializeComponent();

            Load += FrmLapPhieuChi_Load;

            //button
            btnBoQua.Click += BtnBoQua_Click;
            btnLuu.Click += BtnLuu_Click;

            FillDuLieu(pct);
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            PhieuChiTien pc = new PhieuChiTien();
            pc.MaNCC = lkueNCC.EditValue.ToString();
            pc.MaPhieuXuat = txtChungTu.Text;
            pc.NgayLap = DateTime.Parse(deNgayLap.EditValue.ToString());
            pc.SoTien = int.Parse(ceSoTien.EditValue.ToString());
            pc.ConNo = int.Parse(ceConNo.EditValue.ToString());
            pc.SoTienTra = int.Parse(ceSoTienTra.EditValue.ToString());
            pc.LyDo = rtbLyDo.Text;
            pc.MaNV = lkueNhanVien.EditValue.ToString();

            if (pc.SoTienTra > pc.ConNo)
            {
                MessageBox.Show("Số tiền trả lớn hơn số tiền còn nợ", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            nv_pct.ThemPhieuChi(pc);
            nv_pn.CapNhatTienDaTra(pc.MaPhieuXuat, pc.SoTienTra);
            ThemThanhCong();
            MessageBox.Show("Lưu thành công!");
        }

        private void FillDuLieu(PhieuChiTien pct)
        {
            lkueNCC.EditValue = pct.MaNCC;
            deNgayLap.EditValue = pct.NgayLap;
            txtChungTu.Text = pct.MaPhieuXuat;
            ceSoTien.EditValue = pct.SoTien;
            ceConNo.EditValue = pct.ConNo;
            ceSoTienTra.EditValue = ceConNo.EditValue;
            rtbLyDo.Text = pct.LyDo;
        }

        private void BtnBoQua_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLapPhieuChi_Load(object sender, EventArgs e)
        {
            FillCbNCC();
            FillCbNV();
        }

        private void FillCbNV()
        {
            string sql = "select TenNhanVien, MaNhanVien from NHANVIEN";
            DataTable dt = Execute.LayDuLieuBang(sql);

            lkueNhanVien.Properties.DataSource = dt;
            lkueNhanVien.Properties.ValueMember = "MaNhanVien";
            lkueNhanVien.Properties.DisplayMember = "TenNhanVien";
            lkueNhanVien.ItemIndex = 0;
        }

        private void FillCbNCC()
        {
            string sql = "select TenNCC, MaNCC from NHACUNGCAP";
            DataTable dt = Execute.LayDuLieuBang(sql);

            lkueNCC.Properties.DataSource = dt;
            lkueNCC.Properties.ValueMember = "MaNCC";
            lkueNCC.Properties.DisplayMember = "TenNCC";
            lkueNCC.ItemIndex = -1;
        }
    }
}
