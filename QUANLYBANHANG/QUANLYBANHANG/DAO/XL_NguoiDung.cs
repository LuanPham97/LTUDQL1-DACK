using QUANLYBANHANG.DTO;
using System.Data;
using System.Data.SqlClient;

namespace QUANLYBANHANG.DAO
{
    public class XL_NguoiDung
    {
        public DataTable LayDuLieuNguoiDung(string sql)
        {
            return Execute.LayDuLieuBang(sql);
        }

        public int DaTonTai(string TenDangNhap)
        {
            string sql = string.Format("select count(*) from NGUOIDUNG where TenDangNhap = '{0}'", TenDangNhap);

            Provider p = new Provider();
            p.Connect();

            int kq = p.ExecuteScalar(CommandType.Text, sql);

            p.Disconnect();

            return kq;
        }

        public int ThemNguoiDung(NguoiDung nd)
        {
            int cql = nd.ConQuanLy == true ? 1 : 0;
            string sql = string.Format("insert into NGUOIDUNG values(" +
                "'{0}', '{1}', '{2}', '{3}', N'{4}', {5})", nd.TenDangNhap, nd.Password, nd.MaVaiTro, nd.MaNV, nd.DienGiai, cql);

            return Execute.InsertUpdateDelete(sql);
        }

        public int CapNhatNguoiDung(NguoiDung nd)
        {
            int cql = nd.ConQuanLy == true ? 1 : 0;

            string temp = "null";
            if (!string.IsNullOrEmpty(nd.MaNV))
                temp = "'" + nd.MaNV + "'";

            string sql = string.Format("update NGUOIDUNG set" +
                        " Password = '{0}', MaVaiTro = '{1}', MaNV = {2}, DienGiai = N'{3}', ConQuanLy = {4} where TenDangNhap = '{5}'", nd.Password, nd.MaVaiTro, temp, nd.DienGiai, cql, nd.TenDangNhap);

            int nRow = Execute.InsertUpdateDelete(sql);

            return nRow;
        }

        public int XoaNguoiDung(string tendangnhap)
        {
            string sql = string.Format("delete from NGUOIDUNG where TenDangNhap = '{0}'", tendangnhap);

            return Execute.InsertUpdateDelete(sql);
        }

        public int TonTaiDangNhap(string tendangnhap, string pass)
        {
            string sql = string.Format("select count(*) from NGUOIDUNG where TenDangNhap='{0}' and Password='{1}'", tendangnhap, pass);

            return Execute.LaySoDong(sql);
        }

        /// <summary>
        /// lấy mã vai trò từ tên đăng nhập người dùng
        /// </summary>
        /// <param name="tendangnhap"></param>
        /// <returns></returns>
        public string LayMaVaiTro(string tendangnhap)
        {
            string sql = "sp_GetMaVaiTroND";

            Provider p = new Provider();
            p.Connect();

            SqlParameter kq = new SqlParameter("@mavt", SqlDbType.VarChar, 10);
            kq.Direction = ParameterDirection.Output;

            p.ExecuteNonQuery(CommandType.StoredProcedure, sql,
                new SqlParameter { ParameterName = "@tendangnhap", Value = tendangnhap }, kq);

            string mavt = kq.Value.ToString();

            return mavt;
        }

        public string GetPassword(string username)
        {
            string sql = "sp_GetPassword";

            Provider p = new Provider();
            p.Connect();

            SqlParameter kq = new SqlParameter("@pass", SqlDbType.VarChar, 20);
            kq.Direction = ParameterDirection.Output;

            p.ExecuteNonQuery(CommandType.StoredProcedure, sql,
                new SqlParameter { ParameterName = "@username", Value = username }, kq);

            string pass = kq.Value.ToString();

            return pass;
        }

        public int CapNhatMatKhau(string username, string newPass)
        {
            string sql = string.Format("update NGUOIDUNG set Password = '{0}' where TenDangNhap = '{1}'",
                newPass, username);

            return Execute.InsertUpdateDelete(sql);
        }
    }
}
