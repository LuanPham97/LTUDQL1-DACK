using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.DAO
{
    public class XL_NhanVien
    {
        public DataTable LayDuLieuNV(string sql)
        {
            return Execute.LayDuLieuBang(sql);
        }
    }
}
