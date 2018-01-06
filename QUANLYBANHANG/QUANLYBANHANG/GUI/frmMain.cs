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

namespace QUANLYBANHANG
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public delegate void FormMain();
        public event FormMain KhiFormDong;
        string username;

        public frmMain(string mavt, string tendangnhap)
        {
            InitializeComponent();

            username = tendangnhap;

            // tab hệ thống
            btnPhanQuyen.ItemClick += BtnPhanQuyen_ItemClick;
            btnDoiMatKhau.ItemClick += BtnDoiMatKhau_ItemClick;
            btnKetThuc.ItemClick += BtnKetThuc_ItemClick;
            btnSaoLuu.ItemClick += BtnSaoLuu_ItemClick;
            btnPhucHoi.ItemClick += BtnPhucHoi_ItemClick;
            btnTonKho.ItemClick += BtnTonKho_ItemClick;

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
            

            PHANQUYEN(mavt);

            FormClosing += FrmMain_FormClosing;
        }

        private void BtnChuyenKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnMain.Controls.Clear();

            VaiTro_ChucNang pqck = btnChuyenKho.Tag as VaiTro_ChucNang;

            ucChuyenKho ck = new ucChuyenKho(pqck);
            ck.Dock = DockStyle.Fill;
            pnMain.Controls.Add(ck);
        }

        private void BtnTonKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnMain.Controls.Clear();

            VaiTro_ChucNang pqtk = btnTonKho.Tag as VaiTro_ChucNang;

            ucTonKho tk = new ucTonKho(pqtk);
            tk.Dock = DockStyle.Fill;
            pnMain.Controls.Add(tk);
        }

        private void BtnPhucHoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmPhucHoiDuLieu frmph = new frmPhucHoiDuLieu();
            frmph.ShowDialog();
        }

        private void BtnSaoLuu_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmSaoLuuDuLieu frmsl = new frmSaoLuuDuLieu();
            frmsl.ShowDialog();
        }

        private void BtnKetThuc_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void BtnDoiMatKhau_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDoiMatKhau frmDoiMK = new frmDoiMatKhau(username);
            frmDoiMK.ShowDialog();
        }

        private void BtnNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnMain.Controls.Clear();

            VaiTro_ChucNang pqnv = btnNhanVien.Tag as VaiTro_ChucNang;

            ucNhanVien nv = new ucNhanVien(pqnv);
            nv.Dock = DockStyle.Fill;
            pnMain.Controls.Add(nv);
        }

        private void BtnBoPhan_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnMain.Controls.Clear();

            VaiTro_ChucNang pqbp = btnBoPhan.Tag as VaiTro_ChucNang;

            ucBoPhan bp = new ucBoPhan(pqbp);
            bp.Dock = DockStyle.Fill;
            pnMain.Controls.Add(bp);
        }

        private void BtnTyGia_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnMain.Controls.Clear();

            VaiTro_ChucNang pqtg = btnTyGia.Tag as VaiTro_ChucNang;

            ucTyGia tg = new ucTyGia(pqtg);
            tg.Dock = DockStyle.Fill;
            pnMain.Controls.Add(tg);
        }

        private void BtnNhomHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnMain.Controls.Clear();

            VaiTro_ChucNang pqnh = btnNhomHang.Tag as VaiTro_ChucNang;

            ucNhomHang nh = new ucNhomHang(pqnh);
            nh.Dock = DockStyle.Fill;
            pnMain.Controls.Add(nh);
        }

        private void BtnDonViTinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnMain.Controls.Clear();

            VaiTro_ChucNang pqdvt = btnDonViTinh.Tag as VaiTro_ChucNang;

            ucDonViTinh dvt = new ucDonViTinh(pqdvt);
            dvt.Dock = DockStyle.Fill;
            pnMain.Controls.Add(dvt);
        }

        private void BtnKhuVuc_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnMain.Controls.Clear();

            VaiTro_ChucNang pqkv = btnKhuVuc.Tag as VaiTro_ChucNang;

            ucKhuVuc kv = new ucKhuVuc(pqkv);
            kv.Dock = DockStyle.Fill;
            pnMain.Controls.Add(kv);
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            KhiFormDong();
        }

        private void BtnNCC_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnMain.Controls.Clear();

            VaiTro_ChucNang pqncc = btnNCC.Tag as VaiTro_ChucNang;

            ucNhaCungCap ncc = new ucNhaCungCap(pqncc);
            ncc.Dock = DockStyle.Fill;
            pnMain.Controls.Add(ncc);
        }

        private void BtnKhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnMain.Controls.Clear();

            VaiTro_ChucNang phanquyenKH = btnKhachHang.Tag as VaiTro_ChucNang;

            ucKhachHang k = new ucKhachHang(phanquyenKH);
            k.Dock = DockStyle.Fill;
            pnMain.Controls.Add(k);
        }

        private void BtnKhoHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnMain.Controls.Clear();

            VaiTro_ChucNang phanquyenKho = btnKhoHang.Tag as VaiTro_ChucNang;

            ucKhoHang uckh = new ucKhoHang(phanquyenKho);
            uckh.Dock = DockStyle.Fill;
            pnMain.Controls.Add(uckh);
        }

        private void BtnMuaHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnMain.Controls.Clear();

            VaiTro_ChucNang phanquyenMH = btnMuaHang.Tag as VaiTro_ChucNang;

            ucMuaHang ucmh = new ucMuaHang(phanquyenMH);
            ucmh.Dock = DockStyle.Fill;
            pnMain.Controls.Add(ucmh);
        }

        private void BtnBanHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnMain.Controls.Clear();

            VaiTro_ChucNang phanquyenBH = btnBanHang.Tag as VaiTro_ChucNang;

            ucBanHang2 ucbh = new ucBanHang2(phanquyenBH);
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
            foreach(VaiTro_ChucNang vc in lstVTCN)
            {
                if(string.Compare(vc.TenTrongHeThong, name) == 0)
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

            ucPhanQuyen ucpq = new ucPhanQuyen(phanquyenPQ);
            ucpq.Dock = DockStyle.Fill;
            pnMain.Controls.Add(ucpq);
        }

        private void btnHangHoa_Click(object sender, ItemClickEventArgs e)
        {
            pnMain.Controls.Clear();

            VaiTro_ChucNang phanquyenHH = btnHangHoa.Tag as VaiTro_ChucNang;

            ucHangHoa uchh = new ucHangHoa(phanquyenHH);
            uchh.Dock = DockStyle.Fill;
            pnMain.Controls.Add(uchh);
        }
    }
}
