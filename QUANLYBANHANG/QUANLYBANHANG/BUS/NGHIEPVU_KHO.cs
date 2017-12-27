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
    public class NGHIEPVU_KHOHANG
    {
        XL_KhoHang xl_kho = new XL_KhoHang();
        public DataTable LayDuLieuKho(string sql)
        {
            return xl_kho.LayDuLieuKho(sql);
        }

        public int ThemKhoHang(KhoHang kho)
        {
            return xl_kho.ThemKhoHang(kho);
        }
    }
}
