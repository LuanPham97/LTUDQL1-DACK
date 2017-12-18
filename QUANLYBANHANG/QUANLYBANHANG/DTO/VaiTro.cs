using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.DTO
{
    public class VaiTro
    {
        string _maVaiTro, _tenVaiTro, _dienGiai;
        bool _kichHoat;

        public string MaVaiTro { get => _maVaiTro; set => _maVaiTro = value; }
        public string TenVaiTro { get => _tenVaiTro; set => _tenVaiTro = value; }
        public string DienGiai { get => _dienGiai; set => _dienGiai = value; }
        public bool KichHoat { get => _kichHoat; set => _kichHoat = value; }

        public VaiTro()
        {
            MaVaiTro = "";
            TenVaiTro = "";
            DienGiai = "";
            KichHoat = false;
        }
    }
}
