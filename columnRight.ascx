<%@ Control Language="C#" AutoEventWireup="true" CodeFile="columnRight.ascx.cs" Inherits="columnRight" %>
<script type="text/javascript" language="javascript">
    function xoaLK(malk) {
        var request = $.ajax({
            url: "giohang.aspx",
            type: "POST",
            data: { MALK: malk, SoLuong: '0',Delete: 'true' },
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
                <table cellspacing="0" cellpadding="2" style="width: 100%;">
                    <%
                        if (Session["GioHang"]!=null)
                        {
                            foreach (DAO.LinhKien lk in ((DAO.GioHang)Session["GioHang"]).LinhKien)
                            {%>
                                <tr>
                                    <td width="1" valign="top" align="left">
                                        <span id="remove_<%=lk.MaLK %>" class="cart_remove" onclick="xoaLK('<%=lk.MaLK %>')"> </span>
                                    </td>
                                    <td style="width:1"><%=lk.SoLuong%> x </td>
                                    <td><%=lk.TenLK%></td>
                                </tr>
                           <%}
                        }%>
                </table>
            </div>
      <div class="bottom">&nbsp;</div>
    </div>
    </div>
</div>