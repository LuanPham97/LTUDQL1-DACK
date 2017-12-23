using QUANLYBANHANG.DAO;
using QUANLYBANHANG.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.BUS
{
    public class NGHIEPVU_CT_PHIEUXUAT
    {
        XL_CT_PhieuXuat xl_ctpx = new XL_CT_PhieuXuat();

        public int ThemCTPhieuXuat(CT_PhieuXuat ctpx)
        {
            return xl_ctpx.ThemCTPhieuXuat(ctpx);
        }
    }
}
