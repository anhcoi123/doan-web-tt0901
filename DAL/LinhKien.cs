using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO
{
    public class LinhKien
    {
        private string _maLK;
        public string MaLK
        {
            get { return _maLK; }
            set { _maLK = value; }
        }

        private string _tenLK;

        public string TenLK
        {
            get { return _tenLK; }
            set { _tenLK = value; }
        }

        private string _dVTinh;

        public string DVTinh
        {
            get { return _dVTinh; }
            set { _dVTinh = value; }
        }

        private int _soLuong;

        public int SoLuong
        {
            get { return _soLuong; }
            set { _soLuong = value; }
        }

        private int _donGia;

        public int DonGia
        {
            get { return _donGia; }
            set { _donGia = value; }
        }

        private string _thongTin;

        public string ThongTin
        {
            get { return _thongTin; }
            set { _thongTin = value; }
        }

        private string _hinhAnh;

        public string HinhAnh
        {
            get { return _hinhAnh; }
            set { _hinhAnh = value; }
        }
    }
}
