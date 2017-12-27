using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QUANLYBANHANG.DTO;

namespace QUANLYBANHANG.DAO
{
    public class XL_KhoHang
    {
        public DataTable LayDuLieuKho(string sql)
        {
            return Execute.LayDuLieuBang(sql);
        }

        public int ThemKhoHang(KhoHang kho)
        {
            int cql = kho.ConQuanLy == true ? 1 : 0;

            string sql = "insert into KHOHANG(MaKho,KyHieu,TenKho,NguoiQuanLy,NguoiLienHe," +
                "DiaChi,DienThoai,Fax,Email,DienGiai,ConQuanLy) " +
                string.Format("values ('{0}','{1}',N'{2}',N'{3}',N'{4}',N'{5}','{6}','{7}','{8}',N'{9}',{10})",
                kho.MaKho, kho.KyHieu, kho.TenKho, kho.NguoiQuanLy, kho.NguoiLienHe, kho.DiaChi, kho.DienThoai,
                kho.Fax, kho.Email, kho.DienGiai, cql);

            return Execute.InsertUpdateDelete(sql);
        }
    }
}
