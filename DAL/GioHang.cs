using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO
{
    public class GioHang
    {
        private List<LinhKien> _linhKien = new List<LinhKien>();

        public List<LinhKien> LinhKien
        {
            get { return _linhKien; }
            set { _linhKien = value; }
        }
        private int _thanhTien = 0;

        public int ThanhTien
        {
            get { return _thanhTien; }
            set { _thanhTien = value; }
        }
    }
}
