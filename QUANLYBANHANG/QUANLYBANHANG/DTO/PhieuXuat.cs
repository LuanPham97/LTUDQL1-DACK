using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.DTO
{
    public class PhieuXuat
    {
        private string hTTT;
        private DateTime ngayGiao;
        private string maPhieu;
        private string maKH;
        private string ghiChu;
        private string soHoaDonVAT;
        private string maNVLap;
        private string soPhieuNhapTay;
        private string maKhoXuat;
        private string dKTT;
        private DateTime ngayLap;
        private DateTime hanThanhToan;

        public string MaPhieu { get => maPhieu; set => maPhieu = value; }
        public string MaKH { get => maKH; set => maKH = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public string SoHoaDonVAT { get => soHoaDonVAT; set => soHoaDonVAT = value; }
        public string MaNVLap { get => maNVLap; set => maNVLap = value; }
        public string SoPhieuNhapTay { get => soPhieuNhapTay; set => soPhieuNhapTay = value; }
        public string MaKhoXuat { get => maKhoXuat; set => maKhoXuat = value; }
        public string DKTT { get => dKTT; set => dKTT = value; }
        public string HTTT { get => hTTT; set => hTTT = value; }
        public DateTime NgayLap { get => ngayLap; set => ngayLap = value; }
        public DateTime HanThanhToan { get => hanThanhToan; set => hanThanhToan = value; }
        public DateTime NgayGiao { get => ngayGiao; set => ngayGiao = value; }
    }
}
