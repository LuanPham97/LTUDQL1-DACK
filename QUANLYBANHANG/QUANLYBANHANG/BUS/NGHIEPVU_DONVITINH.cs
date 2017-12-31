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
    class NGHIEPVU_DONVITINH
    {
        XL_DonViTinh xl_dvt = new XL_DonViTinh();
        public DataTable LayDuLieuDonViTinh(string sql)
        {
            return xl_dvt.LayDuLieuDonViTinh(sql);
        }

        public int ThemDVTinh(DonViTinh dv)
        {
            return xl_dvt.ThemDVTinh(dv);
        }

        public int CapNhatDVTinh(DonViTinh dv)
        {
            return xl_dvt.CapNhatDVTinh(dv);
        }

        public int XoaDVTinh(string madv)
        {
            return xl_dvt.XoaDVTinh(madv);
        }
    }
}
