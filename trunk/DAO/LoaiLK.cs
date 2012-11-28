using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO
{
    public class LoaiLK
    {
        private string _maLoaiLK;

        public string MaLoaiLK
        {
            get { return _maLoaiLK; }
            set { _maLoaiLK = value; }
        }
        private string _tenLoaiLK;

        public string TenLoaiLK
        {
            get { return _tenLoaiLK; }
            set { _tenLoaiLK = value; }
        }
    }
}
