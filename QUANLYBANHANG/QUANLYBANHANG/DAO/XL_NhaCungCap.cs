using QUANLYBANHANG.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.DAO
{
    public class XL_NhaCungCap
    {
        public DataTable LayDuLieuNCC(string sql)
        {
            return Execute.LayDuLieuBang(sql);
        }

        public int ThemNCC(NhaCC ncc)
        {
            int cql = ncc.ConQuanLy == true ? 1 : 0;

            string sql = "insert into NHACUNGCAP(MaNCC,KhuVuc,TenNCC,DiaChi," +
                "MaSoThue,Fax,DienThoai,Mobile," +
                "Email,Website,TaiKhoan,NganHang," +
                "GioiHanNo,NoHienTai,ChietKhau,NguoiLienHe," +
                "ChucVu,ConQuanLy) " +
                string.Format("values ('{0}','{1}',N'{2}',N'{3}',",
                ncc.MaNCC, ncc.KhuVuc, ncc.TenNCC, ncc.DiaChi) +
                string.Format("'{0}','{1}','{2}','{3}',",
                ncc.MaSoThue, ncc.Fax, ncc.DienThoai, ncc.Mobile) +
                string.Format("'{0}','{1}','{2}',N'{3}',",
                ncc.Email, ncc.Website, ncc.TaiKhoan, ncc.NganHang) +
                string.Format("{0},{1},{2},N'{3}',",
                ncc.GioiHanNo, ncc.NoHienTai, ncc.ChietKhau, ncc.NguoiLienHe) +
                string.Format("N'{0}',{1})", ncc.ChucVu, cql);

            return Execute.InsertUpdateDelete(sql);
        }

        public int CapNhatNCC(NhaCC ncc)
        {
            int cql = ncc.ConQuanLy == true ? 1 : 0;

            string sql = "update NHACUNGCAP set " +
                string.Format("KhuVuc='{0}',TenNCC=N'{1}',DiaChi=N'{2}',MaSoThue='{3}',",
                ncc.KhuVuc, ncc.TenNCC, ncc.DiaChi, ncc.MaSoThue) +
                string.Format("Fax='{0}',DienThoai='{1}',Mobile='{2}',Email='{3}',",
                ncc.Fax, ncc.DienThoai, ncc.Mobile, ncc.Email) +
                string.Format("Website='{0}',TaiKhoan='{1}',NganHang=N'{2}',GioiHanNo={3},",
                ncc.Website, ncc.TaiKhoan, ncc.NganHang, ncc.GioiHanNo) +
                string.Format("NoHienTai={0},ChietKhau={1},NguoiLienHe=N'{2}',ChucVu=N'{3}',",
                ncc.NoHienTai, ncc.ChietKhau, ncc.NguoiLienHe, ncc.ChucVu) +
                string.Format("ConQuanLy={0} where MaNCC='{1}'",
                cql, ncc.MaNCC);

            return Execute.InsertUpdateDelete(sql);
        }

        public int XoaNCC(string mancc)
        {
            string sql = "delete from NHACUNGCAP where MaNCC='" + mancc + "'";

            return Execute.InsertUpdateDelete(sql);
        }
    }
}
