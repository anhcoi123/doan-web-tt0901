﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DAO;

namespace DAL
{
    public static class DAL_LinhKien
    {
        private static string sqlTatCaLinhKien = "EXECUTE SP_TATCALK";
        
        private static string sqlDonGia = "SELECT DONGIA FROM LINHKIEN WHERE MALK=@MALK";
        private static string sqlAdd = "EXECUTE SP_THEMLK @MALK,@TENLK,@DVTINH,@SOLUONG,@DONGIA,@THONGTIN,@HINHANH,@MALOAILK,@MANSX";
        //private static string sqlUpdate = "UPDATE LINHKIEN SET TENLK=@TENLK,DVTINH=@DVTINH,SOLUONG=@SOLUONG,DONGIA=@DONGIA,THONGTIN=@THONGTIN,HINHANH=@HINHANH,MALOAILK=@MALOAILK WHERE MALK=@MALK";
        private static string sqlDelete = "DELETE FROM LINHKIEN WHERE MALK=@MALK";
        private static string sqlTimKiemMaLK = "EXECUTE SP_TIMLK_MALK @MALK";
        private static string sqlTimKiemMaLoaiLK = "SELECT * FROM LINHKIEN WHERE MALOAILK=@MALOAILK";
        
        private static string sqlTimKiemTenLK = "EXECUTE SP_TIMLK_TENLK @TENLK";
        private static string sqlTimKiemTenNSX = "EXECUTE SP_TIMLK_NHASX @TENNSX";
        private static string sql8LinhKienNgauNhien = "SELECT TOP 8 * FROM LINHKIEN ORDER BY NEWID()";
        private static string sqlUpdate = "UPDATE LINHKIEN SET TENLK=@TENLK,DONGIA=@DONGIA WHERE MALK=@MALK";

        
        

        public static DataTable DTTatCaLK_MaLoaiLK(string maloailk)
        {
            string[] paraName = new string[] { "@MALOAILK" };
            string[] paraValue = new string[] { maloailk };
            return DALClass.GetDataTable(sqlTimKiemMaLoaiLK, paraName, paraValue);
        }
        

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
            lk.SoLuong = int.Parse(dtLK.Rows[0]["SOLUONG"].ToString());
            lk.TenLK = dtLK.Rows[0]["TENLK"].ToString();
            lk.Mansx = dtLK.Rows[0]["MANSX"].ToString();
            lk.ThongTin = dtLK.Rows[0]["THONGTIN"].ToString();
            return lk;
        }

        public static int AddLK(string malk, string tenlk, string dvtinh, int soluong, int dongia, string thongtin, string hinhanh, string maloailk, string mansx)
        {
            string[] paraName = new string[] { "@MALK", "@TENLK", "@DVTINH", "@SOLUONG", "@DONGIA", "@THONGTIN", "@HINHANH", "@MALOAILK", "@MANSX" };
            object[] paraValue = new object[] { malk, tenlk, dvtinh, soluong, dongia, thongtin, hinhanh, maloailk, mansx };
            return DALClass.ExecNonQuery(sqlAdd, paraName, paraValue);
        }

        public static int UpdateLK(string malk,string tenlk, int dongia)
        {
            string[] paraName = new string[] {"@MALK", "@TENLK", "@DONGIA"};
            object[] paraValue = new object[] {malk, tenlk, dongia};
            return DALClass.ExecNonQuery(sqlUpdate, paraName, paraValue);
        }

        public static int XoaLK(string malk)
        {
            string[] paraName = new string[] { "@MALK" };
            object[] paraValue = new object[] { malk };
            return DALClass.ExecNonQuery(sqlDelete,paraName,paraValue);
        }

        public static DataTable TimLK_Malk(string malk)
        {
            string[] paraName = new string[] { "@MALK" };
            object[] paraValue = new object[] { malk };
            return DALClass.GetDataTable(sqlTimKiemMaLK, paraName, paraValue);
        }

        public static DataTable TimLK_TenLK(string tenlk)
        {
            string[] paraName = new string[] { "@TENLK" };
            object[] paraValue = new object[] { tenlk };
            return DALClass.GetDataTable(sqlTimKiemTenLK, paraName, paraValue);
        }
        public static DataTable TimLK_TenNSX(string tennsx)
        {
            string[] paraName = new string[] { "@TENNSX" };
            object[] paraValue = new object[] { tennsx };
            return DALClass.GetDataTable(sqlTimKiemTenNSX, paraName, paraValue);
        }
        
    }
}
