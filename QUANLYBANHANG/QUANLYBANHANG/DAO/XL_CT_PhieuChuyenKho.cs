using QUANLYBANHANG.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.DAO
{
    public class XL_CT_PhieuChuyenKho
    {
        public int ThemCTPhieuChuyen(CT_PhieuChuyenKho ct_pc)
        {
            string sql = "insert into CT_PhieuChuyenKho(MaPhieuChuyen,MaHang,SoLuong)" +
                string.Format(" values ('{0}','{1}',{2})", ct_pc.MaPhieuChuyen, ct_pc.MaHang, ct_pc.SoLuong);

            return Execute.InsertUpdateDelete(sql);
        }
    }
}
