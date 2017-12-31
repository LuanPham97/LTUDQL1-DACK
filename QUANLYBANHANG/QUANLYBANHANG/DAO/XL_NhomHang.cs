using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QUANLYBANHANG.DTO;

namespace QUANLYBANHANG.DAO
{
    public class XL_NhomHang
    {
        public DataTable LayDuLieuNhomHang(string sql)
        {
            return Execute.LayDuLieuBang(sql);
        }

        public int ThemNhomHang(NhomHang nh)
        {
            int cql = nh.ConQuanLy == true ? 1 : 0;

            string sql = "insert into NHOMHANG " +
                "(MaNhomHang,TenNhomHang,GhiChu,ConQuanLy) " +
                string.Format("values ('{0}',N'{1}',N'{2}',{3})",
                nh.MaNhomHang, nh.TenNhomHang, nh.GhiChu, cql);

            return Execute.InsertUpdateDelete(sql);
        }

        public int CapNhatNhomHang(NhomHang nh)
        {
            int cql = nh.ConQuanLy == true ? 1 : 0;

            string sql = "update NHOMHANG set " +
                string.Format("TenNhomHang=N'{0}',GhiChu=N'{1}',ConQuanLy={2} where MaNhomHang='{3}'",
                nh.TenNhomHang, nh.GhiChu, cql, nh.MaNhomHang);

            return Execute.InsertUpdateDelete(sql);
        }

        public int XoaNhomHang(string manh)
        {
            string sql = "delete from NHOMHANG where MaNhomHang='" + manh + "'";

            return Execute.InsertUpdateDelete(sql);
        }
    }
}