using QUANLYBANHANG.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.DAO
{
    public class XL_KhuVuc
    {
        public int ThemKhuVuc(KhuVuc kv)
        {
            int cql = kv.ConQuanLy == true ? 1 : 0;

            string sql = "insert into KHUVUC(MaKhuVuc,TenKhuVuc,GhiChu,ConQuanLy) " +
                string.Format("values ('{0}',N'{1}',N'{2}',{3})", kv.MaKhuVuc, kv.TenKhuVuc, kv.GhiChu, cql);

            return Execute.InsertUpdateDelete(sql);
        }

        public int CapNhatKhuVuc(KhuVuc kv)
        {
            int cql = kv.ConQuanLy == true ? 1 : 0;

            string sql = "update KHUVUC set " +
                string.Format("TenKhuVuc=N'{0}', GhiChu=N'{1}', ConQuanLy={2}  where MaKhuVuc='{3}'",
                kv.TenKhuVuc, kv.GhiChu, cql, kv.MaKhuVuc);

            return Execute.InsertUpdateDelete(sql);
        }

        public int XoaKhuVuc(string makv)
        {
            string sql = "delete from KHUVUC where MaKhuVuc='" + makv + "'";

            return Execute.InsertUpdateDelete(sql);
        }
    }
}
