using QUANLYBANHANG.DAO;
using QUANLYBANHANG.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.BUS
{
    public class NGHIEPVU_KHACHHANG
    {
        XL_KhachHang xl_kh = new XL_KhachHang();

        public int ThemKhachHang(KhachHang kh)
        {
            return xl_kh.ThemKhachHang(kh);
        }
    }
}
