using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO
{
    public class PXuat
    {
        private string _maPX;

        public string MaPX
        {
            get { return _maPX; }
            set { _maPX = value; }
        }
        private DateTime _ngayXuat;

        public DateTime NgayXuat
        {
            get { return _ngayXuat; }
            set { _ngayXuat = value; }
        }
        private int _thanhTien;

        public int ThanhTien
        {
            get { return _thanhTien; }
            set { _thanhTien = value; }
        }
    }
}
