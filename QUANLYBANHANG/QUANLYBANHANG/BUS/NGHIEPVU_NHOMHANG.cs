using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUANLYBANHANG.DAO;
using System.Data;
using QUANLYBANHANG.DTO;

namespace QUANLYBANHANG.BUS
{
    public class NGHIEPVU_NHOMHANG
    {
        XL_NhomHang xl_nhomhang = new XL_NhomHang();
        public DataTable LayDuLieuNhomHang(string sql)
        {
            return xl_nhomhang.LayDuLieuNhomHang(sql);
        }

        public int ThemNhomHang(NhomHang nh)
        {
            return xl_nhomhang.ThemNhomHang(nh);
        }

        public int CapNhatNhomHang(NhomHang nh)
        {
            return xl_nhomhang.CapNhatNhomHang(nh);
        }

        public int XoaNhomHang(string manh)
        {
            return xl_nhomhang.XoaNhomHang(manh);
        }
    }
}
