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
using QUANLYBANHANG.DAO;
using System.Data.SqlClient;
using QUANLYBANHANG.DTO;
using QUANLYBANHANG.GUI.tabDanhMuc;

namespace QUANLYBANHANG.GUI
{
    public partial class frmThemSuaHangHoa : Form
    {
        NGHIEPVU_KHOHANG nv_kho = new NGHIEPVU_KHOHANG();
        NGHIEPVU_NHOMHANG nv_nhomhang = new NGHIEPVU_NHOMHANG();
        NGHIEPVU_DONVITINH nv_dvt = new NGHIEPVU_DONVITINH();
        NGHIEPVU_NHACUNGCAP nv_ncc = new NGHIEPVU_NHACUNGCAP();
        NGHIEPVU_HANGHOA nv_hh = new NGHIEPVU_HANGHOA();

        // lưu trạng thái là đang thêm đang sửa
        int Cur_State = 1;

        // sự kiện sau khi thêm sửa
        public delegate void dHangHoa();
        public event dHangHoa ThemThanhCong;
        public event dHangHoa CapNhatThanhCong;

        // dùng để thêm
        public frmThemSuaHangHoa()
        {
            InitializeComponent();

            Cur_State = 1;

            Load += new EventHandler(frmLoad_Them);
            btnDong.Click += new EventHandler(btnDong_click);
            btnLuu.Click += new EventHandler(btnLuu_click);

            this.Text = "Thêm Hàng Hóa, Dịch Vụ";

            //button lookupedit
            lkueKhoMacDinh.ButtonClick += LkueKhoMacDinh_ButtonClick;
            lkuePhanLoai.ButtonClick += LkuePhanLoai_ButtonClick;
            lkueDonVi.ButtonClick += LkueDonVi_ButtonClick;
            lkueNCC.ButtonClick += LkueNCC_ButtonClick;
        }

        private void LkueNCC_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                frmThemNhaCungCap ncc = new frmThemNhaCungCap();
                ncc.ThemThanhCong += FillCbNCC;
                ncc.ShowDialog();
            }
        }

        private void LkueDonVi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                frmThemDonViTinh dvt = new frmThemDonViTinh();
                dvt.ThemThanhCong += FillCbDonVi;
                dvt.ShowDialog();
            }
        }

        private void LkuePhanLoai_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                frmThemNhomHang nh = new frmThemNhomHang();
                nh.ThemThanhCong += FillCbPhanLoai;
                nh.ShowDialog();
            }
        }

        private void LkueKhoMacDinh_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                frmThemSuaKhoHang kho = new frmThemSuaKhoHang();
                kho.ThemThanhCong += FillCbKhoMacDinh;
                kho.ShowDialog();
            }
        }

        // dùng để sửa
        public frmThemSuaHangHoa(DTO.HangHoa hh)
        {
            InitializeComponent();

            Cur_State = 0;

            this.Text = "Cập nhật Hàng Hóa, Dịch Vụ";
            btnDong.Click += new EventHandler(btnDong_click);
            btnLuu.Click += new EventHandler(btnLuu_click);

            FillDuLieu(hh);

            //button lookupedit
            lkueKhoMacDinh.ButtonClick += LkueKhoMacDinh_ButtonClick;
            lkuePhanLoai.ButtonClick += LkuePhanLoai_ButtonClick;
            lkueDonVi.ButtonClick += LkueDonVi_ButtonClick;
            lkueNCC.ButtonClick += LkueNCC_ButtonClick;
        }

        private void FillDuLieu(DTO.HangHoa hh)
        {
            FillCbLoaiHangHoa();
            FillCbKhoMacDinh();
            FillCbPhanLoai();
            FillCbDonVi();
            FillCbNCC();

            cbLoaiHH.Text = hh.LoaiHangHoa;
            lkueKhoMacDinh.EditValue = hh.KhoMacDinh;
            lkuePhanLoai.EditValue = hh.PhanLoai;
            txtMaHang.Text = hh.MaHangHoa;
            txtMaHang.ReadOnly = true;
            txtMaVachNSX.Text = hh.MaVachNSX;
            txtTenHang.Text = hh.TenHang;
            lkueDonVi.EditValue = hh.DonVi;
            txtXuatXu.Text = hh.XuatXu;
            nmrTonKhoToiThieu.Value = hh.TonKhoToiThieu;
            nmrTonKhoHienTai.Value = hh.TonHienTai;
            lkueNCC.EditValue = hh.NhaCungCap;
            nmrGiaMua.Value = hh.GiaMua;
            nmrGiaBanLe.Value = hh.GiaBanLe;
            nmrGiaBanSi.Value = hh.GiaBanSi;
            checkBConQuanLy.Checked = hh.ConQuanLy;
        }

        private void btnLuu_click(object sender, EventArgs e)
        {
            DTO.HangHoa hh = new DTO.HangHoa()
            {
                LoaiHangHoa = cbLoaiHH.Text,
                KhoMacDinh = lkueKhoMacDinh.EditValue.ToString(),
                PhanLoai = lkuePhanLoai.EditValue.ToString(),
                MaHangHoa = txtMaHang.Text,
                MaVachNSX = txtMaVachNSX.Text,
                TenHang = txtTenHang.Text,
                DonVi = lkueDonVi.EditValue.ToString(),
                XuatXu = txtXuatXu.Text,
                TonKhoToiThieu = (int)nmrTonKhoToiThieu.Value,
                TonHienTai = (int)nmrTonKhoHienTai.Value,
                NhaCungCap = lkueNCC.EditValue.ToString(),
                GiaMua = int.Parse(nmrGiaMua.Value.ToString()),
                GiaBanLe = int.Parse(nmrGiaBanLe.Value.ToString()),
                GiaBanSi = int.Parse(nmrGiaBanSi.Value.ToString()),
                ConQuanLy = checkBConQuanLy.Checked ? true : false
            };

            if (Cur_State == 1)
            {
                int kq = nv_hh.ThemHangHoa(hh);
                if (kq == 1)
                {
                    ThemThanhCong();
                    MessageBox.Show("Thêm hàng hóa thành công !");
                }
                else
                    MessageBox.Show("Không được để trống các trường dữ liệu quan trọng");
            }

            else if (Cur_State == 0)
            {
                int kq = nv_hh.CapNhatHangHoa(hh);
                if (kq == 1)
                {
                    CapNhatThanhCong();
                    MessageBox.Show("Cập nhật hàng hóa thành công !");
                }
                else
                    MessageBox.Show("Không được để trống các trường dữ liệu quan trọng");
            }
        }

        private void btnDong_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLoad_Them(object sender, EventArgs e)
        {
            FillCbLoaiHangHoa();
            FillCbKhoMacDinh();
            FillCbPhanLoai();
            GenerateMaHH();
            FillCbDonVi();
            FillCbNCC();

            nmrTonKhoToiThieu.Value = 0;
            nmrTonKhoHienTai.Value = 0;
            nmrGiaMua.Value = 0;
            nmrGiaBanLe.Value = 0;
            nmrGiaBanSi.Value = 0;
            checkBConQuanLy.Checked = true;
        }

        private void FillCbLoaiHangHoa()
        {
            string[] LoaiHangHoa = new string[] { "Hàng Hóa", "Dịch Vụ" };
            cbLoaiHH.Items.AddRange(LoaiHangHoa);
            cbLoaiHH.SelectedIndex = 0;
        }

        private void FillCbKhoMacDinh()
        {
            string sql = "select MaKho, TenKho from KHOHANG";
            DataTable dt = nv_kho.LayDuLieuKho(sql);

            lkueKhoMacDinh.Properties.DataSource = dt;
            lkueKhoMacDinh.Properties.ValueMember = "MaKho";
            lkueKhoMacDinh.Properties.DisplayMember = "TenKho";
            lkueKhoMacDinh.ItemIndex = 0;
        }

        private void FillCbPhanLoai()
        {
            string sql = "select MaNhomHang, TenNhomHang from NHOMHANG";
            DataTable dt = nv_nhomhang.LayDuLieuNhomHang(sql);

            lkuePhanLoai.Properties.DataSource = dt;
            lkuePhanLoai.Properties.ValueMember = "MaNhomHang";
            lkuePhanLoai.Properties.DisplayMember = "TenNhomHang";
            lkuePhanLoai.ItemIndex = 0;
        }

        private void GenerateMaHH()
        {
            string mahh = Execute.GenerateMa("sp_LayMaHangHoa");

            txtMaHang.Text = mahh;
            txtMaVachNSX.Text = mahh;

            // không cho sửa mã hàng
            txtMaHang.ReadOnly = true;
        }

        private void FillCbDonVi()
        {
            string sql = "select MaDVTinh, TenDVTinh from DONVITINH";
            DataTable dt = nv_dvt.LayDuLieuDonViTinh(sql);

            lkueDonVi.Properties.DataSource = dt;
            lkueDonVi.Properties.ValueMember = "MaDVTinh";
            lkueDonVi.Properties.DisplayMember = "TenDVTinh";
            lkueDonVi.ItemIndex = 0;
        }

        private void FillCbNCC()
        {
            string sql = "select MaNCC, TenNCC from NHACUNGCAP";
            DataTable dt = nv_ncc.LayDuLieuNCC(sql);

            lkueNCC.Properties.DataSource = dt;
            lkueNCC.Properties.ValueMember = "MaNCC";
            lkueNCC.Properties.DisplayMember = "TenNCC";
            lkueNCC.ItemIndex = 0;
        }
    }
}
