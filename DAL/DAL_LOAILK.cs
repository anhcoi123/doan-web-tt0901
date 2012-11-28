using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAO;

namespace DAL
{
    public static class DAL_LOAILK
    {
        private static string sqlTenLoaiLK = "EXEC SP_TATCALOAILK_TENLOAILK @MALOAILK";
        private static string sqlTatCaLoaiLK = "EXECUTE SP_TATCALOAILK";

        public static DataTable DTTatCaLoaiLK()
        {
            return DALClass.GetDataTable(sqlTatCaLoaiLK);
        }

        public static string TenLoaiLK_MALOAILK(string MaLoaiLK)
        {
            string[] paraName = new string[] { "@MaLoaiLK" };
            string[] paraValue = new string[] { MaLoaiLK };
            DataTable dtLK = DALClass.GetDataTable(sqlTenLoaiLK, paraName, paraValue);
            if (dtLK.Rows.Count == 0)
                return "Không tìm thấy loại linh kiện";
            else
                return dtLK.Rows[0]["TENLOAILK"].ToString();
        }
    }
}
