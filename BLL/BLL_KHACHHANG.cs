using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;
namespace BLL
{
    public static class BLL_KhachHang
    {
        static char[] table = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        static string TaoMaKH()
        {
            string tmp = "";
            int n = DAL_KhachHang.SoDongBangKH();
            int ntemp=n;
            while (ntemp != 0)
            {
                tmp += table[ntemp % 36 - 1].ToString();
                ntemp = ntemp / 36;
            }

            return tmp;
        }

        public static DAO.KhachHang KTraDangNhap(string tendangnhap, string matkhau)
        {
            DataTable dt = DAL_KhachHang.DTDanhSachKH();
            DAO.KhachHang kh=new DAO.KhachHang();
            foreach (DataRow r in dt.Rows)
            {
                if (r["TENDANGNHAP"].ToString().Trim().Equals(tendangnhap) && r["MATKHAU"].ToString().Trim().Equals(matkhau))
                {
                    kh.CMND = r["CMND"].ToString().Trim();
                    kh.DiaChi = r["DIACHI"].ToString().Trim();
                    kh.MaKH = r["MAKH"].ToString().Trim();
                    kh.MatKhau = r["MATKHAU"].ToString().Trim();
                    kh.SoDT = r["SODT"].ToString().Trim();
                    kh.TenDangNhap = tendangnhap;
                    kh.TenKH = r["TENKH"].ToString().Trim();
                    return kh;
                }
            }
            return null;
        }

        public static string ThemKH(string tenkh, string tendn, string matkhau, string diachi, string sodt, string cmnd)
        {
            string makh=TaoMaKH();
            DataTable dt = DAL_KhachHang.DTDanhSachKH();
            foreach (DataRow r in dt.Rows)
            {
                if (r["TENDANGNHAP"].ToString().Trim().Equals(tendn))
                    return "Lỗi: Đã có người sử dụng tên đăng nhập này, vui lòng chọn tên đăng nhập khác";
                if (r["CMND"].ToString().Trim().Equals(cmnd))
                    return "Lỗi: Đã có người sử dụng số CMND này, vui lòng kiểm tra lại";
            }
            return DAL_KhachHang.ThemKH(makh, tenkh, tendn, matkhau, diachi, sodt, cmnd, "0")==1?"Đã tạo thành công tài khoản":"Lỗi: Không thể tạo tài khoản";
        }
    }
}
