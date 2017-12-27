﻿using System;
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
using QUANLYBANHANG.GUI.HeThong;

namespace QUANLYBANHANG
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain(string mavt)
        {
            InitializeComponent();

            btnHangHoa.ItemClick += btnHangHoa_Click;
            btnPhanQuyen.ItemClick += BtnPhanQuyen_ItemClick;
            btnBanHang.ItemClick += BtnBanHang_ItemClick;
            btnMuaHang.ItemClick += BtnMuaHang_ItemClick;
            btnKhoHang.ItemClick += BtnKhoHang_ItemClick;

            PHANQUYEN(mavt);
        }

        private void BtnKhoHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnMain.Controls.Clear();

            VaiTro_ChucNang phanquyenKH = btnKhoHang.Tag as VaiTro_ChucNang;

            ucKhoHang uckh = new ucKhoHang(phanquyenKH);
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
