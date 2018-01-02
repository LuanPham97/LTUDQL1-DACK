using QUANLYBANHANG.DAO;
using QUANLYBANHANG.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.BUS
{
    public class NGHIEPVU_BOPHAN
    {
        XL_BoPhan xl_bp = new XL_BoPhan();

        public int ThemBoPhan(BoPhan bp)
        {
            return xl_bp.ThemBoPhan(bp);
        }

        public int CapNhatBoPhan(BoPhan bp)
        {
            return xl_bp.CapNhatBoPhan(bp);
        }

        public int XoaBoPhan(string mabp)
        {
            return xl_bp.XoaBoPhan(mabp);
        }

        /// <summary>
        /// kiểm tra mã có tồn tại hay không, trả về true nếu tồn tại
        /// </summary>
        /// <param name="mabp"></param>
        /// <returns>true nếu có tồn tại</returns>
        public bool KiemTraMaTonTai(string mabp)
        {
            return xl_bp.KiemTraMaTonTai(mabp);
        }
    }
}
