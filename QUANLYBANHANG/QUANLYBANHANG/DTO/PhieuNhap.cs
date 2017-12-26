using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.DTO
{
    public class PhieuNhap
    {
        private string hTTT;
        private string maPhieu;
        private string maNCC;
        private string ghiChu;
        private string soHoaDonVAT;
        private string maNVLap;
        private string soPhieuNhapTay;
        private string maKhoNhap;
        private string dKTT;
        private DateTime ngayLap;
        private DateTime hanThanhToan;

        public string HTTT { get => hTTT; set => hTTT = value; }
        public string MaPhieu { get => maPhieu; set => maPhieu = value; }
        public string MaNCC { get => maNCC; set => maNCC = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public string SoHoaDonVAT { get => soHoaDonVAT; set => soHoaDonVAT = value; }
        public string MaNVLap { get => maNVLap; set => maNVLap = value; }
        public string SoPhieuNhapTay { get => soPhieuNhapTay; set => soPhieuNhapTay = value; }
        public string MaKhoNhap { get => maKhoNhap; set => maKhoNhap = value; }
        public string DKTT { get => dKTT; set => dKTT = value; }
        public DateTime NgayLap { get => ngayLap; set => ngayLap = value; }
        public DateTime HanThanhToan { get => hanThanhToan; set => hanThanhToan = value; }

        public PhieuNhap()
        {
            MaPhieu = "";
            MaNCC = "";
            GhiChu = "";
            SoHoaDonVAT = "";
            MaNVLap = "";
            SoPhieuNhapTay = "";
            MaKhoNhap = "";
            DKTT = "";
            HTTT = "";
            NgayLap = DateTime.Now;
            HanThanhToan = DateTime.Now;
        }
    }
}
