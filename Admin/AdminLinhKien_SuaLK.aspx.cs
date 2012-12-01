using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using DAO;
using BLL;

public partial class Admin_AdminLinhKien_SuaLK : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["admin"] == null)
            Response.Redirect("./AdminLogin.aspx");
        if (!IsPostBack)
        {
            string MaLK = Request.QueryString["MALK"];
            DataTable tb = BLL.BLL_LinhKien.DTSearchLK_MALK(MaLK);
            lblMaLK.Text = MaLK;
            txtTenLK.Text = tb.Rows[0]["TENLK"].ToString();
            txtDonGia.Text = (tb.Rows[0]["DONGIA"].ToString());
        }
    }
    protected void btnSua_Click(object sender, EventArgs e)
    {
        string strMaLK = lblMaLK.Text;
        string strTenLK = txtTenLK.Text;
        int DonGia = int.Parse(txtDonGia.Text);

        int i = BLL.BLL_LinhKien.UpdateLK(strMaLK, strTenLK, DonGia);
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