<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="giohang.aspx.cs" Inherits="giohang" %>

<asp:Content ID="Content2" ContentPlaceHolderID="HeadContent" Runat="Server">
    <% if (Request["MALK"] == null)
       {%>
        Anh Khoa SHOP - Giỏ hàng
        <%} %>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">
    <% if (Request["MALK"] == null )
       {%>

       <script language="javascript" type="text/javascript">
           function capNhat(a) {
               var c = $("#soLuong" + a).val().toString();
               var request = $.ajax({
                   url: "giohang.aspx",
                   type: "POST",
                   data: { MALK: a, SoLuong: c, method: 'update' },
                   success: function (response, textStatus, jqXHR) {
                       var result = "";
                       result = response.toString();
                       var n = result.split("|");
                       $("#thanhTienLK" + a).html(n[0]);
                       $("#Subtotal").text(n[1]);
                       $("#VAT").text(n[2]);
                       $("#Total").text(n[3]);
                       updateGH();
                   }
               });

               
           }
       </script>
            <div class="top">
                <div class="left"></div>
                <div class="right"></div>
                <div class="center">
                    <h1>Giỏ hàng</h1>
                </div>
            </div>
        <div class="middle">
            <div id="Giohang">
            <table class="cart">
            <tr>
                <th>&nbsp;</th>
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
                            <td><a href="./product.aspx?id=<%=lk.MaLK%>"><img src="<%= lk.HinhAnh%>" style="width:75px; height:75px"/></a></td>
                            <td><a href="./product.aspx?id=<%=lk.MaLK%>"><%=lk.TenLK%></a></td>
                            <td align="right"><input type="text" id="soLuong<%=lk.MaLK%>" value="<%=lk.SoLuong%>"  onchange="capNhat('<%=lk.MaLK %>')" style="text-align:right"/></td>
                            <td align="right"><label id="donGiaLK<%=lk.MaLK %>"><%=String.Format("{0:###,###,##0}", lk.DonGia)%></label></td>
                            <td align="right"><label id="thanhTienLK<%=lk.MaLK %>"><%=String.Format("{0:###,###,##0}", lk.DonGia * lk.SoLuong)%></label></td>
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
                                <td align="right"><label id="Subtotal"><%=String.Format("{0:###,###,##0}", ((DAO.GioHang)Session["GioHang"]).ThanhTien / 1.1)%>,000 VNĐ</label></td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <b>VAT 10%:</b>
                                </td>
                                <td align="right"><label id="VAT"><%=String.Format("{0:###,###,##0}", ((DAO.GioHang)Session["GioHang"]).ThanhTien/1.1 * 0.1)%>,000 VNĐ</label></td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <b>TỔNG CỘNG:</b>
                                </td>
                                <td align="right"><label id="Total"><%=String.Format("{0:###,###,##0}", ((DAO.GioHang)Session["GioHang"]).ThanhTien)%>,000 VNĐ</label></td>
                            </tr>

                        </table>
                        <br>
                    </div>
                <%}%>
    
                <div class="buttons">
                    <table>
                        <tbody>
                            <tr>
                                <td align="left">
                                    <a class="button" href="giohang.aspx?method=deleteAll"><span>Xóa giỏ hàng</span></a>
                                </td>
                                <td align="center">
                                    <a class="button" href="./"><span>Tiếp tục mua hàng</span></a>
                                </td>
                                <td align="right">
                                    <a class="button" href="./ThanhToan.aspx"><span>Thanh toán</span></a>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
        </div>
        </div>
        <div class="bottom">
            <div class="left"></div>
            <div class="right"></div>
            <div class="center"></div>
        </div>

    <%} %>

</asp:Content>

