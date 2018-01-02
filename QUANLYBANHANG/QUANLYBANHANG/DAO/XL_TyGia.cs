using QUANLYBANHANG.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANHANG.DAO
{
   public class XL_TyGia
    {
        public int ThemTyGia(TyGia tg)
        {
            int cql = tg.ConQuanLy == true ? 1 : 0;

            string sql = "insert into TYGIA " +
                "(MaTyGia,TenTyGia,TyGiaQuyDoi,ConQuanLy) " +
                string.Format("values ('{0}',N'{1}',{2},{3})",
                tg.MaTyGia, tg.TenTyGia, tg.TyGiaQuyDoi, cql);

            return Execute.InsertUpdateDelete(sql);
        }

        public int CapNhatTyGia(TyGia tg)
        {
            int cql = tg.ConQuanLy == true ? 1 : 0;

            string sql = "update TYGIA set " +
                string.Format("TenTyGia=N'{0}',TyGiaQuyDoi={1} ,ConQuanLy={2} where MaTyGia='{3}'",
                tg.TenTyGia, tg.TyGiaQuyDoi, cql, tg.MaTyGia);

            return Execute.InsertUpdateDelete(sql);
        }

        public int XoaTyGia(string matg)
        {
            string sql = "delete from TYGIA where MaTyGia='" + matg + "'";

            return Execute.InsertUpdateDelete(sql);
        }

        /// <summary>
        /// kiểm tra mã có tồn tại hay không
        /// </summary>
        /// <param name="matg"></param>
        /// <returns>true nếu có tồn tại</returns>
        public bool KiemTraMaTonTai(string matg)
        {
            string sql = "select count(*) from TYGIA where MaTyGia like '" + matg + "'";

            int kq = Execute.LaySoDong(sql);
            if (kq >= 1)
                return true;
            return false;
        }
    }
}
