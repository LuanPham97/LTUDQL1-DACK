using QUANLYBANHANG.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.DAO
{
    public class XL_PhieuChiTien
    {
        public int ThemPhieuChi(PhieuChiTien pc)
        {
            string sql = "insert into PHIEUCHITIEN(MaNCC, MaPhieuXuat,NgayLap,SoTien,ConNo,SoTienTra,MaNV,LyDo) " +
                string.Format("values ('{0}','{1}','{2}',{3},{4},{5},'{6}',N'{7}')",
                pc.MaNCC, pc.MaPhieuXuat, pc.NgayLap, pc.SoTien, pc.ConNo, pc.SoTienTra, pc.MaNV, pc.LyDo);

            return Execute.InsertUpdateDelete(sql);
        }
    }
}
