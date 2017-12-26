using QUANLYBANHANG.DAO;
using QUANLYBANHANG.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.BUS
{
    public class NGHIEPVU_CT_PHIEUNHAP
    {
        XL_CT_PhieuNhap xl_ctpn = new XL_CT_PhieuNhap();

        public int ThemCTPhieuNhap(CT_PhieuNhap ctpn)
        {
            return xl_ctpn.ThemCTPhieuNhap(ctpn);
        }
    }
}
