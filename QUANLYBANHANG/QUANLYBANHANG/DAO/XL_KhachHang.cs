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
            string sql = "insert into KHACH_HANG" +
                "(MaKH,LaKhachLe,MaKhuVuc,TenKH,DiaChi,MaSoThue,Fax," +
                "DienThoai,Mobile,Email,Website,TaiKhoan,NganHang,GioiHanNo," +
                "NoHienTai,ChietKhau,AccYahoo,AccSkype,NguoiLienHe,ConQuanLy) " +
                string.Format("values('{0}',{1},'{2}',N'{3}',N'{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}',{13},{14},{15},'{16}','{17}','{18}',{19})",
                kh.MaKH, kh.LaKhachLe, kh.MaKV, kh.TenKH, kh.DiaChi, kh.MaSoThue,
                kh.Fax, kh.DienThoai, kh.Mobile, kh.Email, kh.Website, kh.TaiKhoan,
                kh.NganHang, kh.GioiHanNo, kh.NoHienTai, kh.ChietKhau, kh.AccYahoo, kh.AccSkype, kh.NguoiLienHe, kh.ConQuanLy);

            return Execute.InsertUpdateDelete(sql);
        }
    }
}
