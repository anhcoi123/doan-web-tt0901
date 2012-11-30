using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO
{
    class NhaCC
    {
        private string _maNCC;

        public string MaNCC
        {
            get { return _maNCC; }
            set { _maNCC = value; }
        }
        private string _tenNCC;

        public string TenNCC
        {
            get { return _tenNCC; }
            set { _tenNCC = value; }
        }
        private string _diaChi;

        public string DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }
        private string _soDT;

        public string SoDT
        {
            get { return _soDT; }
            set { _soDT = value; }
        }

    }
}
