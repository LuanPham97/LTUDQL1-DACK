using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QUANLYBANHANG.DAO
{
    public class Execute
    {
        public static DataTable LayDuLieuBang(string sql)
        {
            Provider p = new Provider();
            p.Connect();

            DataTable dt = p.Select(CommandType.Text, sql);

            p.Disconnect();

            return dt;
        }

        public static int InsertUpdateDelete(string sql)
        {
            Provider p = new Provider();

            p.Connect();

            int nRow = 0;
            nRow = p.ExecuteNonQuery(CommandType.Text, sql);

            p.Disconnect();

            return nRow;
        }

        public static int LaySoDong(string sql)
        {
            Provider p = new Provider();
            p.Connect();

            int row = p.ExecuteScalar(CommandType.Text, sql);

            p.Disconnect();

            return row;
        }

        public static string GenerateMa(string tenSP)
        {
            string sql = tenSP;

            Provider p = new Provider();
            p.Connect();

            SqlParameter ma = new SqlParameter("@kq", SqlDbType.VarChar, 10);
            ma.Direction = ParameterDirection.Output;

            p.ExecuteNonQuery(CommandType.StoredProcedure, sql, ma);

            p.Disconnect();

            return ma.Value.ToString();
        }

        public static void BackUpDatabase(string path, string db)
        {
            string sql = string.Format("backup database {0} to disk = '{1}'",
                db, path);

            Provider p = new Provider();
            p.Connect();

            p.ExecuteNonQuery(CommandType.Text, sql);

            p.Disconnect();
        }

        public static void RestoreDatabase(string path, string db)
        {
            string sql = string.Format("restore database {0} from disk = '{1}'",
                db, path);

            Provider p = new Provider();
            p.Connect();

            p.ExecuteNonQuery(CommandType.Text, sql);

            p.Disconnect();
        }
    }
}
