﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO
{
    class KhachHang
    {
        private string _maKH;

        public string MaKH
        {
            get { return _maKH; }
            set { _maKH = value; }
        }
        private string _tenKH;

        public string TenKH
        {
            get { return _tenKH; }
            set { _tenKH = value; }
        }
        private string _tenDangNhap;

        public string TenDangNhap
        {
            get { return _tenDangNhap; }
            set { _tenDangNhap = value; }
        }
        private string _matKhau;

        public string MatKhau
        {
            get { return _matKhau; }
            set { _matKhau = value; }
        }
        private string _diaChi;

        public string DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }
        private int _soDT;

        public int SoDT
        {
            get { return _soDT; }
            set { _soDT = value; }
        }

    }
}
