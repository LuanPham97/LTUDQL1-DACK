using QUANLYBANHANG.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.DAO
{
    public class XL_CT_PhieuXuat
    {
        public int ThemCTPhieuXuat(CT_PhieuXuat ctpx)
        {
            string sql = "insert into CT_PHIEU_XUAT(MaPhieuXuat,MaHang,SoLuong,DonGia,ChietKhau,ThanhToan, ThanhTien) " +
                string.Format("values ('{0}','{1}',{2},{3},{4},{5},{6})",
                ctpx.MaPhieuXuat, ctpx.MaHang, ctpx.SoLuong, ctpx.DonGia, ctpx.ChietKhau, ctpx.ThanhToan, ctpx.ThanhTien);

            return Execute.InsertUpdateDelete(sql);
        }
    }
}
