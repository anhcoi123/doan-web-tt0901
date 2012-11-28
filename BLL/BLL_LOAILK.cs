using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;

namespace BLL
{
    public static class BLL_LOAILK
    {
        public static DataTable DTTatCaLoaiLK()
        {
            return DAL.DAL_LOAILK.DTTatCaLoaiLK();
        }

        public static string TenLoaiLK_MALOAILK(string MaLoaiLK)
        {
            return DAL.DAL_LOAILK.TenLoaiLK_MALOAILK(MaLoaiLK);
        }

    }
}
