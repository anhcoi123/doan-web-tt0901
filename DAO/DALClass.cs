using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DAO;

namespace DAL
{
    class DALClass
    {
        private static string sqlConnectionString = @"Data Source=.\SQLEXPRESS;Database=QLBANHANG;Trusted_Connection=True;";
        private static SqlConnection sqlConnection = new SqlConnection(sqlConnectionString);

        #region Open/Close Connection

        private static bool OpenConnection()
        {
            if (sqlConnection.State == ConnectionState.Closed)
            {
                try
                {
                    sqlConnection.Open();
                    return true;
                }
                catch { return false; }
            }
            return true;
        }
        private static bool CloseConnection()
        {
            if (sqlConnection.State == ConnectionState.Open)
            {
                try
                {
                    sqlConnection.Close();
                    return true;
                }
                catch { return false; }
            }
            return true;
        }

        #endregion


        #region Methods

        public static DataTable GetDataTable(string sqlstring, string[] paraName, object[] paraValue)
        {
            OpenConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sqlstring;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection;

            AddPara(ref cmd, ref paraName, ref paraValue);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            return tb;
        }

        public static DataTable GetDataTable(string sqlString)
        {
            OpenConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sqlString;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            return tb;
        }

        public static int ExecNonQuery(string sqlString, string[] paraName, object[] paraValue)
        {
            OpenConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            cmd.CommandText = sqlString;
            cmd.CommandType = CommandType.Text;

            AddPara(ref cmd, ref paraName, ref paraValue);
            return cmd.ExecuteNonQuery();
        }

        private static void AddPara(ref SqlCommand cmd, ref string[] paraName, ref object[] pavaValue)
        {
            int j = pavaValue.Length;
            for (int i = 0; i < j; i++)
            {
                cmd.Parameters.AddWithValue(paraName[i], pavaValue[i]);
            }
        }

        #endregion
    }
}
