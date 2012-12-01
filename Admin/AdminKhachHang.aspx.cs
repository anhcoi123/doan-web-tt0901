using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

public partial class Admin_AdminKhachHang : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["admin"] == null)
            Response.Redirect("./AdminLogin.aspx");
        load.DataSource = BLL.BLL_KhachHang.DTGetAll();
        load.DataBind();
    }
    protected void btnThemKH_Click(object sender, EventArgs e)
    {
        Response.Redirect("./Admin/AdminKhachHang_ThemKH.aspx");
    }
}