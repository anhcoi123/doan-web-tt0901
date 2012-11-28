using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DAL;
namespace BLL
{
    public static class BLL_NHASX
    {
        public static List<DAO.NhaSX> DBNSX(DataTable tb)
        {
            List<DAO.NhaSX> DB = new List<DAO.NhaSX>();
            foreach (DataRow a in tb.Rows)
            {
                DB.Add(new DAO.NhaSX()
                 {
                     Mansx = a["MANSX"].ToString(),
                     Tennsx = a["TENNSX"].ToString()
                 });
            }
            return DB;
        }
        public static DataTable NhaSX()
        {
            return DAL.DAL_NHASX.TenNSX();
        }
        public static int ThemNSX(string mansx,string tennsx)
        {
            return DAL.DAL_NHASX.ThemNSX(mansx, tennsx);
        }
        public static int UpdateTenNSX(string mansx, string tennsx)
        {
            return DAL.DAL_NHASX.UpdateTenNSX(mansx, tennsx);
        }
    }
}
