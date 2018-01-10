using QUANLYBANHANG.DAO;
using QUANLYBANHANG.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.BUS
{
    public class NGHIEPVU_PHIEUNHAP
    {
        XL_PhieuNhap xl_pn = new XL_PhieuNhap();

        public int ThemPhieuNhap(PhieuNhap pn)
        {
            return xl_pn.ThemPhieuNhap(pn);
        }

        public int CapNhatTienDaTra(string mapn, int sotien)
        {
            return xl_pn.CapNhatTienDaTra(mapn, sotien);
        }
    }
}
