using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class product : System.Web.UI.Page
{
    public string title = "";
    public DAO.LinhKien lk = new DAO.LinhKien();
    public DAO.NhaSX nhasx = new DAO.NhaSX();
    protected void Page_Load(object sender, EventArgs e)
    {
        string id = "";
        if (Request["id"] != null)
            id = Request["id"].ToString();
        lk = BLL.BLL_LinhKien.searchLK(id);
        if (lk.MaLK.Equals(""))
        {
            txtNoData.Text = "Không có sản phẩm này!";
            title = "Không có sản phẩm này!";
        }
        else
        {
            title = lk.TenLK;
            string mansx = lk.Mansx;
            nhasx = BLL.BLL_NHASX.NhaSX(mansx);
        }
    }
}