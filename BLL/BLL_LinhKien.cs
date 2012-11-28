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
       public static DataTable DTGetAll()
       {
            return DAL.LinhKien.GetallProducts();
       }

       public static DataTable DTTatCaLoaiLK()
       {
           return DAL.LinhKien.DTTatCaLoaiLK();
       }

       public static DataTable DTGet8()
       {
           return DAL.LinhKien.Get8Products();
       }

       public static List<DAO.LinhKien> DBLK()
       {
           DataTable tb=DTGetAll();
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

        public static DAO.LinhKien searchLK(string id)
        {
            return DAL.LinhKien.searchLK(id);
        }

        public static DataTable DTSearchLK_MALK(string malk)
        {
            return DAL.LinhKien.TimLK_Malk(malk);
        }

        public static DataTable DTSearchLK_TENLK(string tenlk)
        {
            return DAL.LinhKien.TimLK_TenLK(tenlk);
        }

        public static DAO.LinhKien SearchLK_TENLK(string tenlk)
        {
            DAO.LinhKien lk = new DAO.LinhKien();
            DataTable dtLK=DTSearchLK_TENLK(tenlk);
            lk.DonGia = int.Parse(dtLK.Rows[0]["DONGIA"].ToString());
            lk.DVTinh = dtLK.Rows[0]["DVTinh"].ToString();
            lk.HinhAnh = dtLK.Rows[0]["HINHANH"].ToString();
            lk.MaLK = dtLK.Rows[0]["MALK"].ToString();
            lk.SoLuong = int.Parse(dtLK.Rows[0]["SOLUONG"].ToString());
            lk.TenLK = dtLK.Rows[0]["TENLK"].ToString();
            lk.ThongTin = dtLK.Rows[0]["THONGTIN"].ToString();
            return lk;

        }
        public static DataTable SearchLK_TENNSX(string tennsx)
        {
            return DAL.LinhKien.TimLK_TenNSX(tennsx);
        }

    }
}
