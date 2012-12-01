using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;
public partial class Admin_AdminLinhKien_XoaLK : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["admin"] == null)
            Response.Redirect("./AdminLogin.aspx");
        if (IsPostBack)
        {
            string MaLK="";
            if (Request.QueryString["MALK"] != null)
                MaLK = Request.QueryString["MALK"];
            if (MaLK.Equals(""))
                return;
            int result = BLL.BLL_LinhKien.DeleteLK(MaLK);
            Response.Redirect("./AdminPage.aspx");
 
        }
    }
}