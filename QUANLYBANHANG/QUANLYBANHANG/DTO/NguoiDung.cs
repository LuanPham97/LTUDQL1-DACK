using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.DTO
{
    public class NguoiDung
    {
        public int ID { get; set; }

        public string TenDangNhap { get; set; }

        public string Password { get; set; }

        public string MaVaiTro { get; set; }

        public string MaNV { get; set; }

        public string DienGiai { get; set; }

        public bool ConQuanLy { get; set; }

        public NguoiDung()
        {
            TenDangNhap = "";
            Password = "";
            MaVaiTro = "";
            MaNV = "";
            DienGiai = "";
            ConQuanLy = false;
        }
    }
}
