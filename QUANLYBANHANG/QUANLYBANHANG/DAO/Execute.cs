using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

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
    }
}
