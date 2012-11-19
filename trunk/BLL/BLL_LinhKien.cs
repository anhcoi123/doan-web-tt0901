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
       public static DataTable Get10()
       {
           return DAL.LinhKien.Get10Products();
       }
    }
}
