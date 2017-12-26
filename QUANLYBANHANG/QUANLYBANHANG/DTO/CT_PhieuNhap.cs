using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.DTO
{
    public class CT_PhieuNhap
    {
        string _maPhieuNhap, _maHang;
        int _soLuong, _donGia, _ID;
        string _ghiChu;

        
        public int SoLuong { get => _soLuong; set => _soLuong = value; }
        public int DonGia { get => _donGia; set => _donGia = value; }
        public int ID { get => _ID; set => _ID = value; }
        public string MaPhieuNhap { get => _maPhieuNhap; set => _maPhieuNhap = value; }
        public string MaHang { get => _maHang; set => _maHang = value; }
        public string GhiChu { get => _ghiChu; set => _ghiChu = value; }

        public CT_PhieuNhap()
        {
            MaPhieuNhap = "";
            MaHang = "";
            SoLuong = 0;
            DonGia = 0;
            GhiChu = "";
        }

    }
}
