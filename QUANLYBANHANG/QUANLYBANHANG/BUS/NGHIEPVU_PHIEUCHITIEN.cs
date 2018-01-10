using QUANLYBANHANG.DAO;
using QUANLYBANHANG.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.BUS
{
   public class NGHIEPVU_PHIEUCHITIEN
    {
        XL_PhieuChiTien XL_PC = new XL_PhieuChiTien();

        public int ThemPhieuChi(PhieuChiTien pc)
        {
            return XL_PC.ThemPhieuChi(pc);
        }
    }
}
