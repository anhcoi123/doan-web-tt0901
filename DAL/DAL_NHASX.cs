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
        private static string sqlThemNSX = "EXECUTE SP_THEMNSX @MANSX,@TENNSX";
        private static string sqlUpdateTenNSX = "EXECUTE SP_UPDATETENNSX @MANSX,@TENNSX";
        private static string sqlTimTenNSX_MANSX = "EXEC SP_TIMNSX_MANSX @MANSX";

        public static DataTable DanhSachNSX()
        {
            return DALClass.GetDataTable(sqlNhaSX); 
        }

        public static DataTable DTTimNSX(string mansx)
        {
            string[] paraName = new string[] { "@MANSX"};
            string[] paraValue = new string[] { mansx};
            return DALClass.GetDataTable(sqlTimTenNSX_MANSX, paraName, paraValue);
        }

        public static int ThemNSX(string mansx, string tennsx)
        {
            string[] paraName= new string[] {"@MANSX","@TENNSX"};
            string[] paraValue = new string[] { mansx, tennsx };
            return DALClass.ExecNonQuery(sqlThemNSX, paraName, paraValue);
        }
        public static int UpdateTenNSX(string mansx, string tennsx)
        {
            string[] paraName = new string[] { "@MANSX","TENNSX" };
            string[] paraValue = new string[] { mansx, tennsx };
            return DALClass.ExecNonQuery(sqlUpdateTenNSX, paraName, paraValue);
        }

    }
}
