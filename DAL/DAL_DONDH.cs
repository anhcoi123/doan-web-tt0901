using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DAO;

/// <summary>
/// Summary description for DAL_DONDH
/// </summary>
namespace DAL
{
    public static class DAL_DONDH
    {
        private static string sqlThemDonDH = "EXECUTE SP_THEMDONDH(@MADH,@MAKH,@NGAYDH,@THANHTIEN)";
        private static string sqlThemCTDonDH = "EXECUTE SP_THEMCTDONDH(@MADH,@MALK,@SOLUONG,@DONGIABAN)";
        
        public static int AddDonDH(string madh, string makh, DateTime ngaydh, int thanhtien)
        {
            string[] paraName = new string[] { "@MADH", "@MAKH", "NGAYDH", "THANHTIEN" };
            object[] paraValue = new object[] { madh, makh, ngaydh, thanhtien };
            
            return DALClass.ExecNonQuery(sqlThemDonDH,paraName,paraValue);
        }
        public static int AddCTDonDH(string madh, string malk, int soluong, int dongiaban)
        {
            string[] paraName = new string[] { "@MADH", "@MALK", "@SOLUONG", "@DONGIABAN" };
            object[] paraValue = new object[] { madh, malk, soluong, dongiaban };
            return DALClass.ExecNonQuery(sqlThemCTDonDH, paraName, paraValue);
        }
        public static void ThemGioHangVaoDonDH(DAO.GioHang gh,string madh)
        {
            foreach (DAO.LinhKien lk in gh.LinhKien)
            {
                AddCTDonDH(madh, lk.MaLK, lk.SoLuong, lk.DonGia);

            }
        }
        
    }
}