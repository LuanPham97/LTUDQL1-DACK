using QUANLYBANHANG.DAO;
using QUANLYBANHANG.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.BUS
{
    public class NGHIEPVU_PHIEUXUAT
    {
        XL_PhieuXuat xl_px = new XL_PhieuXuat();

        public int ThemPhieuXuat(PhieuXuat px)
        {
            return xl_px.ThemPhieuXuat(px);
        }

        public int CapNhatTienDaTra(string mapx, int sotien)
        {
            return xl_px.CapNhatTienDaTra(mapx, sotien);
        }
    }
}
