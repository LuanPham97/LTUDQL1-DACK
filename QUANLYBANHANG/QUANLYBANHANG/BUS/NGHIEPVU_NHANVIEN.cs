using QUANLYBANHANG.DAO;
using QUANLYBANHANG.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.BUS
{
    public class NGHIEPVU_NHANVIEN
    {
        XL_NhanVien xl_nv = new XL_NhanVien();
        public DataTable LayDuLieuNV(string sql)
        {
            return xl_nv.LayDuLieuNV(sql);
        }

        public int ThemNhanVien(NhanVien nv)
        {
            return xl_nv.ThemNhanVien(nv);
        }

        public int CapNhatNhanVien(NhanVien nv)
        {
            return xl_nv.CapNhatNhanVien(nv);
        }

        public int XoaNhanVien(string manv)
        {
            return xl_nv.XoaNhanVien(manv);
        }
    }
}
