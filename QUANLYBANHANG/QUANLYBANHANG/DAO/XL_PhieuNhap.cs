using QUANLYBANHANG.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.DAO
{
    public class XL_PhieuNhap
    {
        public int ThemPhieuNhap(PhieuNhap pn)
        {
            string sql = "insert into PHIEU_NHAP(MaPhieu,MaNCC,NgayLap,GhiChu,SoHoaDonVAT,MaNVLap" +
                ",SoPhieuNhapTay,MaKhoNhap,DieuKhoanThanhToan,HinhThucThanhToan,HanThanhToan,DaTra,TongTien) " +
                string.Format("values ('{0}','{1}','{2}',N'{3}','{4}','{5}','{6}','{7}',N'{8}',N'{9}','{10}',{11},{12})",
                pn.MaPhieu, pn.MaNCC, pn.NgayLap, pn.GhiChu, pn.SoHoaDonVAT, pn.MaNVLap, pn.SoPhieuNhapTay,
                pn.MaKhoNhap, pn.DieuKhoanThanhToan, pn.HinhThucThanhToan, pn.HanThanhToan, pn.DaTra, pn.TongTien);

            return Execute.InsertUpdateDelete(sql);
        }

        public int CapNhatTienDaTra(string mapn, int sotien)
        {
            string sql = string.Format("update PHIEU_NHAP set DaTra +={0} where MaPhieu='{1}'",
                sotien, mapn);

            return Execute.InsertUpdateDelete(sql);
        }
    }
}
