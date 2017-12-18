using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUANLYBANHANG.DAO;
using System.Data;

namespace QUANLYBANHANG.BUS
{
    class NGHIEPVU_DONVITINH
    {
        XL_DonViTinh xl_dvt = new XL_DonViTinh();
        public DataTable LayDuLieuDonViTinh(string sql)
        {
            return xl_dvt.LayDuLieuDonViTinh(sql);
        }
    }
}
