using QUANLYBANHANG.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.DAO
{
    public class XL_PhieuChuyenKho
    {
        public int ThemPhieuChuyenKho(PhieuChuyenKho pc)
        {
            string sql = "insert into PHIEUCHUYENKHO(MaPhieuChuyen,KhoXuatHang,KhoNhanHang,NVChuyen," +
                "NVNhan,PhieuChuyenTay,GhiChu,NgayLap) " +
                string.Format("values ('{0}','{1}','{2}','{3}',",
                pc.MaPhieuChuyen, pc.KhoXuatHang, pc.KhoNhanHang, pc.NVChuyen) +
                string.Format("'{0}','{1}',N'{2}','{3}')",
                pc.NVNhan, pc.PhieuChuyenTay, pc.GhiChu, pc.NgayLap);

            return Execute.InsertUpdateDelete(sql);
        }
    }
}
