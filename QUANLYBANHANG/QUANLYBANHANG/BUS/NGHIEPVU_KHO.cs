using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUANLYBANHANG.DAO;
using System.Data;

namespace QUANLYBANHANG.BUS
{
    public class NGHIEPVU_KHO
    {
        XL_Kho xl_kho = new XL_Kho();
        public DataTable LayDuLieuKho(string sql)
        {
            return xl_kho.LayDuLieuKho(sql);
        }
    }
}
