using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.DTO
{
    public class KhachHang
    {
        string _maKH, _maKV, _tenKH, _diaChi, _maSoThue, _fax, _dienThoai, _mobile, _Email, _Website;
        string _taiKhoan, _nganHang, _accYahoo, _accSkype, _nguoiLienHe;
        int _gioiHanNo, _noHienTai, _chietKhau, _laKhachLe, _conQuanLy;

        public string MaKH { get => _maKH; set => _maKH = value; }
        public string MaKV { get => _maKV; set => _maKV = value; }
        public string TenKH { get => _tenKH; set => _tenKH = value; }
        public string DiaChi { get => _diaChi; set => _diaChi = value; }
        public string MaSoThue { get => _maSoThue; set => _maSoThue = value; }
        public string Fax { get => _fax; set => _fax = value; }
        public string DienThoai { get => _dienThoai; set => _dienThoai = value; }
        public string Mobile { get => _mobile; set => _mobile = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Website { get => _Website; set => _Website = value; }
        public string TaiKhoan { get => _taiKhoan; set => _taiKhoan = value; }
        public string NganHang { get => _nganHang; set => _nganHang = value; }
        public string AccYahoo { get => _accYahoo; set => _accYahoo = value; }
        public string AccSkype { get => _accSkype; set => _accSkype = value; }
        public string NguoiLienHe { get => _nguoiLienHe; set => _nguoiLienHe = value; }
        public int LaKhachLe { get => _laKhachLe; set => _laKhachLe = value; }
        public int ConQuanLy { get => _conQuanLy; set => _conQuanLy = value; }
        public int GioiHanNo { get => _gioiHanNo; set => _gioiHanNo = value; }
        public int NoHienTai { get => _noHienTai; set => _noHienTai = value; }
        public int ChietKhau { get => _chietKhau; set => _chietKhau = value; }
    }
}
