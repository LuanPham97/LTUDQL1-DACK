using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.DTO
{
    public class NguoiDung
    {
        string _id,_tenDangNhap, _password, _maVaiTro, _maNV, _dienGiai;
        bool _conQuanLy;

        public bool ConQuanLy { get => _conQuanLy; set => _conQuanLy = value; }
        public string ID { get => _id; set => _id = value; }
        public string TenDangNhap { get => _tenDangNhap; set => _tenDangNhap = value; }
        public string Password { get => _password; set => _password = value; }
        public string MaVaiTro { get => _maVaiTro; set => _maVaiTro = value; }
        public string MaNV { get => _maNV; set => _maNV = value; }
        public string DienGiai { get => _dienGiai; set => _dienGiai = value; }

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
