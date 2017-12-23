using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.DTO
{
    public class CT_PhieuXuat
    {
        string _maPhieuXuat, _maHang;
        int _soLuong, _donGia, _chietKhau, _thanhToan, _ID;

        public string MaPhieuXuat { get => _maPhieuXuat; set => _maPhieuXuat = value; }
        public string MaHang { get => _maHang; set => _maHang = value; }
        public int SoLuong { get => _soLuong; set => _soLuong = value; }
        public int DonGia { get => _donGia; set => _donGia = value; }
        public int ChietKhau { get => _chietKhau; set => _chietKhau = value; }
        public int ThanhToan { get => _thanhToan; set => _thanhToan = value; }
        public int ID { get => _ID; set => _ID = value; }

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
