using QUANLYBANHANG.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.DAO
{
    public class XL_PhieuThuTien
    {
        public int ThemPhieuThu(PhieuThuTien pt)
        {
            string sql = "insert into PHIEUTHUTIEN(MaKH, MaPhieuXuat,NgayLap,SoTien,ConNo,SoTienTra,MaNV,LyDo) " +
                string.Format("values ('{0}','{1}','{2}',{3},{4},{5},'{6}',N'{7}')",
                pt.MaKH, pt.MaPhieuXuat, pt.NgayLap, pt.SoTien, pt.ConNo, pt.SoTienTra, pt.MaNV, pt.LyDo);

            return Execute.InsertUpdateDelete(sql);
        }
    }
}
