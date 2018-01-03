using QUANLYBANHANG.DTO;
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

        public int ThemNhanVien(NhanVien nv)
        {
            string bophan = nv.BoPhan != null ? string.Format("'{0}'", nv.BoPhan) : "null";
            string nql = nv.NguoiQuanLy != null ? string.Format("'{0}'", nv.NguoiQuanLy) : "null";
            int cql = nv.ConQuanLy == true ? 1 : 0;

            string sql = "insert into NHANVIEN(MaNhanVien,TenNhanVien,ChucVu,DiaChi," +
                "Email,DienThoai,DiDong,BoPhan," +
                "NguoiQuanLy,ConQuanLy) " +
                string.Format("values ('{0}',N'{1}',N'{2}',N'{3}',",
                nv.MaNhanVien, nv.TenNhanVien, nv.ChucVu, nv.DiaChi) +
                string.Format("'{0}','{1}','{2}',{3},",
                nv.Email, nv.DienThoai, nv.DiDong, bophan) +
                string.Format("{0},{1})",
                nql, cql);

            return Execute.InsertUpdateDelete(sql);
        }

        public int CapNhatNhanVien(NhanVien nv)
        {
            int cql = nv.ConQuanLy == true ? 1 : 0;

            string sql = "update NHANVIEN set " +
                string.Format("TenNhanVien=N'{0}',ChucVu=N'{1}',DiaChi=N'{2}',Email='{3}',",
                nv.TenNhanVien, nv.ChucVu, nv.DiaChi, nv.Email) +
                string.Format("DienThoai='{0}',DiDong='{1}',BoPhan='{2}',NguoiQuanLy='{3}',",
                nv.DienThoai, nv.DiDong, nv.BoPhan, nv.NguoiQuanLy) +
                string.Format("ConQuanLy={0} where MaNhanVien='{1}'",
                cql, nv.MaNhanVien);

            return Execute.InsertUpdateDelete(sql);
        }

        public int XoaNhanVien(string manv)
        {
            string sql = "delete from NHANVIEN where MaNhanVien='" + manv + "'";

            return Execute.InsertUpdateDelete(sql);
        }
    }
}
