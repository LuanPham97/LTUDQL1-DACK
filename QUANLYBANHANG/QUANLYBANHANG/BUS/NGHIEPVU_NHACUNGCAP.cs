using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUANLYBANHANG.DAO;
using System.Data;

namespace QUANLYBANHANG.BUS
{
    class NGHIEPVU_NHACUNGCAP
    {
        XL_NhaCungCap xl_ncc = new XL_NhaCungCap();
        public DataTable LayDuLieuNCC(string sql)
        {
            return xl_ncc.LayDuLieuNCC(sql);
        }
    }
}
