using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Account_Login : System.Web.UI.Page
{
    public string success = "";
    public string redirect = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request["logout"] != null)
        {
            Session["KhachHang"] = null;
        }
        if (Session["KhachHang"] != null)
            Response.Redirect("./");
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        DAO.KhachHang kh = BLL.BLL_KhachHang.KTraDangNhap(txtTenDN.Text, txtPassword.Text);
        if (kh != null && !kh.TenKH.Equals(""))
        {
            success = "Đăng nhập thành công";
            string view = "";
            if (Request["view"] != null)
            {
                view = Request["view"].ToString();
            }
            Session["KhachHang"] = kh;
            Response.Redirect("./" + view);
        }
        else
            success = "Lỗi: Không thể đăng nhập vui lòng kiểm tra lại tên đăng nhập/mật khẩu";
    }
}
