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
        static char[] table = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        static string TaoMaDH()
        {
            string tmp = "";
            int n = DAL_DONDH.SoDongBangDonDH();
            int ntemp = n;
            while (ntemp != 0)
            {
                tmp += table[ntemp % 36].ToString();
                ntemp = ntemp / 36;
            }
            if (tmp.Equals("")) tmp = "0";
            return tmp;
        }

        public static string ThemGioHangVaoDonDH(DAO.GioHang gh, string makh)
        {
            

            string madh = TaoMaDH();
            try
            {
                DAL_DONDH.AddDonDH(madh, makh, DateTime.Now.ToString(), gh.ThanhTien, "0");

                foreach (DAO.LinhKien lk in gh.LinhKien)
                {
                    DAL.DAL_DONDH.AddCTDonDH(madh, lk.MaLK, lk.SoLuong, lk.DonGia);
                }
                return "Đặt mua hàng thành công";
            }
            catch (Exception ex)
            {
                return "Lỗi";
            }
        }

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
        public static int InsertDonDH(string madh, string makh, string ngaydh, int thanhtien, string tinhtrang)
        {
            return DAL.DAL_DONDH.AddDonDH(madh, makh, ngaydh, thanhtien,tinhtrang);
        }
        public static int InsertCTDonDH(string madh, string malk, int soluong, int dongiaban)
        {
            return DAL.DAL_DONDH.AddCTDonDH(madh, malk, soluong, dongiaban);
        }
    }
}
