using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QUANLYBANHANG.DAO
{
    public class XL_Kho
    {
        public DataTable LayDuLieuKho(string sql)
        {
            return Execute.LayDuLieuBang(sql);
        }
    }
}
