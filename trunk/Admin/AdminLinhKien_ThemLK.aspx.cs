using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using BLL;
using DAL;
using DAO;
public partial class Admin_AdminLinhKien_ThemLK : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["admin"] == null)
            Response.Redirect("./AdminLogin.aspx");
        DataTable tbNhaSX = BLL_NHASX.DTDanhSachNSX();
        for (int i = 0; i < tbNhaSX.Rows.Count; i++)
        {
            ddlMaNSX.Items.Add(tbNhaSX.Rows[i]["MANSX"].ToString());
        }

        DataTable tbLoaiLK = BLL_LOAILK.DTTatCaLoaiLK();
        for (int j = 0; j < tbLoaiLK.Rows.Count; j++)
        {
            ddlMaLoaiLK.Items.Add(tbLoaiLK.Rows[j]["MALOAILK"].ToString());
        }
    }
    protected void btnThem_Click(object sender, EventArgs e)
    {
        DAO.LinhKien lk = new LinhKien();
        lk.MaLK = txtMaLK.Text;
        lk.TenLK = txtTenLK.Text;
        lk.DVTinh = "Cái";
        lk.SoLuong = int.Parse(txtSoLuong.Text);
        lk.DonGia = int.Parse(txtDonGia.Text);
        lk.ThongTin = txtThongTin.Text;
        fileUpImage.SaveAs(MapPath("~/Images/" + fileUpImage.FileName));
        lk.HinhAnh = "Images/" + fileUpImage.FileName;
        lk.Maloailk = ddlMaLoaiLK.SelectedItem.Text;
        lk.Mansx = ddlMaNSX.SelectedItem.Text;
        BLL.BLL_LinhKien.InsertLK(lk.MaLK,lk.TenLK,lk.DVTinh,lk.SoLuong,lk.DonGia,lk.ThongTin,lk.HinhAnh,lk.Maloailk,lk.Mansx);
    }
}