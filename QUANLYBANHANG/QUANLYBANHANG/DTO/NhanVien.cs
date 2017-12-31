using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.DTO
{
    public class NhanVien
    {
        public string MaNhanVien { get; set; }

        public string TenNhanVien { get; set; }

        public string ChucVu { get; set; }

        public string DiaChi { get; set; }

        public string Email { get; set; }

        public string DienThoai { get; set; }

        public string BoPhan { get; set; }

        public string NguoiQuanLy { get; set; }

        public bool ConQuanLy { get; set; }

        public string DiDong { get; set; }

        public NhanVien()
        {
            MaNhanVien = "";
            TenNhanVien = "";
            ChucVu = "";
            DiaChi = "";
            Email = "";
            DienThoai = "";
            DiDong = "";
            BoPhan = "";
            NguoiQuanLy = "";
            ConQuanLy = false;
        }
    }
}
