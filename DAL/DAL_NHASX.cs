using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DAO;
namespace DAL
{
    public static class DAL_NHASX
    {
        private static string sqlNhaSX = "EXECUTE SP_NHASX";
        private static string sqlThemNSX = "EXECUTE SP_THEMNSX(@MANSX,@TENNSX)";
        private static string sqlUpdateTenNSX = "EXECUTE SP_UPDATETENNSX(@MANSX,@TENNSX)";

        public static DataTable DanhSachNSX()
        {
            return DALClass.GetDataTable(sqlNhaSX); 
        }
        public static int ThemNSX(string mansx, string tennsx)
        {
            string[] paraName= new string[] {"@MANSX","@TENNSX"};
            object[] paraValue= new object[] {mansx,tennsx};
            return DALClass.ExecNonQuery(sqlThemNSX, paraName, paraValue);
        }
        public static int UpdateTenNSX(string mansx, string tennsx)
        {
            string[] paraName = new string[] { "@MANSX","TENNSX" };
            object[] paraValue = new object[] { mansx, tennsx };
            return DALClass.ExecNonQuery(sqlUpdateTenNSX, paraName, paraValue);
        }

    }
}
