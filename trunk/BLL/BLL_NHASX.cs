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
        public static List<DAO.NhaSX> DanhSachNSX()
        {
            DataTable tb = DAL_NHASX.DanhSachNSX();
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

        public static DataTable DTDanhSachNSX()
        {
            return DAL_NHASX.DanhSachNSX();
        }

        public static DAO.NhaSX NhaSX(string mansx)
        {
            DAO.NhaSX nsx = new DAO.NhaSX();
            DataTable dt = DAL_NHASX.DTTimNSX(mansx);
            if (dt.Rows.Count != 0)
            {
                nsx.Mansx = dt.Rows[0]["MaNSX"].ToString();
                nsx.Tennsx = dt.Rows[0]["TenNSX"].ToString();
            }
            return nsx;
        }

        public static string TenNhaSX(string mansx)
        {
            DAO.NhaSX nsx = new DAO.NhaSX();
            DataTable dt = DAL_NHASX.DTTimNSX(mansx);
            if (dt.Rows.Count != 0)
            {
                nsx.Tennsx = dt.Rows[0]["TenNSX"].ToString();
                return nsx.Tennsx;
            }
            return "Không tìm thấy nhà sản xuất";
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
