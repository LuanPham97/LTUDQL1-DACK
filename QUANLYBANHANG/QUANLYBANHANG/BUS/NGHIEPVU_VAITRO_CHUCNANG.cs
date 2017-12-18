using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUANLYBANHANG.DAO;
using QUANLYBANHANG.DTO;

namespace QUANLYBANHANG.BUS
{
    public class NGHIEPVU_VAITRO_CHUCNANG
    {
        XL_VaiTro_ChucNang xl = new XL_VaiTro_ChucNang();
        public int ThemVTCN(VaiTro_ChucNang vtcn)
        {
            return xl.ThemVTCN(vtcn);
        }

        public int SuaVTCN(VaiTro_ChucNang vtcn)
        {
            return xl.SuaVTCN(vtcn);
        }

        public int XoaVTCN(string mavt)
        {
            return xl.XoaVTCN(mavt);
        }
    }
}
