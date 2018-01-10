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
using QUANLYBANHANG.BUS;

namespace QUANLYBANHANG.GUI.tabChucNang
{
    public partial class frmLapPhieuThu : Form
    {
        NGHIEPVU_PHIEUTHUTIEN nv_ptt = new NGHIEPVU_PHIEUTHUTIEN();
        NGHIEPVU_PHIEUXUAT nv_px = new NGHIEPVU_PHIEUXUAT();

        //event khi thêm thành công
        public delegate void dPhieuThu();
        public event dPhieuThu ThemThanhCong;

        public frmLapPhieuThu(PhieuThuTien ptt)
        {
            InitializeComponent();

            Load += FrmLapPhieuThu_Load;

            //button
            btnBoQua.Click += BtnBoQua_Click;
            btnLuu.Click += BtnLuu_Click;

            FillDuLieu(ptt);
        }


        public frmLapPhieuThu(PhieuThuTien ptt, int m)
        {
            InitializeComponent();

            Load += FrmLapPhieuThu_Load;

            //button
            btnBoQua.Click += BtnBoQua_Click;
            btnLuu.Visible = false;

            FillDuLieu(ptt);
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            PhieuThuTien pt = new PhieuThuTien();
            pt.MaKH = lkueKhachHang.EditValue.ToString();
            pt.MaPhieuXuat = txtChungTu.Text;
            pt.NgayLap = DateTime.Parse(deNgayLap.EditValue.ToString());
            pt.SoTien = int.Parse(ceSoTien.EditValue.ToString());
            pt.ConNo = int.Parse(ceConNo.EditValue.ToString());
            pt.SoTienTra = int.Parse(ceSoTienTra.EditValue.ToString());
            pt.LyDo = rtbLyDo.Text;
            pt.MaNV = lkueNhanVien.EditValue.ToString();

            if (pt.SoTienTra > pt.ConNo)
            {
                MessageBox.Show("Số tiền trả lớn hơn số tiền còn nợ", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            nv_ptt.ThemPhieuThu(pt);
            nv_px.CapNhatTienDaTra(pt.MaPhieuXuat, pt.SoTienTra);
            ThemThanhCong();
            MessageBox.Show("Lưu thành công!");
        }

        private void BtnBoQua_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillDuLieu(PhieuThuTien ptt)
        {
            lkueKhachHang.EditValue = ptt.MaKH;
            deNgayLap.EditValue = ptt.NgayLap;
            txtChungTu.Text = ptt.MaPhieuXuat;
            ceSoTien.EditValue = ptt.SoTien;
            ceConNo.EditValue = ptt.ConNo;
            ceSoTienTra.EditValue = ceConNo.EditValue;
            rtbLyDo.Text = ptt.LyDo;
        }

        private void FrmLapPhieuThu_Load(object sender, EventArgs e)
        {
            FillCbKH();
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

        private void FillCbKH()
        {
            string sql = "select TenKH, MaKH from KHACH_HANG";
            DataTable dt = Execute.LayDuLieuBang(sql);

            lkueKhachHang.Properties.DataSource = dt;
            lkueKhachHang.Properties.ValueMember = "MaKH";
            lkueKhachHang.Properties.DisplayMember = "TenKH";
            lkueKhachHang.ItemIndex = -1;
        }
    }
}
