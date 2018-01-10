using QUANLYBANHANG.DAO;
using QUANLYBANHANG.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.BUS
{
    public class NGHIEPVU_PHIEUTHUTIEN
    {
        XL_PhieuThuTien xl_pt = new XL_PhieuThuTien();

        public int ThemPhieuThu(PhieuThuTien pt)
        {
            return xl_pt.ThemPhieuThu(pt);
        }
    }
}
