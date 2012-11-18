using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO
{
    public class CTPNhap
    {
        private string _maPN;

        public string MaPN
        {
            get { return _maPN; }
            set { _maPN = value; }
        }
        private string _maLK;

        public string MaLK
        {
            get { return _maLK; }
            set { _maLK = value; }
        }
        private int _soLuong;

        public int SoLuong
        {
            get { return _soLuong; }
            set { _soLuong = value; }
        }
        private int _donGiaNhap;

        public int DonGiaNhap
        {
            get { return _donGiaNhap; }
            set { _donGiaNhap = value; }
        }
    }
}
