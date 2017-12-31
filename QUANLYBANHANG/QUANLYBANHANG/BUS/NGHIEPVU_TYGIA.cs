﻿using QUANLYBANHANG.DAO;
using QUANLYBANHANG.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.BUS
{
    public class NGHIEPVU_TYGIA
    {
        XL_TyGia xl_tg = new XL_TyGia();

        public int ThemTyGia(TyGia tg)
        {
            return xl_tg.ThemTyGia(tg);
        }

        public int CapNhatTyGia(TyGia tg)
        {
            return xl_tg.CapNhatTyGia(tg);
        }

        public int XoaTyGia(string matg)
        {
            return xl_tg.XoaTyGia(matg);
        }
    }
}
