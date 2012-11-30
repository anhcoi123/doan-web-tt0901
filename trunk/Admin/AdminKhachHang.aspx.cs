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
        load.DataSource = BLL.BLL_KHACHHANG.DTGetALL();
        load.DataBind();
    }
    protected void btnThemKH_Click(object sender, EventArgs e)
    {
        Response.Redirect("./Admin/AdminKhachHang_ThemKH.aspx");
    }
}