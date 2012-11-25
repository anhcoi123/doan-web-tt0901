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
    }
}
