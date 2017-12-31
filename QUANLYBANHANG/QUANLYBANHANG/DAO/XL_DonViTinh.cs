using QUANLYBANHANG.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.DAO
{
    public class XL_DonViTinh
    {
        public DataTable LayDuLieuDonViTinh(string sql)
        {
            return Execute.LayDuLieuBang(sql);
        }

        public int ThemDVTinh(DonViTinh dv)
        {
            int cql = dv.ConQuanLy == true ? 1 : 0;

            string sql = "insert into DONVITINH " +
                "(MaDVTinh,TenDVTinh,GhiChu,ConQuanLy) " +
                string.Format("values ('{0}',N'{1}',N'{2}',{3})",
                dv.MaDVTinh, dv.TenDVTinh, dv.GhiChu, cql);

            return Execute.InsertUpdateDelete(sql);
        }

        public int CapNhatDVTinh(DonViTinh dv)
        {
            int cql = dv.ConQuanLy == true ? 1 : 0;

            string sql = "update DONVITINH set " +
                string.Format("TenDVTinh=N'{0}', GhiChu=N'{1}', ConQuanLy={2} where MaDVTinh='{3}'",
                dv.TenDVTinh, dv.GhiChu, cql, dv.MaDVTinh);

            return Execute.InsertUpdateDelete(sql);
        }

        public int XoaDVTinh(string madv)
        {
            string sql = "delete from DONVITINH where MaDVTinh='" + madv + "'";

            return Execute.InsertUpdateDelete(sql);
        }
    }
}
