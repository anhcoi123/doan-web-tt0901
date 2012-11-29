using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO
{
    public class Admin
    {
        private static string _makh;

        public static string Makh
        {
            get { return Admin._makh; }
            set { Admin._makh = value; }
        }
        private static string _tenkh;

        public static string Tenkh
        {
            get { return Admin._tenkh; }
            set { Admin._tenkh = value; }
        }
        private static string _tendangnhap;

        public static string Tendangnhap
        {
            get { return Admin._tendangnhap; }
            set { Admin._tendangnhap = value; }
        }
        private static string _matkhau;

        public static string Matkhau
        {
            get { return Admin._matkhau; }
            set { Admin._matkhau = value; }
        }
        private static string _diachi;

        public static string Diachi
        {
            get { return Admin._diachi; }
            set { Admin._diachi = value; }
        }
        private static int _sodt;

        public static int Sodt
        {
            get { return Admin._sodt; }
            set { Admin._sodt = value; }
        }
        private static string _cmnd;

        public static string Cmnd
        {
            get { return Admin._cmnd; }
            set { Admin._cmnd = value; }
        }
        private static string role;

        public static string Role
        {
            get { return Admin.role; }
            set { Admin.role = value; }
        }


    }
}
