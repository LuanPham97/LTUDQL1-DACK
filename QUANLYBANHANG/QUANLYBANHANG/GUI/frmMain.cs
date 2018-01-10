using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using QUANLYBANHANG.GUI;
using QUANLYBANHANG.DAO;
using QUANLYBANHANG.DTO;
using DevExpress.XtraBars.Ribbon;
using System.Collections;
using QUANLYBANHANG.GUI.tabChucNang;
using QUANLYBANHANG.GUI.tabDanhMuc;
using QUANLYBANHANG.GUI.tabHeThong;
using QUANLYBANHANG.GUI.tabChucNang.TraTien;
using System.IO;
using QUANLYBANHANG.GUI.tabTroGiup;

namespace QUANLYBANHANG
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public delegate void FormMain();
        public event FormMain KhiFormDong;
        string username;

        //danh sach cac nhat ky he thong
        List<cNhatKyHeThong> lstNhatKyFinal = new List<cNhatKyHeThong>();

        ////tạo event lưu nhật ký hệ thống
        //public delegate void NhatKyHeThong();
        //public event NhatKyHeThong ThemNhatKyHeThong;

        public frmMain(string mavt, string tendangnhap)
        {
            InitializeComponent();

            Load += FrmMain_Load;

            username = tendangnhap;

            // tab hệ thống
            btnPhanQuyen.ItemClick += BtnPhanQuyen_ItemClick;
            btnDoiMatKhau.ItemClick += BtnDoiMatKhau_ItemClick;
            btnKetThuc.ItemClick += BtnKetThuc_ItemClick;
            btnSaoLuu.ItemClick += BtnSaoLuu_ItemClick;
            btnPhucHoi.ItemClick += BtnPhucHoi_ItemClick;
            btnTonKho.ItemClick += BtnTonKho_ItemClick;
            btnNhatKy.ItemClick += BtnNhatKy_ItemClick;
            btnThongTin2.ItemClick += BtnThongTin_ItemClick;

            // tab danh mục
            btnHangHoa.ItemClick += btnHangHoa_Click;
            btnKhoHang.ItemClick += BtnKhoHang_ItemClick;
            btnKhachHang.ItemClick += BtnKhachHang_ItemClick;
            btnNCC.ItemClick += BtnNCC_ItemClick;
            btnKhuVuc.ItemClick += BtnKhuVuc_ItemClick;
            btnDonViTinh.ItemClick += BtnDonViTinh_ItemClick;
            btnNhomHang.ItemClick += BtnNhomHang_ItemClick;
            btnTyGia.ItemClick += BtnTyGia_ItemClick;
            btnBoPhan.ItemClick += BtnBoPhan_ItemClick;
            btnNhanVien.ItemClick += BtnNhanVien_ItemClick;

            // tab chức năng
            btnBanHang.ItemClick += BtnBanHang_ItemClick;
            btnMuaHang.ItemClick += BtnMuaHang_ItemClick;
            btnChuyenKho.ItemClick += BtnChuyenKho_ItemClick;
            btnBCKhoHang.ItemClick += BtnBCKhoHang_ItemClick;
            btnThuTien.ItemClick += BtnThuTien_ItemClick;
            btnTraTien.ItemClick += BtnTraTien_ItemClick;

            // tab trợ giúp
            btnThongTin.ItemClick += BtnThongTin_ItemClick;
            btnHDSD.ItemClick += BtnHDSD_ItemClick;
            btnHoTroTrucTuyen.ItemClick += BtnHoTroTrucTuyen_ItemClick;
            btnLienHe.ItemClick += BtnLienHe_ItemClick;


            PHANQUYEN(mavt);

            FormClosing += FrmMain_FormClosing;
        }

        private void BtnLienHe_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmLienHe lh = new frmLienHe();
            lh.ShowDialog();
        }

        private void BtnHoTroTrucTuyen_ItemClick(object sender, ItemClickEventArgs e)
        {
            string pathTeamViewer = "C:/Program Files (x86)/TeamViewer/TeamViewer.exe";
            if (File.Exists(pathTeamViewer))
            {
                System.Diagnostics.Process.Start(pathTeamViewer);
            }
            else
            {
                MessageBox.Show("Vui lòng Cài đặt team viewer vào đường dẫn mặc định");
                System.Diagnostics.Process.Start("https://www.teamviewer.com/en/");
            }
        }

        private void BtnHDSD_ItemClick(object sender, ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("http://perfect.com.vn/huong-dan-su-dung-phan-mem-quan-ly-ban-hang.html");
        }

        private void BtnTraTien_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnMain.Controls.Clear();

            VaiTro_ChucNang pqct = btnTraTien.Tag as VaiTro_ChucNang;

            ucTraTien traTien = new ucTraTien(pqct, username);
            traTien.ThemNhatKyHeThong += ThemNhatKy_Main;
            traTien.Dock = DockStyle.Fill;
            pnMain.Controls.Add(traTien);
        }

        private void BtnThuTien_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnMain.Controls.Clear();

            VaiTro_ChucNang pqtt = btnThuTien.Tag as VaiTro_ChucNang;

            ucThuTien tt = new ucThuTien(pqtt, username);
            tt.ThemNhatKyHeThong += ThemNhatKy_Main;
            tt.Dock = DockStyle.Fill;
            pnMain.Controls.Add(tt);
        }

        private void BtnBCKhoHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnMain.Controls.Clear();

            VaiTro_ChucNang pqbc = btnBCKhoHang.Tag as VaiTro_ChucNang;

            ucBaoCaoKhoHang bc = new ucBaoCaoKhoHang(pqbc, username);
            bc.ThemNhatKyHeThong += ThemNhatKy_Main;
            bc.Dock = DockStyle.Fill;
            pnMain.Controls.Add(bc);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            cNhatKyHeThong c = new cNhatKyHeThong();
            c.ChucNang = "Hệ Thống";
            c.HanhDong = "Đăng Nhập";
            c.MayTinh = System.Environment.MachineName;
            c.NguoiDung = username;
            c.ThoiGian = DateTime.Now;

            lstNhatKyFinal.Add(c);
        }

        private void BtnNhatKy_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnMain.Controls.Clear();

            ucNhatKyHeThong ucdiary = new ucNhatKyHeThong(lstNhatKyFinal);
            ucdiary.Dock = DockStyle.Fill;
            pnMain.Controls.Add(ucdiary);
        }

        private void BtnThongTin_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmThongTin frmtt = new frmThongTin();
            frmtt.ShowDialog();
        }

        private void BtnChuyenKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnMain.Controls.Clear();

            VaiTro_ChucNang pqck = btnChuyenKho.Tag as VaiTro_ChucNang;

            ucChuyenKho ck = new ucChuyenKho(pqck, username);
            ck.ThemNhatKyHeThong += ThemNhatKy_Main;
            ck.Dock = DockStyle.Fill;
            pnMain.Controls.Add(ck);
        }

        private void BtnTonKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnMain.Controls.Clear();

            VaiTro_ChucNang pqtk = btnTonKho.Tag as VaiTro_ChucNang;

            ucTonKho tk = new ucTonKho(pqtk, username);
            tk.ThemNhatKyHeThong += ThemNhatKy_Main;
            tk.Dock = DockStyle.Fill;
            pnMain.Controls.Add(tk);
        }

        private void BtnPhucHoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmPhucHoiDuLieu frmph = new frmPhucHoiDuLieu(username);
            frmph.ThemNhatKyHeThong += ThemNhatKy_Main;
            frmph.ShowDialog();
        }

        private void BtnSaoLuu_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmSaoLuuDuLieu frmsl = new frmSaoLuuDuLieu(username);
            frmsl.ThemNhatKyHeThong += ThemNhatKy_Main;
            frmsl.ShowDialog();
        }

        private void BtnKetThuc_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void BtnDoiMatKhau_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDoiMatKhau frmDoiMK = new frmDoiMatKhau(username);
            frmDoiMK.ThemNhatKyHeThong += ThemNhatKy_Main;
            frmDoiMK.ShowDialog();
        }

        private void BtnNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnMain.Controls.Clear();

            VaiTro_ChucNang pqnv = btnNhanVien.Tag as VaiTro_ChucNang;

            ucNhanVien nv = new ucNhanVien(pqnv, username);
            nv.ThemNhatKyHeThong += ThemNhatKy_Main;
            nv.Dock = DockStyle.Fill;
            pnMain.Controls.Add(nv);
        }

        private void BtnBoPhan_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnMain.Controls.Clear();

            VaiTro_ChucNang pqbp = btnBoPhan.Tag as VaiTro_ChucNang;

            ucBoPhan bp = new ucBoPhan(pqbp, username);
            bp.ThemNhatKyHeThong += ThemNhatKy_Main;
            bp.Dock = DockStyle.Fill;
            pnMain.Controls.Add(bp);
        }

        private void BtnTyGia_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnMain.Controls.Clear();

            VaiTro_ChucNang pqtg = btnTyGia.Tag as VaiTro_ChucNang;

            ucTyGia tg = new ucTyGia(pqtg, username);
            tg.ThemNhatKyHeThong += ThemNhatKy_Main;
            tg.Dock = DockStyle.Fill;
            pnMain.Controls.Add(tg);
        }

        private void BtnNhomHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnMain.Controls.Clear();

            VaiTro_ChucNang pqnh = btnNhomHang.Tag as VaiTro_ChucNang;

            ucNhomHang nh = new ucNhomHang(pqnh, username);
            nh.ThemNhatKyHeThong += ThemNhatKy_Main;
            nh.Dock = DockStyle.Fill;
            pnMain.Controls.Add(nh);
        }

        private void BtnDonViTinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnMain.Controls.Clear();

            VaiTro_ChucNang pqdvt = btnDonViTinh.Tag as VaiTro_ChucNang;

            ucDonViTinh dvt = new ucDonViTinh(pqdvt, username);
            dvt.ThemNhatKyHeThong += ThemNhatKy_Main;
            dvt.Dock = DockStyle.Fill;
            pnMain.Controls.Add(dvt);
        }

        private void BtnKhuVuc_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnMain.Controls.Clear();

            VaiTro_ChucNang pqkv = btnKhuVuc.Tag as VaiTro_ChucNang;

            ucKhuVuc kv = new ucKhuVuc(pqkv, username);
            kv.ThemNhatKyHeThong += ThemNhatKy_Main;
            kv.Dock = DockStyle.Fill;
            pnMain.Controls.Add(kv);
        }

        private void ThemNhatKy_Main(cNhatKyHeThong nk)
        {
            lstNhatKyFinal.Add(nk);
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            KhiFormDong();
        }

        private void BtnNCC_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnMain.Controls.Clear();

            VaiTro_ChucNang pqncc = btnNCC.Tag as VaiTro_ChucNang;

            ucNhaCungCap ncc = new ucNhaCungCap(pqncc, username);
            ncc.ThemNhatKyHeThong += ThemNhatKy_Main;
            ncc.Dock = DockStyle.Fill;
            pnMain.Controls.Add(ncc);
        }

        private void BtnKhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnMain.Controls.Clear();

            VaiTro_ChucNang phanquyenKH = btnKhachHang.Tag as VaiTro_ChucNang;

            ucKhachHang k = new ucKhachHang(phanquyenKH, username);
            k.ThemNhatKyHeThong += ThemNhatKy_Main;
            k.Dock = DockStyle.Fill;
            pnMain.Controls.Add(k);
        }

        private void BtnKhoHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnMain.Controls.Clear();

            VaiTro_ChucNang phanquyenKho = btnKhoHang.Tag as VaiTro_ChucNang;

            ucKhoHang uckh = new ucKhoHang(phanquyenKho, username);
            uckh.ThemNhatKyHeThong += ThemNhatKy_Main;
            uckh.Dock = DockStyle.Fill;
            pnMain.Controls.Add(uckh);
        }

        private void BtnMuaHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnMain.Controls.Clear();

            VaiTro_ChucNang phanquyenMH = btnMuaHang.Tag as VaiTro_ChucNang;

            ucMuaHang ucmh = new ucMuaHang(phanquyenMH, username);
            ucmh.ThemNhatKyHeThong += ThemNhatKy_Main;
            ucmh.Dock = DockStyle.Fill;
            pnMain.Controls.Add(ucmh);
        }

        private void BtnBanHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnMain.Controls.Clear();

            VaiTro_ChucNang phanquyenBH = btnBanHang.Tag as VaiTro_ChucNang;

            ucBanHang2 ucbh = new ucBanHang2(phanquyenBH, username);
            ucbh.ThemNhatKyHeThong += ThemNhatKy_Main;
            ucbh.Dock = DockStyle.Fill;
            pnMain.Controls.Add(ucbh);
        }

        private void PHANQUYEN(string mavt)
        {
            List<VaiTro_ChucNang> lstVTCN = LayListVTCN(mavt);

            ArrayList arrayRBC = rbcMain.TotalPageCategory.GetVisiblePages();
            foreach (RibbonPage page in arrayRBC)
            {
                VaiTro_ChucNang VTofPage = LayVTCN(page.Name, lstVTCN);
                if (VTofPage != null)
                {
                    page.Visible = VTofPage.TruyCap == 0 ? false : true;
                }

                foreach (RibbonPageGroup group in page.Groups)
                {
                    VaiTro_ChucNang VTofPageGroup = LayVTCN(group.Name, lstVTCN);
                    if (VTofPageGroup != null)
                    {
                        group.Visible = VTofPageGroup.TruyCap == 0 ? false : true;
                    }

                    foreach (BarItemLink link in group.ItemLinks)
                    {
                        VaiTro_ChucNang VTofButton = LayVTCN(link.Item.Name, lstVTCN);
                        if (VTofButton != null)
                        {
                            link.Item.Tag = VTofButton;
                            link.Item.Enabled = VTofButton.TruyCap == 0 ? false : true;
                        }
                    }
                }
            }

        }

        private VaiTro_ChucNang LayVTCN(string name, List<VaiTro_ChucNang> lstVTCN)
        {
            foreach (VaiTro_ChucNang vc in lstVTCN)
            {
                if (string.Compare(vc.TenTrongHeThong, name) == 0)
                {
                    return vc;
                }
            }
            return null;
        }

        private static List<VaiTro_ChucNang> LayListVTCN(string mavt)
        {
            string sql = "select vc.*, cn.TenTrongHeThong " +
                            "from VAITRO_CHUCNANG vc, CHUCNANG cn " +
                            "where vc.MaChucNang = cn.MaChucNang and vc.MaVaiTro = '" + mavt + "'";

            Provider p = new Provider();
            p.Connect();

            List<VaiTro_ChucNang> lstVTCN = new List<VaiTro_ChucNang>();

            DataTable dt = p.Select(CommandType.Text, sql);
            foreach (DataRow row in dt.Rows)
            {
                VaiTro_ChucNang vc = new VaiTro_ChucNang();
                vc.MaVaiTro = row["MaVaiTro"].ToString();
                vc.MaChucNang = int.Parse(row["MaChucNang"].ToString());
                vc.TatCa = bool.Parse(row["TatCa"].ToString()) == true ? 1 : 0;
                vc.TruyCap = bool.Parse(row["TruyCap"].ToString()) == true ? 1 : 0;
                vc.Them = bool.Parse(row["Them"].ToString()) == true ? 1 : 0;
                vc.Xoa = bool.Parse(row["Xoa"].ToString()) == true ? 1 : 0;
                vc.Sua = bool.Parse(row["Sua"].ToString()) == true ? 1 : 0;
                vc.InAn = bool.Parse(row["InAn"].ToString()) == true ? 1 : 0;
                vc.Nhap = bool.Parse(row["Nhap"].ToString()) == true ? 1 : 0;
                vc.Xuat = bool.Parse(row["Xuat"].ToString()) == true ? 1 : 0;
                vc.TenTrongHeThong = row["TenTrongHeThong"].ToString();

                lstVTCN.Add(vc);
            }

            return lstVTCN;
        }

        private void BtnPhanQuyen_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnMain.Controls.Clear();

            VaiTro_ChucNang phanquyenPQ = btnPhanQuyen.Tag as VaiTro_ChucNang;

            ucPhanQuyen ucpq = new ucPhanQuyen(phanquyenPQ, username);
            ucpq.ThemNhatKyHeThong += ThemNhatKy_Main;
            ucpq.Dock = DockStyle.Fill;
            pnMain.Controls.Add(ucpq);
        }

        private void btnHangHoa_Click(object sender, ItemClickEventArgs e)
        {
            pnMain.Controls.Clear();

            VaiTro_ChucNang phanquyenHH = btnHangHoa.Tag as VaiTro_ChucNang;

            ucHangHoa uchh = new ucHangHoa(phanquyenHH, username);
            uchh.ThemNhatKyHeThong += ThemNhatKy_Main;
            uchh.Dock = DockStyle.Fill;
            pnMain.Controls.Add(uchh);
        }
    }
}
