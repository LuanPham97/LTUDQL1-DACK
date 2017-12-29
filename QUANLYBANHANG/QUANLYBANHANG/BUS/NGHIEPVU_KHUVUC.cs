using QUANLYBANHANG.DAO;
using QUANLYBANHANG.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.BUS
{
    public class NGHIEPVU_KHUVUC
    {
        XL_KhuVuc xl_kv = new XL_KhuVuc();

        public int ThemKhuVuc(KhuVuc kv)
        {
            return xl_kv.ThemKhuVuc(kv);
        }

        public int CapNhatKhuVuc(KhuVuc kv)
        {
            return xl_kv.CapNhatKhuVuc(kv);
        }

        public int XoaKhuVuc(string makv)
        {
            return xl_kv.XoaKhuVuc(makv);
        }
    }
}
