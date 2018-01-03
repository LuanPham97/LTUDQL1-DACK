using QUANLYBANHANG.DAO;
using QUANLYBANHANG.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.BUS
{
    public class NGHIEPVU_NGUOIDUNG
    {
        XL_NguoiDung xl_nd = new XL_NguoiDung();

        public DataTable LayDuLieuNguoiDung(string sql)
        {
            return xl_nd.LayDuLieuNguoiDung(sql);
        }
        public int DaTonTai(string TenDangNhap)
        {
            return xl_nd.DaTonTai(TenDangNhap);
        }

        public int ThemNguoiDung(NguoiDung nd)
        {
            return xl_nd.ThemNguoiDung(nd);
        }

        public int CapNhatNguoiDung(NguoiDung nd)
        {
            if (string.IsNullOrEmpty(nd.MaVaiTro))
                return 0;
            return xl_nd.CapNhatNguoiDung(nd);
        }

        public int XoaNguoiDung(string tendangnhap)
        {
            return xl_nd.XoaNguoiDung(tendangnhap);
        }

        public int TonTaiDangNhap(string tendangnhap, string pass)
        {
            return xl_nd.TonTaiDangNhap(tendangnhap, pass);
        }

        /// <summary>
        /// lấy mã vai trò từ tên đăng nhập người dùng
        /// </summary>
        /// <param name="tendangnhap"></param>
        /// <returns></returns>
        public string LayMaVaiTro(string tendangnhap)
        {
            return xl_nd.LayMaVaiTro(tendangnhap);
        }

        public string GetPassword(string username)
        {
            return xl_nd.GetPassword(username);
        }

        public int CapNhatMatKhau(string username, string newPass)
        {
            return xl_nd.CapNhatMatKhau(username, newPass);
        }
    }
}
