using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DAL;

namespace DAL
{
    public class DAL_Admin
    {
        private static string sqlLayMK = "SELECT MATKHAU FROM KHACHHANG WHERE TENDANGNHAP=@TENDANGNHAP ";
        private static string sqlLayRole = "SELECT ROLE FROM KHACHHANG WHERE TENDANGNHAP=@TENDANGNHAP";
        private static string sqlKTDangNhap="SELECT * FROM KHACHHANG WHERE TENDANGNHAP=@TENDANGNHAP AND MATKHAU=@MATKHAU AND ROLE=1" ;
        private static string sqlLayTen = "SELECT TENKH FROM KHACHHANG WHERE TENDANGNHAP=@TENDANGNHAP AND ROLE=1";


        public static DataTable LayMatKhau(string TENDANGNHAP)
        {
            string[] paraName = new string[] { "TENDANGNHAP" };
            object[] paraValue = new object[] { TENDANGNHAP };
            return DALClass.GetDataTable(sqlLayMK, paraName, paraValue); 
        }

        public static DataTable LayRole(string ROLE)
        {
            string[] paraName= new string[] {"ROLE"};
            object[] paraValue= new object[] {ROLE};
            return DALClass.GetDataTable(sqlLayRole, paraName, paraValue);
        }

        public static DataTable KTDangNhap(string TENDANGNHAP, string MATKHAU)
        {
            string[] paraName = new string[] { "TENDANGNHAP,MATKHAU" };
            object[] paraValue = new object[] { TENDANGNHAP, MATKHAU};
            return DALClass.GetDataTable(sqlKTDangNhap, paraName, paraValue);
        }

        public static DataTable LayTenAdmin(string TENDANGNHAP)
        {
            string[] paraName = new string[] { "TENDANGNHAP" };
            object[] paraValue = new object[] { TENDANGNHAP };
            return DALClass.GetDataTable(sqlLayTen, paraName, paraValue);
        }
    }
}
