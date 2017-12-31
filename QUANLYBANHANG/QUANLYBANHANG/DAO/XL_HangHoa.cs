using QUANLYBANHANG.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.DAO
{
    public class XL_HangHoa
    {
        public DataTable LayDuLieuHangHoa(string sql)
        {
            return Execute.LayDuLieuBang(sql);
        }

        public int ThemHangHoa(HangHoa hh)
        {
            int cql = hh.ConQuanLy == true ? 1 : 0;
            string sql = string.Format("insert into HANGHOA values" +
                "('{0}',N'{1}','{2}','{3}','{4}',N'{5}','{6}',N'{7}',{8},{9},'{10}',{11},{12},{13},{14})",
                hh.MaHangHoa, hh.LoaiHangHoa, hh.KhoMacDinh, hh.PhanLoai, hh.MaVachNSX, hh.TenHang, hh.DonVi,
                hh.XuatXu, hh.TonKhoToiThieu, hh.TonHienTai, hh.NhaCungCap, hh.GiaMua, hh.GiaBanLe, hh.GiaBanSi, cql);

            int nRow = Execute.InsertUpdateDelete(sql);

            return nRow;
        }

        public int CapNhatHangHoa(HangHoa hh)
        {
            int cql = hh.ConQuanLy == true ? 1 : 0;

            string sql = string.Format("update HANGHOA set " +
                "LoaiHangHoa = N'{0}', KhoMacDinh = '{1}', PhanLoai = '{2}', MaVachNSX='{3}', TenHang=N'{4}', DonVi='{5}', XuatXu=N'{6}', TonKhoToiThieu={7} , TonHienTai={8} , NhaCungCap='{9}', GiaMua={10} , GiaBanLe={11} , GiaBanSi={12} , ConQuanLy={13} where MaHangHoa={14}",
                hh.LoaiHangHoa, hh.KhoMacDinh, hh.PhanLoai, hh.MaVachNSX, hh.TenHang, hh.DonVi, hh.XuatXu, hh.TonKhoToiThieu, hh.TonHienTai, hh.NhaCungCap, hh.GiaMua, hh.GiaBanLe, hh.GiaBanSi, cql, hh.MaHangHoa);

            int nRow = Execute.InsertUpdateDelete(sql);

            return nRow;
        }

        public int XoaHangHoa(string mahh)
        {
            string sql = "delete from HANGHOA where MaHangHoa = " + mahh;

            int nRow = Execute.InsertUpdateDelete(sql);

            return nRow;
        }

        public int CapNhatSlTon(string mahh, int slBan, int isPlus)
        {
            string dau = isPlus == 1 ? "+" : "-";

            string sql = string.Format("update HANGHOA set TonHienTai {0}= {1} where MaHangHoa='{2}'",
              dau, slBan, mahh);

            return Execute.InsertUpdateDelete(sql);
        }
    }
}
