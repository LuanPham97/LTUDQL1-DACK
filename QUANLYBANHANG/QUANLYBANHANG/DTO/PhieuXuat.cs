using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.DTO
{
    public class PhieuXuat
    {
        public string MaPhieu { get; set; }

        public string MaKH { get; set; }

        public DateTime NgayLap { get; set; }

        public string GhiChu { get; set; }

        public string SoHoaDonVAT { get; set; }

        public string MaNVLap { get; set; }

        public string SoPhieuNhapTay { get; set; }

        public string MaKhoXuat { get; set; }

        public string DieuKhoanThanhToan { get; set; }

        public string HinhThucThanhToan { get; set; }

        public DateTime HanThanhToan { get; set; }

        public DateTime NgayGiao { get; set; }

        public int DaTra { get; set; }

        public int TongTien { get; set; }

        public PhieuXuat()
        {
            MaPhieu = "";
            MaKH = "";
            GhiChu = "";
            SoHoaDonVAT = "";
            MaNVLap = "";
            SoPhieuNhapTay = "";
            MaKhoXuat = "";
            DieuKhoanThanhToan = "";
            HinhThucThanhToan = "";
            NgayLap = DateTime.Now;
            HanThanhToan = DateTime.Now;
            NgayGiao = DateTime.Now;
            DaTra = 0;
            TongTien = 0;
        }
    }
}
