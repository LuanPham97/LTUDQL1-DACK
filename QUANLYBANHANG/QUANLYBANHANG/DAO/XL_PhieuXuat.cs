using QUANLYBANHANG.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.DAO
{
    public class XL_PhieuXuat
    {
        public int ThemPhieuXuat(PhieuXuat px)
        {
            string sql = "insert into PHIEU_XUAT(MaPhieu, MaKH, NgayLap, GhiChu, SoHoaDonVAT, " +
                "MaNVLap, SoPhieuNhapTay, MaKhoXuat, DieuKhoanThanhToan, " +
                "HinhThucThanhToan, HanThanhToan, NgayGiao) " +
                string.Format("values ('{0}','{1}','{2}',N'{3}','{4}','{5}','{6}','{7}',N'{8}',N'{9}','{10}','{11}')",
                px.MaPhieu, px.MaKH, px.NgayLap, px.GhiChu, px.SoHoaDonVAT, px.MaNVLap, px.SoPhieuNhapTay,
                px.MaKhoXuat, px.DKTT, px.HTTT, px.HanThanhToan, px.NgayGiao);

            return Execute.InsertUpdateDelete(sql);
        }
    }
}
