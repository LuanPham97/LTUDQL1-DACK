using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.DTO
{
    public class PhieuChiTien
    {
        public int MaPhieuChi { get; set; }

        public string MaNCC { get; set; }

        public string MaPhieuXuat { get; set; }

        public DateTime NgayLap { get; set; }

        public int SoTien { get; set; }

        public int ConNo { get; set; }

        public int SoTienTra { get; set; }

        public string MaNV { get; set; }

        public string LyDo { get; set; }
    }
}
