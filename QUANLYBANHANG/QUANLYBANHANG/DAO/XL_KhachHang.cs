using QUANLYBANHANG.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.DAO
{
    public class XL_KhachHang
    {
        public int ThemKhachHang(KhachHang kh)
        {
            int cql = kh.ConQuanLy == true ? 1 : 0;
            int lkl = kh.LaKhachLe == true ? 1 : 0;

            string sql = "insert into KHACH_HANG" +
                "(MaKH,LaKhachLe,MaKhuVuc,TenKH,DiaChi,MaSoThue,Fax," +
                "DienThoai,Mobile,Email,Website,TaiKhoan,NganHang,GioiHanNo," +
                "NoHienTai,ChietKhau,AccYahoo,AccSkype,NguoiLienHe,ConQuanLy) " +
                string.Format("values('{0}',{1},'{2}',N'{3}',N'{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}',{13},{14},{15},'{16}','{17}','{18}',{19})",
                kh.MaKH, lkl, kh.MaKhuVuc, kh.TenKH, kh.DiaChi, kh.MaSoThue,
                kh.Fax, kh.DienThoai, kh.Mobile, kh.Email, kh.Website, kh.TaiKhoan,
                kh.NganHang, kh.GioiHanNo, kh.NoHienTai, kh.ChietKhau, kh.AccYahoo, kh.AccSkype, kh.NguoiLienHe, cql);

            return Execute.InsertUpdateDelete(sql);
        }

        public int CapNhatKhachHang(KhachHang kh)
        {
            int cql = kh.ConQuanLy == true ? 1 : 0;
            int lkl = kh.LaKhachLe == true ? 1 : 0;

            string sql = "update KHACH_HANG set " +
                string.Format("LaKhachLe={0} ,MaKhuVuc='{1}',TenKH=N'{2}',DiaChi=N'{3}',MaSoThue='{4}',",
                lkl, kh.MaKhuVuc, kh.TenKH, kh.DiaChi, kh.MaSoThue) +
                string.Format("Fax='{0}',DienThoai='{1}',Mobile='{2}',Email='{3}',Website='{4}',TaiKhoan='{5}',",
                kh.Fax, kh.DienThoai, kh.Mobile, kh.Email, kh.Website, kh.TaiKhoan) +
                string.Format("NganHang=N'{0}',GioiHanNo={1} ,NoHienTai={2} ,ChietKhau={3} ,AccYahoo='{4}',",
                kh.NganHang, kh.GioiHanNo, kh.NoHienTai, kh.ChietKhau, kh.AccYahoo) +
                string.Format("AccSkype='{0}',NguoiLienHe=N'{1}',ConQuanLy={2}  where MaKH='{3}'",
                kh.AccSkype, kh.NguoiLienHe, cql, kh.MaKH);

            return Execute.InsertUpdateDelete(sql);
        }

        public int XoaKhachHang(string makh)
        {
            string sql = "delete from KHACH_HANG where MaKH='" + makh + "'";

            return Execute.InsertUpdateDelete(sql);
        }
    }
}
