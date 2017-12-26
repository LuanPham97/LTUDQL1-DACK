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
    public class NGHIEPVU_HANGHOA
    {
        XL_HangHoa xl_hh = new XL_HangHoa();

        public DataTable LayDuLieuHangHoa(string sql)
        {
            return xl_hh.LayDuLieuHangHoa(sql);
        }

        public int ThemHangHoa(HangHoa hh)
        {
            if (string.IsNullOrEmpty(hh.TenHang) || string.IsNullOrEmpty(hh.DonVi))
            {
                return 0;
            }

            return xl_hh.ThemHangHoa(hh);
        }

        public int CapNhatHangHoa(HangHoa hh)
        {
            if (string.IsNullOrEmpty(hh.TenHang) || string.IsNullOrEmpty(hh.DonVi))
            {
                return 0;
            }

            return xl_hh.CapNhatHangHoa(hh);
        }

        public int XoaHangHoa(string mahh)
        {
            if (string.IsNullOrEmpty(mahh))
            {
                return 0;
            }

            return xl_hh.XoaHangHoa(mahh);
        }

        public int CapNhatSlTon(string mahh, int slBan, int isPlus)
        {
            return xl_hh.CapNhatSlTon(mahh, slBan, isPlus);
        }
    }
}
