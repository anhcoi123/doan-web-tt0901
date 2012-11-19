using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    class PhieuNhap
    {
        private string _maPN;

        public string MaPN
        {
            get { return _maPN; }
            set { _maPN = value; }
        }
        private DateTime _ngayNhap;

        public DateTime NgayNhap
        {
            get { return _ngayNhap; }
            set { _ngayNhap = value; }
        }
        private string _maNCC;

        public string MaNCC
        {
            get { return _maNCC; }
            set { _maNCC = value; }
        }
        private int _thanhTien;

        public int ThanhTien
        {
            get { return _thanhTien; }
            set { _thanhTien = value; }
        }
    }
}
