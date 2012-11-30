using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class thanhtoan : System.Web.UI.Page
{
    public string success = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["KhachHang"] == null)
            Response.Redirect("./Login.aspx?view=thanhtoan");
        if (Session["GioHang"] == null)
            Response.Redirect("./");
    }
    protected void btnDoiDiaChi_Click(object sender, EventArgs e)
    {
        // Chưa xử lý
    }
    protected void btnConfirmThanhToan_Click(object sender, EventArgs e)
    {
        DAO.GioHang gh=(DAO.GioHang)Session["GioHang"];
        DAO.KhachHang kh=(DAO.KhachHang)Session["KhachHang"];
        if (BLL.BLL_DONDH.ThemGioHangVaoDonDH(gh, kh.MaKH).Contains("thành công"))
        {
            success = "Đã đặt mua hàng thành công! Cảm ơn bạn đã mua hàng của chúng tôi";
            Session["GioHang"] = null;
            Response.Redirect("./");
        }
        else
            success = "Lỗi: Không thể Đặt mua hàng";
    }
}