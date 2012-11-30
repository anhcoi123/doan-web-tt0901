using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Account_Register : System.Web.UI.Page
{
    public string message = "";
    public string errorNhaplaiMK = "";
    public string errorMK = "";
    public string errorCMND = "";
    public string errorDC="", errorTenKH="", errorTenDN = "";

    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        bool err = false;
        if (txtCMND.Text.Equals(""))
        {
            errorCMND = "Vui lòng nhập CMND";
            err = true;
        }
        if (txtPass.Text.Equals(""))
        {
            errorMK = "Vui lòng nhập mật khẩu";
            err = true;
        }
        else
            if (!txtPass.Text.Equals(txtConfirmPass.Text))
            {
                errorNhaplaiMK = "Mật khẩu không khớp";
                err = true;
            }
        if (txtDiaChi.Text.Equals(""))
        {
            errorDC = "Vui lòng nhập địa chỉ";
            err = true;
        }
        if (txtTenDN.Text.Equals(""))
        {
            errorTenDN = "Vui lòng chọn tên đăng nhập";
            err = true;
        }
        if (txtTenKH.Text.Equals(""))
        {
            errorTenKH = "Vui lòng cho biết tên của bạn";
            err = true;
        }
        if (err)
        {
            message = "Vui lòng kiểm tra thông tin đã nhập";
            err = false;
            return;
        }
        else
        {
            message = BLL.BLL_KhachHang.ThemKH(txtTenKH.Text, txtTenDN.Text, txtPass.Text, txtDiaChi.Text, txtSoDT.Text, txtCMND.Text);
            if (message.ToLower().Contains("thành công"))
            {
                Session["KhachHang"] = BLL.BLL_KhachHang.KTraDangNhap(txtTenDN.Text, txtPass.Text);
                Response.Redirect("./");
            }
        }
    }
}
