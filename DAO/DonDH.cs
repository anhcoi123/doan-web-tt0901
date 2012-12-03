using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO
{
    public class DonDH
    {
        private string _maDH;

        public string MaDH
        {
            get { return _maDH; }
            set { _maDH = value; }
        }
        private string _maKH;

        public string MaKH
        {
            get { return _maKH; }
            set { _maKH = value; }
        }
        private string _ngayDH;

        public string NgayDH
        {
            get { return _ngayDH; }
            set { _ngayDH = value; }
        }
        private int _thanhTien;

        public int ThanhTien
        {
            get { return _thanhTien; }
            set { _thanhTien = value; }
        }
    }
}
