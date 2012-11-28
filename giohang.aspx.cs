using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class giohang : System.Web.UI.Page
{
    protected void Page_PreInit(object sender, EventArgs e)
    {
        if (Request["MALK"]!=null || (Request["method"]!=null && Request["method"].ToLower().Equals("update")))
        {
            try
            {

                if (!Request["MALK"].Equals("") || Request["method"].Equals("update")) //check the user weather user is logged in or not
                {
                    this.Page.MasterPageFile = "~/BLANK.master";
                }
                //this.Page.MasterPageFile = "~/myMaster.master";
            }
            catch (Exception ex)
            {
            }
        }
    }
    public DAO.GioHang gh = new DAO.GioHang();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            string malk = "";
            if (Request["MALK"] != null)
                malk = Request["MALK"].ToString();
            if (malk.Equals(""))//Không có Ajax
            {
                if (Request.QueryString["method"] != null && Request.QueryString["method"].ToString().ToLower().Equals("deleteall"))
                    Session["GioHang"] = null;
            }
            else // Được Ajax gọi
            {
                if (Session["GioHang"] == null)
                    Session["GioHang"] = gh;
                gh = (DAO.GioHang)Session["GioHang"];
                bool exist = false;
                int SL = int.Parse(Request["SoLuong"]); // Lấy số lượng
                string method = "";
                if (Request["method"] != null)
                    method = Request["method"];
                int thanhtienLK = 0;
                foreach (DAO.LinhKien lk in gh.LinhKien)
                {
                    if (lk.MaLK.Equals(malk))
                    {
                        if (method.Equals("delete"))
                        {
                            gh.ThanhTien -= lk.SoLuong * lk.DonGia;
                            gh.LinhKien.Remove(lk);
                            break;
                        }
                        if (method.Equals("update"))
                        {
                            gh.ThanhTien -= lk.SoLuong * lk.DonGia;
                            lk.SoLuong = SL;
                        }
                        else
                            if (method.Equals("add"))
                            {
                                gh.ThanhTien -= lk.SoLuong * lk.DonGia;
                                lk.SoLuong += SL;
                            }
                        gh.ThanhTien += lk.SoLuong * lk.DonGia;
                        thanhtienLK = SL * lk.DonGia;
                        exist = true;
                        break;
                    }
                }

                if (!exist && !method.Equals("delete"))
                {
                    DAO.LinhKien lk = BLL.BLL_LinhKien.searchLK(Request["MALK"].ToString());
                    lk.SoLuong = SL;
                    gh.LinhKien.Add(lk);
                    gh.ThanhTien += lk.DonGia *SL;
                    thanhtienLK = lk.DonGia;
                }
                Session["GioHang"] = gh;
                string subtotal = String.Format("{0:###,###,##0}", gh.ThanhTien / 1.1) + ",000 VNĐ";
                string vat = String.Format("{0:###,###,##0}", gh.ThanhTien / 1.1 * 0.1) + ",000 VNĐ";
                string total = String.Format("{0:###,###,##0}", gh.ThanhTien) + ",000 VNĐ";
                Response.Write(String.Format("{0:###,###,##0}", thanhtienLK) + "|" + subtotal + "|" + vat + "|" + total + "|");//"<span style=\"color:green\">Đã thêm vào giỏ hàng</span>");
            }
        }
        catch (Exception ex)
        {
        }
    }
}