using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.DTO
{
    public class ChucNang
    {
        string _tenChucNang;
        int _maChucNang, _maCha;

        public string TenChucNang { get => _tenChucNang; set => _tenChucNang = value; }
        public int MaChucNang { get => _maChucNang; set => _maChucNang = value; }
        public int MaCha { get => _maCha; set => _maCha = value; }
    }
}
