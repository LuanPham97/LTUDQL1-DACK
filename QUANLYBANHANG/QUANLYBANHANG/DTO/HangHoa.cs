using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.DTO
{
    public class HangHoa
    {
        string _maHangHoa, _loaiHangHoa, _khoMacDinh,
            _phanLoai, _maVachNSX, _tenHang,
            _donVi, _XuatXu, _NCC;
        int _tonKhoToiThieu,
            _tonHienTai, _giaMua, _giaBanLe,
            _giaBanSi;
        bool _conQuanLy;

        public string MaHangHoa { get => _maHangHoa; set => _maHangHoa = value; }
        public string LoaiHangHoa { get => _loaiHangHoa; set => _loaiHangHoa = value; }
        public string KhoMacDinh { get => _khoMacDinh; set => _khoMacDinh = value; }
        public string PhanLoai { get => _phanLoai; set => _phanLoai = value; }
        public string MaVachNSX { get => _maVachNSX; set => _maVachNSX = value; }
        public string TenHang { get => _tenHang; set => _tenHang = value; }
        public string DonVi { get => _donVi; set => _donVi = value; }
        public string XuatXu { get => _XuatXu; set => _XuatXu = value; }
        public string NCC { get => _NCC; set => _NCC = value; }
        public int TonKhoToiThieu { get => _tonKhoToiThieu; set => _tonKhoToiThieu = value; }
        public int TonHienTai { get => _tonHienTai; set => _tonHienTai = value; }
        public int GiaMua { get => _giaMua; set => _giaMua = value; }
        public int GiaBanLe { get => _giaBanLe; set => _giaBanLe = value; }
        public int GiaBanSi { get => _giaBanSi; set => _giaBanSi = value; }
        public bool ConQuanLy { get => _conQuanLy; set => _conQuanLy = value; }

        public HangHoa()
        {
            MaHangHoa = "";
            LoaiHangHoa = "";
            KhoMacDinh = "";
            PhanLoai = "";
            MaVachNSX = "";
            TenHang = "";
            DonVi = "";
            XuatXu = "";
            NCC = "";
            TonKhoToiThieu = 0;
            TonHienTai = 0;
            GiaMua = 0;
            GiaBanLe = 0;
            GiaBanSi = 0;
            ConQuanLy = false;
        }
    }
}
