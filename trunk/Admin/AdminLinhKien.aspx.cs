using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using DAL;

public partial class Admin_AdminLinhKien : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["admin"] == null)
            Response.Redirect("./AdminLogin.aspx");
        load.DataSource = BLL_LinhKien.DTGetAll();
        load.DataBind();
    }
    protected void btnThemLK_Click(object sender, EventArgs e)
    {
        Response.Redirect("../Admin/AdminLinhKien_ThemLK.aspx");
    }
}