using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QUANLYBANHANG.DAO
{
    class Provider
    {
        static string ConnectionString = @"Data Source=LUANPHAM\LPZZZ;Initial Catalog=QuanLyBanHang_DoAn;Integrated Security=True";
        SqlConnection Connection { get; set; }
        public void Connect()
        {
            try
            {
                if (Connection == null)
                    Connection = new SqlConnection(ConnectionString);
                if (Connection.State != ConnectionState.Closed)
                    Connection.Close();
                Connection.Open();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void Disconnect()
        {
            if (Connection != null && Connection.State == ConnectionState.Open)
                Connection.Close();
        }

        // Insert, Update, Delete
        // Không dùng tham số
        public int ExecuteNonQuery(CommandType cmdType, string strSql)
        {
            try
            {
                SqlCommand command = Connection.CreateCommand();
                command.CommandText = strSql;
                command.CommandType = cmdType;

                int nRow = command.ExecuteNonQuery();
                return nRow;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Execute Scalar
        /// </summary>
        /// <param name="cmdType"></param>
        /// <param name="strSql"></param>
        /// <returns></returns>
        public int ExecuteScalar(CommandType cmdType, string strSql)
        {
            try
            {
                SqlCommand command = Connection.CreateCommand();
                command.CommandText = strSql;
                command.CommandType = cmdType;

                int nRow = (int)command.ExecuteScalar();
                return nRow;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        // Insert, Update, Delete
        // Dùng tham số
        public int ExecuteNonQuery(CommandType cmdType, string strSql, params SqlParameter[] parameters)
        {
            try
            {
                SqlCommand command = Connection.CreateCommand();
                command.CommandText = strSql;
                command.CommandType = cmdType;
                if (parameters != null && parameters.Length > 0)
                {
                    command.Parameters.AddRange(parameters);
                }

                int nRow = command.ExecuteNonQuery();
                return nRow;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        // select
        // Cach 1
        // return SqlDataReader
        public SqlDataReader GetReader(CommandType cmdType, string strSql)
        {
            try
            {
                SqlCommand command = Connection.CreateCommand();
                command.CommandText = strSql;
                command.CommandType = cmdType;

                return command.ExecuteReader();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        // select
        // Cach 2
        // return DataTable
        public DataTable Select(CommandType cmdType, string strSql)
        {
            try
            {
                SqlCommand command = Connection.CreateCommand();
                command.CommandText = strSql;
                command.CommandType = cmdType;

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }


        // select co tham so
        // return DataTable
        public DataTable Select(CommandType cmdType, string strSql, params SqlParameter[] parameters)
        {
            try
            {
                SqlCommand command = Connection.CreateCommand();
                command.CommandText = strSql;
                command.CommandType = cmdType;

                if (parameters != null && parameters.Length > 0)
                {
                    command.Parameters.AddRange(parameters);
                }

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
