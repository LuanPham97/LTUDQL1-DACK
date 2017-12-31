using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.DTO
{
    public class VaiTro_ChucNang
    {
        public string MaVaiTro { get; set; }
        public int MaChucNang { get; set; }
        public int TatCa { get; set; }
        public int TruyCap { get; set; }
        public int Them { get; set; }
        public int Xoa { get; set; }
        public int Sua { get; set; }
        public int InAn { get; set; }
        public int Nhap { get; set; }
        public int Xuat { get; set; }
        public string TenTrongHeThong { get; set; }

        public VaiTro_ChucNang()
        {
            MaVaiTro = "";
            MaChucNang = 0;
            TatCa = -1;
            TruyCap = -1;
            Them = -1;
            Xoa = -1;
            Sua = -1;
            InAn = -1;
            Nhap = -1;
            Xuat = -1;
            TenTrongHeThong = "";
        }
    }
}
