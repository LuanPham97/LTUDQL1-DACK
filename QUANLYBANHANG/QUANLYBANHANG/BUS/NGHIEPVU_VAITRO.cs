using QUANLYBANHANG.DAO;
using QUANLYBANHANG.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.BUS
{
    public class NGHIEPVU_VAITRO
    {
        XL_VaiTro xl_vt = new XL_VaiTro();

        public DataTable LayDuLieuVaiTro(string sql)
        {
            return xl_vt.LayDuLieuVaiTro(sql);
        }

        public int ThemVaiTro(VaiTro vt)
        {
            return xl_vt.ThemVaiTro(vt);
        }

        public int SuaVaiTro(VaiTro vt)
        {
            return xl_vt.SuaVaiTro(vt);
        }

        public int XoaVaiTro(string mavt)
        {
            return xl_vt.XoaVaiTro(mavt);
        }
    }
}
