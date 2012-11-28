using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DAL;
namespace BLL
{
    public static class BLL_DONDH
    {
        public static List<DAO.DonDH> DBDONDH(DataTable tb)
        {
            List<DAO.DonDH> DB = new List<DAO.DonDH>();
            foreach (DataRow a in tb.Rows)
            {
                DB.Add(new DAO.DonDH()
                {
                    MaDH = a["@MADH"].ToString(),
                    MaKH = a["@MAKH"].ToString(),
                    NgayDH =DateTime.Parse( a["@NGAYKH"].ToString()),
                    ThanhTien =int.Parse(a["@THANHTIEN"].ToString())
                });
            }
            return DB;
        }
        public static List<DAO.CTDonDH> DBCTDONDH(DataTable tb)
        {
            List<DAO.CTDonDH> DB = new List<DAO.CTDonDH>();
            foreach (DataRow a in tb.Rows)
            {
                DB.Add(new DAO.CTDonDH
                   {
                       MaDH = a["@MADH"].ToString(),
                       MaLK = a["@MALK"].ToString(),
                       SoLuong = int.Parse(a["@SOLUONG"].ToString()),
                       DonGiaBan = int.Parse(a["@DONGIABAN"].ToString())
                   });
            }
            return DB;
        }
        public static int InsertDonDH(string madh, string makh, DateTime ngaydh, int thanhtien)
        {
            return DAL.DAL_DONDH.AddDonDH(madh, makh, ngaydh, thanhtien);
        }
        public static int InsertCTDonDH(string madh, string malk, int soluong, int dongiaban)
        {
            return DAL.DAL_DONDH.AddCTDonDH(madh, malk, soluong, dongiaban);
        }
    }
}
