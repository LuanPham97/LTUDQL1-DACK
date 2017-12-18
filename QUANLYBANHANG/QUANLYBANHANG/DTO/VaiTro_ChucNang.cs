using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.DTO
{
    public class VaiTro_ChucNang
    {
        string _maVaiTro;
        int _maChucNang;
        int _tatCa, _truyCap, _them, _xoa, _sua, _inAn, _nhap, _xuat;

        string _tenTrongHeThong;

        public string MaVaiTro { get => _maVaiTro; set => _maVaiTro = value; }
        public int MaChucNang { get => _maChucNang; set => _maChucNang = value; }
        public int TatCa { get => _tatCa; set => _tatCa = value; }
        public int TruyCap { get => _truyCap; set => _truyCap = value; }
        public int Them { get => _them; set => _them = value; }
        public int Xoa { get => _xoa; set => _xoa = value; }
        public int Sua { get => _sua; set => _sua = value; }
        public int InAn { get => _inAn; set => _inAn = value; }
        public int Nhap { get => _nhap; set => _nhap = value; }
        public int Xuat { get => _xuat; set => _xuat = value; }
        public string TenTrongHeThong { get => _tenTrongHeThong; set => _tenTrongHeThong = value; }

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
