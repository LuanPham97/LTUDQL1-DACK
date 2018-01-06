using QUANLYBANHANG.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.DAO
{
    public class XL_CT_PhieuNhap
    {
        public int ThemCTPhieuNhap(CT_PhieuNhap ctpn)
        {
            string sql = "insert into CT_PHIEU_NHAP(MaPhieuNhap, MaHang, SoLuong, DonGia, GhiChu, ThanhTien) " +
                string.Format("values ('{0}','{1}',{2},{3}, N'{4}', {5})",
                ctpn.MaPhieuNhap, ctpn.MaHang, ctpn.SoLuong, ctpn.DonGia, ctpn.GhiChu, ctpn.ThanhTien);

            return Execute.InsertUpdateDelete(sql);
        }
    }
}
