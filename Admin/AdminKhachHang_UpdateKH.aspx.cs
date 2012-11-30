using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAO;
using BLL;
using System.Data;
using System.Data.SqlClient;
public partial class Admin_AdminKhachHang_UpdateKH : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string MaKH = Request.QueryString["MAKH"];
        DataTable tb = BLL.BLL_KHACHHANG.searchKH(MaKH);
        lblMaKH.Text = MaKH;
        txtTenKH.Text = tb.Rows[0]["TENKH"].ToString();
        txtMatKhau.Text = tb.Rows[0]["MATKHAU"].ToString();
        txtDiaChi.Text = tb.Rows[0]["DIACHI"].ToString();
        txtSoDT.Text = tb.Rows[0]["SODT"].ToString();
        txtCMND.Text = tb.Rows[0]["CMND"].ToString();
        ddlRole.SelectedItem.Text = tb.Rows[0]["ROLE"].ToString();
    }
    protected void btnThem_Click(object sender, EventArgs e)
    {
        string strMaKH = lblMaKH.Text;
        string strTenKH = txtTenKH.Text;
        string strMatKhau = txtMatKhau.Text;
        string strDiaChi = txtDiaChi.Text;
        string strSoDT = txtSoDT.Text;
        string strCMND = txtCMND.Text;
        string strRole = ddlRole.SelectedItem.Text;

        int i = BLL.BLL_KHACHHANG.UpdateKH(strMaKH, strTenKH, strMatKhau, strDiaChi, strSoDT, strCMND, strRole);
        if (i != 0)
        {
            Response.Write("<script>alert('Cập Nhật Thành Công')</script>");

        }
        else
        {
            Response.Write("<script>alert('Cập Nhật Thất Bại')</script>");
        }
    }
}