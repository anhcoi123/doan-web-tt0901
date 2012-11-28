using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class category : System.Web.UI.Page
{
    public string title = "";
    private DataTable dt = new DataTable();
    private string maloailk = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (Request["maloailk"]!=null)
            maloailk=Request["maloailk"].ToString();
        title = BLL.BLL_LOAILK.TenLoaiLK_MALOAILK(maloailk);
        if (title.Equals("Không tìm thấy loại linh kiện"))
            txtNoData.Text="Không tìm thấy loại linh kiện";
        else
        {
            dt=BLL.BLL_LinhKien.DTTatCaLK_MaLoaiLK(maloailk);
            LoadCategory.DataSource=dt;
            LoadCategory.DataBind();
            if (LoadCategory.Items.Count==0)
                txtNoData.Text="Không có sản phẩm nào thuộc loại này!";
        }
    }
    protected void sortList_SelectedIndexChanged(object sender, EventArgs e)
    {
        string defaultview = "MALK ASX";
        string az = "TENLK ASC";
        string za = "TENLK DESC";
        string hl = "DONGIA DESC";
        string lh = "DONGIA ASC";
        string sort=defaultview;
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
        LoadCategory.DataSource = dt;
        LoadCategory.DataBind();
    }
}