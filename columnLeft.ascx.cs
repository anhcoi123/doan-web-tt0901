using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

public partial class columnLeft : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        LoadLoaiLK.DataSource = BLL.BLL_LOAILK.DTTatCaLoaiLK();
        LoadLoaiLK.DataBind();
    }
}