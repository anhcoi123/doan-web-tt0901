using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;
using DAO;
namespace BLL
{
    public class BLL_ADMIN
    {
        public static Boolean KiemTraDN(string tendangnhap, string matkhau)
        {
            DataTable tb = DAL_Admin.KTDangNhap(tendangnhap, matkhau);
            if (tb.Rows.Count==0)
            {
                return false;
            }
            return true;
        }
        public static string LayTen(string tendangnhap)
        {
            string a = null;
            DataTable tb = new DataTable();
            tb = DAL_Admin.LayTenAdmin(tendangnhap);
            a = tb.Rows[0]["TENKH"].ToString();
            return a;
        }
    }
}
