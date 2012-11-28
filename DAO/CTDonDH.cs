using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO
{
    public class CTDonDH
    {
        private string _maDH;

        public string MaDH
        {
            get { return _maDH; }
            set { _maDH = value; }
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
        private int _donGiaBan;

        public int DonGiaBan
        {
            get { return _donGiaBan; }
            set { _donGiaBan = value; }
        }

    }
}
