using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DAO;

namespace DAL
{
    public static class LinhKien
    {
        private static string sqlTatCaLinhKien = "SELECT * FROM LINHKIEN";
        private static string sqlDonGia = "SELECT DONGIA FROM LINHKIEN WHERE MALK=@MALK";
        private static string sqlAdd = "INSERT INTO LINHKIEN VALUES(@MALK,@TENLK,@DVTINH,@SOLUONG,@DONGIA,@THONGTIN,@HINHANH,@MALOAILK)";
        private static string sqlUpdate = "UPDATE LINHKIEN SET TENLK=@TENLK,DVTINH=@DVTINH,SOLUONG=@SOLUONG,DONGIA=@DONGIA,THONGTIN=@THONGTIN,HINHANH=@HINHANH,MALOAILK=@MALOAILK WHERE MALK=@MALK";
        private static string sqlDelete = "DELETE FROM LINHKIEN WHERE MALK=@MALK";
        private static string sqlTimKimMaLK = "SELECT * FROM LINHKIEN WHERE MALK=@MALK";
        private static string sqlTimKimMaLoaiLK = "SELECT * FROM LINHKIEN WHERE MALOAILK=@MALOAILK";
        private static string sqlTimKiemTenLK = "SELECT  * FROM LINHKIEN WHERE TENLK LIKE @TENLK";


        public static DataTable GetallProducts()
        {
            return DALClass.GetDataTable(sqlTatCaLinhKien);
        }
        public static DataTable GetPrice(string id)
        {
            string[] paraName = new string[] { "@MaLK" };
            string[] paraValue = new string[] { id };
            return DALClass.GetDataTable(sqlDonGia, paraName, paraValue);
        }
        //public static int InsertProduct(string malk, string tenlk, string dvtinh, int soluong, int dongia, string thongtin, string hinhanh, string maloailk)
        //{   
            
        //}
    }
}
