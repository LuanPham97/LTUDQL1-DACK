using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.DTO
{
    public class NhanVien
    {
        string _maNhanVien, _tenNhanVien, _chucVu, _diaChi, _email, _dienThoai, _boPhan, _nguoiQuanLy;
        bool _conQuanLy;

        public string MaNhanVien { get => _maNhanVien; set => _maNhanVien = value; }
        public string TenNhanVien { get => _tenNhanVien; set => _tenNhanVien = value; }
        public string ChucVu { get => _chucVu; set => _chucVu = value; }
        public string DiaChi { get => _diaChi; set => _diaChi = value; }
        public string Email { get => _email; set => _email = value; }
        public string DienThoai { get => _dienThoai; set => _dienThoai = value; }
        public string BoPhan { get => _boPhan; set => _boPhan = value; }
        public string NguoiQuanLy { get => _nguoiQuanLy; set => _nguoiQuanLy = value; }
        public bool ConQuanLy { get => _conQuanLy; set => _conQuanLy = value; }

        public NhanVien()
        {
            MaNhanVien = "";
            TenNhanVien = "";
            ChucVu = "";
            DiaChi = "";
            Email = "";
            DienThoai = "";
            BoPhan = "";
            NguoiQuanLy = "";
            ConQuanLy = false;
        }
    }
}
