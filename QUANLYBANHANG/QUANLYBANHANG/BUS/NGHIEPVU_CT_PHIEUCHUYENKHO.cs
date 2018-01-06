using QUANLYBANHANG.DAO;
using QUANLYBANHANG.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.BUS
{
    public class NGHIEPVU_CT_PHIEUCHUYENKHO
    {
        XL_CT_PhieuChuyenKho xl_ctpc = new XL_CT_PhieuChuyenKho();

        public int ThemCTPhieuChuyen(CT_PhieuChuyenKho ct_pc)
        {
            return xl_ctpc.ThemCTPhieuChuyen(ct_pc);
        }
    }
}
