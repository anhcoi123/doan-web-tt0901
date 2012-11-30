using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using DAO;
using BLL;

public partial class Admin_AdminLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["ID"] != null)
        {
            Response.Redirect("./Admin/AdminPage.aspx?DaDangNhap=in");
        }
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        if (BLL_ADMIN.KiemTraDN(txtID.Text, txtPass.Text))
        {
            Session["ID"] = txtID.Text;
            Session["Pass"] = txtPass.Text;
            Session["Admin"] = "true";
            Response.Redirect("../Admin/AdminPage.aspx?TenDN="+txtID.Text+"&i=login");

        }
        else
        {
            lblError.Text = "Mật khẩu hoặc tài khoản không đúng";
        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        txtID.Text = "";
        txtPass.Text = "";
    }
}