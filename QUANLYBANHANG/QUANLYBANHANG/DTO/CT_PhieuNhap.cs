using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.DTO
{
    public class CT_PhieuNhap
    {
        public string MaPhieuNhap { get; set; }

        public int ID { get; set; }

        public string MaHang { get; set; }

        public int SoLuong { get; set; }

        public int DonGia { get; set; }

        public int ThanhTien { get; set; }

        public string GhiChu { get; set; }


        public CT_PhieuNhap()
        {
            MaPhieuNhap = "";
            MaHang = "";
            SoLuong = 0;
            DonGia = 0;
            GhiChu = "";
            ThanhTien = 0;
        }

    }
}
