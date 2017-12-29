using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUANLYBANHANG.DAO;
using System.Data;
using QUANLYBANHANG.DTO;

namespace QUANLYBANHANG.BUS
{
    class NGHIEPVU_NHACUNGCAP
    {
        XL_NhaCungCap xl_ncc = new XL_NhaCungCap();
        public DataTable LayDuLieuNCC(string sql)
        {
            return xl_ncc.LayDuLieuNCC(sql);
        }

        public int ThemNCC(NhaCC ncc)
        {
            return xl_ncc.ThemNCC(ncc);
        }

        public int CapNhatNCC(NhaCC ncc)
        {
            return xl_ncc.CapNhatNCC(ncc);
        }

        public int XoaNCC(string mancc)
        {
            return xl_ncc.XoaNCC(mancc);
        }
    }
}
