using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.DTO
{
    public class HangHoa
    {
        public string MaHangHoa { get; set; }
        public string LoaiHangHoa { get; set; }
        public string KhoMacDinh { get; set; }
        public string PhanLoai { get; set; }
        public string MaVachNSX { get; set; }
        public string TenHang { get; set; }
        public string DonVi { get; set; }
        public string XuatXu { get; set; }
        public int TonKhoToiThieu { get; set; }
        public int TonHienTai { get; set; }
        public string NhaCungCap { get; set; }
        public int GiaMua { get; set; }
        public int GiaBanLe { get; set; }
        public int GiaBanSi { get; set; }
        public bool ConQuanLy { get; set; }

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
            NhaCungCap = "";
            TonKhoToiThieu = 0;
            TonHienTai = 0;
            GiaMua = 0;
            GiaBanLe = 0;
            GiaBanSi = 0;
            ConQuanLy = false;
        }
    }
}
