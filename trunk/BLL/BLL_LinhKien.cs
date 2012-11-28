using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DAL;
namespace BLL
{
    public static class BLL_LinhKien
    {
       public static DataTable GetAll()
       {
            return DAL.LinhKien.GetallProducts();
       }
       public static DataTable Get8()
       {
           return DAL.LinhKien.Get8Products();
       }
       public static DAO.LinhKien searchLK(string id)
       {
           return DAL.LinhKien.searchLK(id);
       }
       public static List<DAO.LinhKien> DBLK(DataTable tb)
       {
           List<DAO.LinhKien> DB = new List<DAO.LinhKien>();
           foreach(DataRow a in tb.Rows)
           {
               DB.Add(new DAO.LinhKien()
               {
                   MaLK = a["MALK"].ToString(),
                   TenLK = a["TENLK"].ToString(),
                   DVTinh=a["DVTINH"].ToString(),
                   SoLuong = int.Parse(a["SOLUONG"].ToString()),
                   DonGia= int.Parse(a["DONGIA"].ToString()),
                   ThongTin=a["THONGTIN"].ToString(),
                   HinhAnh=a["HINHANH"].ToString(),
                   Maloailk=a["MALOAILK"].ToString(),
                   Mansx=a["MANSX"].ToString()
               });

           }
           return DB;
       }
        public static int InsertLK(string malk,string tenlk, int dvtinh,int soluong,int dongia,string thongtin,string hinhanh,string maloailk,string mansx )
        {
            return DAL.LinhKien.AddLK(malk,tenlk,dvtinh,soluong,dongia,thongtin,hinhanh,maloailk,mansx);
        }
        public static DataTable SearchLK_MALK(string malk)
        {
            return DAL.LinhKien.TimLK_Malk(malk);
        }
        public static DataTable SearchLK_TENLK(string tenlk)
        {
            return DAL.LinhKien.TimLK_TenLK(tenlk);
        }
        public static DataTable SearchLK_TENNSX(string tennsx)
        {
            return DAL.LinhKien.TimLK_TenNSX(tennsx);
        }

    }
}
