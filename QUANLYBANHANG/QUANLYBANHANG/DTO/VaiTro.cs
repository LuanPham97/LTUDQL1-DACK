using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.DTO
{
    public class VaiTro
    {
        public string MaVaiTro { get; set; }
        public string TenVaiTro { get; set; }
        public string DienGiai { get; set; }
        public bool KichHoat { get; set; }

        public VaiTro()
        {
            MaVaiTro = "";
            TenVaiTro = "";
            DienGiai = "";
            KichHoat = false;
        }
    }
}
