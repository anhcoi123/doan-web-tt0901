<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="thanhtoan.aspx.cs" Inherits="thanhtoan" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">

  <div class="top">
    <div class="left"></div>
    <div class="right"></div>
    <div class="center">
      <h1>Thanh toán</h1>
    </div>
  </div>
  <div class="middle">
            <% if (success.ToLower().Contains("thành công"))
           { %>
        <div class="success"><%=success%></div>
        <%}
           else if (success.ToLower().Contains("lỗi"))
           { %>
        <div class="warning"><%=success%></div>
        <%} %>
        <form id="Form1" runat="server">
    <div class="content">
    
      <table width="100%">
        <tr>
          <td width="33.3%" valign="top">
            <b>Phương thức thanh toán</b><br />
            Giao hàng tận nhà rồi trả tiền<br />
            <br />
          <td width="33.3%" valign="top">
            <b>Địa chỉ giao hàng</b><br />
            <asp:Label ID="Label1" runat="server"><%=((DAO.KhachHang)Session["KhachHang"]).DiaChi %></asp:Label><br />
              <asp:LinkButton ID="btnDoiDiaChi" runat="server" CssClass="button" 
                  onclick="btnDoiDiaChi_Click"><span>Đổi địa chỉ khác</span></asp:LinkButton>
          </td>
        </tr>
      </table>
    </div>
    <div class="content">
      <table width="100%">
        <tr>
                <th>Tên LK</th>
                <th align="right">Số lượng</th>
                <th align="right">Đơn giá (x1,000)</th>
                <th align="right">Thành tiền (x1,000)</th>
                <th>&nbsp;</th>
            </tr>
            <%       if (Session["GioHang"] != null)
                     {
                         foreach (DAO.LinhKien lk in ((DAO.GioHang)Session["GioHang"]).LinhKien)
                         {%>
                        <tr>
                            <td><a href="./product.aspx?id=<%=lk.MaLK%>"><%=lk.TenLK%></a></td>
                            <td align="right"><%=lk.SoLuong%></td>
                            <td align="right"><%=String.Format("{0:###,###,##0}", lk.DonGia)%></td>
                            <td align="right"><%=String.Format("{0:###,###,##0}", lk.DonGia * lk.SoLuong)%></td>
                            <td></td>
                        </tr>
                        <%}
                     }%>
            </table>
            <%      if (Session["GioHang"] != null)
                 {%>
                    <div style="width: 100%; display: inline-block;">
                        <table style="float: right; display: inline-block;">
                            <tr>
                                <td align="right">
                                    <b>Tổng cộng(chưa VAT):</b>
                                </td>
                                <td align="right"><label id="Subtotal"><%=String.Format("{0:###,###,##0}", ((DAO.GioHang)Session["GioHang"]).ThanhTien )%>,000 VNĐ</label></td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <b>VAT 10%:</b>
                                </td>
                                <td align="right"><label id="VAT"><%=String.Format("{0:###,###,##0}", ((DAO.GioHang)Session["GioHang"]).ThanhTien * 0.1)%>,000 VNĐ</label></td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <b>TỔNG CỘNG:</b>
                                </td>
                                <td align="right"><label id="Total"><%=String.Format("{0:###,###,##0}", ((DAO.GioHang)Session["GioHang"]).ThanhTien * 1.1)%>,000 VNĐ</label></td>
                            </tr>

                        </table>
                        <br>
                    </div>
                <%}%>
      <br />
    </div>
    <div id="payment">
        <div class="buttons">
            <table>
            <tbody>
            <tr>
            <td align="left">
            <a class="button" onclick="location = 'giohang.aspx'">
            <span>Back</span>
            </a>
            </td>
            <td align="right">
            <asp:LinkButton ID="btnConfirmThanhToan" runat="server" CssClass="button" 
                    onclick="btnConfirmThanhToan_Click">
            <span>Confirm Order</span>
            </asp:LinkButton>
            </td>
            </tr>
            </tbody>
            </table>
        </div>
    </div>
    </form>
  </div>
  <div class="bottom">
    <div class="left"></div>
    <div class="right"></div>
    <div class="center"></div>
  </div>

</asp:Content>

