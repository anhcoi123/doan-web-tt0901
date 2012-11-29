using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class manufacturer : System.Web.UI.Page
{
    public string title = "";
    private DataTable dt = new DataTable();
    private string mansx = "";
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Request["mansx"] != null)
            mansx = Request["mansx"].ToString();
        title = BLL.BLL_NHASX.NhaSX(mansx).Tennsx;
        if (title.Equals("Không tìm thấy nhà sản xuất"))
            txtNoData.Text = "Không tìm thấy nhà sản xuất";
        else
        {
            dt = BLL.BLL_LinhKien.SearchLK_TENNSX(title);
            LoadManufactuter.DataSource = dt;
            LoadManufactuter.DataBind();
            if (LoadManufactuter.Items.Count == 0)
                txtNoData.Text = "Không có sản phẩm nào của nhà sản xuất này!";
        }
    }
    protected void sortList_SelectedIndexChanged(object sender, EventArgs e)
    {
        string defaultview = "MALK ASX";
        string az = "TENLK ASC";
        string za = "TENLK DESC";
        string hl = "DONGIA DESC";
        string lh = "DONGIA ASC";
        string sort = defaultview;
        switch (sortList.SelectedValue.ToString())
        {
            case "az":
                sort = az;
                break;
            case "za":
                sort = za;
                break;
            case "hl":
                sort = hl;
                break;
            case "lh":
                sort = lh;
                break;
            default:
                sort = defaultview;
                break;
        }
        dt.DefaultView.Sort = sort;
        dt.AcceptChanges();
        LoadManufactuter.DataSource = dt;
        LoadManufactuter.DataBind();
    }
}