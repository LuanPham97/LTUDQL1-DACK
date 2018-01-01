﻿using QUANLYBANHANG.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.DAO
{
 public class XL_BoPhan
    {
        public int ThemBoPhan(BoPhan bp)
        {
            int cql = bp.ConQuanLy == true ? 1 : 0;

            string sql = "insert into BOPHAN " +
                "(MaBoPhan,TenBoPhan,GhiChu,ConQuanLy) " +
                string.Format("values ('{0}',N'{1}',N'{2}',{3})",
                bp.MaBoPhan, bp.TenBoPhan, bp.GhiChu, cql);

            return Execute.InsertUpdateDelete(sql);
        }

        public int CapNhatBoPhan(BoPhan bp)
        {
            int cql = bp.ConQuanLy == true ? 1 : 0;

            string sql = "update BOPHAN set " +
                string.Format("TenBoPhan=N'{0}',GhiChu=N'{1}',ConQuanLy={2} where MaBoPhan='{3}'",
                bp.TenBoPhan, bp.GhiChu, cql, bp.MaBoPhan);

            return Execute.InsertUpdateDelete(sql);
        }

        public int XoaBoPhan(string mabp)
        {
            string sql = "delete from BOPHAN where MaBoPhan='" + mabp + "'";

            return Execute.InsertUpdateDelete(sql);
        }
    }
}