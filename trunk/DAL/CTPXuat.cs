using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO
{
    public class CTPXuat
    {
        private string _maPX;

        public string MaPX
        {
            get { return _maPX; }
            set { _maPX = value; }
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
        private int _donGiaXuat;

        public int DonGiaXuat
        {
            get { return _donGiaXuat; }
            set { _donGiaXuat = value; }
        }

    }
}
