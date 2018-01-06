using QUANLYBANHANG.DAO;
using QUANLYBANHANG.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.BUS
{
    public class NGHIEPVU_PHIEUCHUYENKHO
    {
        XL_PhieuChuyenKho xl_pc = new XL_PhieuChuyenKho();

        public int ThemPhieuChuyenKho(PhieuChuyenKho pc)
        {
            return xl_pc.ThemPhieuChuyenKho(pc);
        }
    }
}
