using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.DTO
{
    public class PhieuNhap
    {
        public string MaPhieu { get; set; }
        public string MaNCC { get; set; }
        public DateTime NgayLap { get; set; }
        public string GhiChu { get; set; }
        public string SoHoaDonVAT { get; set; }
        public string MaNVLap { get; set; }
        public string SoPhieuNhapTay { get; set; }
        public string MaKhoNhap { get; set; }
        public string DieuKhoanThanhToan { get; set; }
        public string HinhThucThanhToan { get; set; }
        public DateTime HanThanhToan { get; set; }
        public int DaTra { get; set; }
        public int TongTien { get; set; }

        public PhieuNhap()
        {
            MaPhieu = "";
            MaNCC = "";
            GhiChu = "";
            SoHoaDonVAT = "";
            MaNVLap = "";
            SoPhieuNhapTay = "";
            MaKhoNhap = "";
            DieuKhoanThanhToan = "";
            HinhThucThanhToan = "";
            NgayLap = DateTime.Now;
            HanThanhToan = DateTime.Now;
            DaTra = 0;
            TongTien = 0;
        }
    }
}
