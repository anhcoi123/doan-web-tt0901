using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class DAL_KHACHHANG
    {
        private static string sqlKhachHang = "EXEC SP_KHACHHANG";
        private static string sqlInsert = "EXEC SP_KHACHHANG_THEMKH @MAKH,@TENKKH,@TENDANGNHAP,@MATKHAU,@DIACHI,@SODT,@CMND,@ROLE";
        private static string sqlUpdate = "UPDATE KHACHHANG SET TENKH=@TENKH,MATKHAU=@MATKHAU,DIACHI=@DIACHI,SODT=@SODT,CMND=@CMND,ROLE=@ROLE WHERE MAKH=@MAKH";
        private static string sqlSearchKH_MAKH = "EXEC SP_TIMKHACHHANG_MAKH @MAKH";
        private static string sqlDanhSachKH1 = "SELECT * FROM KHACHHANG";
        private static string sqlDanhSachKH = "SELECT * FROM KHACHHANG WHERE ROLE='0'";


        public static DataTable DTDanhSachKH()
        {
            return DALClass.GetDataTable(sqlDanhSachKH);
        }
        public static int SoDongBangKH()
        {
            return DALClass.GetDataTable(sqlDanhSachKH1).Rows.Count;
        }

        public static DataTable DTTatCaUser()
        {
            return DALClass.GetDataTable(sqlKhachHang);
        }

        public static int InsertKH(string makh, string tenkh, string tendn, string matkhau, string diachi, string sodt, string cmnd, string role)
        {
            string[] paraName = new string[] { "@MAKH", "@TENKH", "@TENDANGNHAP", "@MATKHAU", "@DIACHI", "@SODT", "@CMND", "@ROLE" };
            object[] paraValue = new object[] { makh, tenkh, tendn, matkhau, diachi, sodt, cmnd, role };
            return DALClass.ExecNonQuery(sqlInsert, paraName, paraValue);
        }
        public static int UpdateKH(string makh, string tenkh, string matkhau, string diachi, string sodt, string cmnd, string role)
        {
            string[] paraName = new string[] { "@MAKH", "@TENKH", "@MATKHAU", "@DIACHI", "@SODT", "@CMND", "@ROLE" };
            object[] paraValue = new object[] { makh, tenkh, matkhau, diachi, sodt, cmnd, role };
            return DALClass.ExecNonQuery(sqlUpdate, paraName, paraValue);
        }

        public static DAO.KhachHang searchKH(string id)
        {
            string[] paraName = new string[] { "@MAKH" };
            string[] paraValue = new string[] { id };
            DataTable dtKH = DALClass.GetDataTable(sqlSearchKH_MAKH, paraName, paraValue);
            DAO.KhachHang kh = new DAO.KhachHang();
            kh.TenKH = dtKH.Rows[0]["TENKH"].ToString();
            kh.MatKhau = dtKH.Rows[0]["MATKHAU"].ToString();
            kh.DiaChi = dtKH.Rows[0]["DIACHI"].ToString();
            kh.SoDT = dtKH.Rows[0]["SODT"].ToString();
            kh.CMND = dtKH.Rows[0]["CMND"].ToString();
            kh.Role = dtKH.Rows[0]["ROLE"].ToString();
            return kh;
        }

        public static DataTable TimKH_MaKH(string makh)
        {
            string[] paraName = new string[] { "@MAKH" };
            object[] paraValue = new object[] { makh };
            return DALClass.GetDataTable(sqlUpdate, paraName, paraValue);
        }

    }
}
