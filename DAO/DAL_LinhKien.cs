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
        private static string sqlTimKiemMaLK = "SELECT * FROM LINHKIEN WHERE MALK=@MALK";
        private static string sqlTimKiemMaLoaiLK = "SELECT * FROM LINHKIEN WHERE MALOAILK=@MALOAILK";
        private static string sqlTimKiemTenLK = "SELECT  * FROM LINHKIEN WHERE TENLK LIKE @TENLK";
        private static string sql8LinhKienNgauNhien = "SELECT TOP 8 * FROM LINHKIEN ORDER BY NEWID()";

        public static DataTable Get8Products()
        {
            return DALClass.GetDataTable(sql8LinhKienNgauNhien);
        }

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

        public static DAO.LinhKien searchLK(string id)
        {
            string[] paraName = new string[] { "@MaLK" };
            string[] paraValue = new string[] { id };
            DataTable dtLK = DALClass.GetDataTable(sqlTimKiemMaLK, paraName, paraValue);
            DAO.LinhKien lk = new DAO.LinhKien();
            lk.DonGia = int.Parse(dtLK.Rows[0]["DONGIA"].ToString());
            lk.DVTinh = dtLK.Rows[0]["DVTinh"].ToString();
            lk.HinhAnh = dtLK.Rows[0]["HINHANH"].ToString();
            lk.MaLK = dtLK.Rows[0]["MALK"].ToString();
            lk.SoLuong = 1;
            lk.TenLK = dtLK.Rows[0]["TENLK"].ToString();
            lk.ThongTin = dtLK.Rows[0]["THONGTIN"].ToString();
            return lk;
        }

        //public static int InsertProduct(string malk, string tenlk, string dvtinh, int soluong, int dongia, string thongtin, string hinhanh, string maloailk)
        //{   
            
        //}
    }
}
