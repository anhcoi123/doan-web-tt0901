using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAO;
using DAL;
using BLL;
public partial class Admin_AdminKhachHang_ThemKH : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnThem_Click(object sender, EventArgs e)
    {
        DAO.KhachHang kh = new KhachHang();
        kh.MaKH = txtMaKH.Text;
        kh.TenKH = txtTenKH.Text;
        kh.TenDangNhap = txtTenDangNhap.Text;
        kh.MatKhau = txtMatKhau.Text;
        kh.DiaChi = txtDiaChi.Text;
        kh.SoDT = txtSoDT.Text;
        kh.CMND = txtCMND.Text;
        kh.Role = ddlRole.SelectedItem.Text;
        BLL.BLL_KHACHHANG.InsertKH(kh.MaKH, kh.TenKH, kh.TenDangNhap, kh.MatKhau, kh.DiaChi, kh.SoDT, kh.CMND, kh.Role);
    }
}