<%@ Control Language="C#" AutoEventWireup="true" CodeFile="columnRight.ascx.cs" Inherits="columnRight" %>
<script type="text/javascript" language="javascript">
    function xoaLK(malk) {
        var request = $.ajax({
            url: "giohang.aspx",
            type: "POST",
            data: { MALK: malk, SoLuong: '0',method: 'delete' },
            success: function (response, textStatus, jqXHR) {
                $("#column_right").load("columnRight.aspx");
            }
        });
    }
</script>
<script>
    function ScrollCart() {

        var msie6 = $.browser == 'msie' && $.browser.version < 7;

        if (!msie6) {
            var top = $('#comment').offset().top - parseFloat($('#comment').css('margin-top').replace(/auto/, 0));
            var y = $(window).scrollTop();

            // whether that's below the form
            if (y >= top) {
                // if so, ad the fixed class
                $('#comment').addClass('fixed');
            } else {
                // otherwise remove it
                $('#comment').removeClass('fixed');
            }

            $(window).scroll(function (event) {
                // what the y position of the scroll is
                var y = $(this).scrollTop();

                // whether that's below the form
                if (y >= top) {
                    // if so, ad the fixed class
                    $('#comment').addClass('fixed');
                } else {
                    // otherwise remove it
                    $('#comment').removeClass('fixed');
                }
            });
        }
    }
    $(function () { ScrollCart(); });
</script>
<div id="column_right">
    <div id="comment">
        <div class="box" id="module_cart">
            <div class="top"><img src="./image/basket.png" alt="" />Giỏ hàng</div>
            <div class="middle">
                <%
                if (Session["GioHang"]!=null)
                {%>
                <table cellspacing="0" cellpadding="2" style="width: 100%;">
                <%          foreach (DAO.LinhKien lk in ((DAO.GioHang)Session["GioHang"]).LinhKien)
                            {%>
                                <tr style="border-bottom:1px solid black">
                                    <td width="1" valign="top" align="left">
                                        <span id="remove_<%=lk.MaLK %>" class="cart_remove" onclick="xoaLK('<%=lk.MaLK %>')"> </span>
                                    </td>
                                    <td style="width:1"><%=lk.SoLuong%> x </td>
                                    <td><a href="./product.aspx?id=<%=lk.MaLK%>"><%=lk.TenLK%></a></td>
                                </tr>
                           <%}%>
                </table>
                <br>
                <table cellspacing="0" cellpadding="0" align="right" style="display:inline-block;">
                            <tr>
                                <td align="right">
                                    <span class="cart_module_total"><b>Chưa VAT:</b></span>
                                </td>
                                <td align="right"><span class="cart_module_total"><%=String.Format("{0:###,###,##0}", ((DAO.GioHang)Session["GioHang"]).ThanhTien / 1.1)%>,000 đ</span></td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <span class="cart_module_total"><b>VAT 10%:</b></span>
                                </td>
                                <td align="right"><span class="cart_module_total"><%=String.Format("{0:###,###,##0}", ((DAO.GioHang)Session["GioHang"]).ThanhTien/1.1 * 0.1)%>,000 đ</span></td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <span class="cart_module_total"><b>Tổng cộng:</b></span>
                                </td>
                                <td align="right"><span class="cart_module_total"><%=String.Format("{0:###,###,##0}", ((DAO.GioHang)Session["GioHang"]).ThanhTien)%>,000 đ</span></td>
                            </tr>

                        </table>
                        <div style="padding-top:5px;text-align:center;clear:both;">
                            <a href="./giohang.aspx">Giỏ</a>&nbsp;|&nbsp;<a href="./thanhtoan.aspx">Thanh toán</a>
                        </div>
                <% }else{%>
                    Giỏ hàng rỗng
                <%}%>
            </div>
      <div class="bottom">&nbsp;</div>
      </div>
    </div>
</div>