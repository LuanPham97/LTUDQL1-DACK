using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.DTO
{
    public class CT_PhieuXuat
    {
        public string MaPhieuXuat { get; set; }

        public int ID { get; set; }

        public string MaHang { get; set; }

        public int SoLuong { get; set; }

        public int DonGia { get; set; }

        public int ThanhTien { get; set; }

        public int ChietKhau { get; set; }

        public int ThanhToan { get; set; }

        public CT_PhieuXuat()
        {
            MaPhieuXuat = "";
            MaHang = "";
            SoLuong = 0;
            DonGia = 0;
            ChietKhau = 0;
            ThanhToan = 0;
        }
    }
}
