using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using DAO;
using System.Data;
using System.Data.SqlClient;
namespace BLL
{
    public class BLL_KHACHHANG
    {
        public static DataTable DTGetALL()
        {
            return DAL.DAL_KHACHHANG.DTTatCaUser();
        }

        public static List<DAO.KhachHang> DBKH()
        {
            DataTable tb = DTGetALL();
            List<DAO.KhachHang> DB = new List<DAO.KhachHang>();
            foreach (DataRow a in tb.Rows)
            {
                DB.Add(new DAO.KhachHang()
                {
                    MaKH= a["MAKH"].ToString(),
                    TenKH=a["TENKH"].ToString(),
                    TenDangNhap=a["TENDANGNHAP"].ToString(),
                    MatKhau=a["MATKHAU"].ToString(),
                    DiaChi=a["DIACHI"].ToString(),
                    SoDT=a["SODT"].ToString(),
                    CMND=a["CMND"].ToString(),
                    Role=a["ROLE"].ToString()
                });
                              
                
            }
            return DB;
        }

        public static int InsertKH(string makh, string tenkh, string tendangnhap, string matkhau,string diachi, string sodt, string cmnd, string role)
        {
            return DAL_KHACHHANG.InsertKH(makh, tenkh, tendangnhap, matkhau, diachi, sodt, cmnd, role);
        }
        public static int UpdateKH(string makh, string tenkh, string matkhau, string diachi, string sodt, string cmnd, string role)
        {
            return DAL_KHACHHANG.UpdateKH(makh, tenkh, matkhau, diachi, sodt, cmnd, role);
        }
        public static DataTable searchKH(string id)
        {
            return DAL.DAL_KHACHHANG.searchKH(id);
        }
    }
}
