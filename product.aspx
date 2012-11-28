<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="product.aspx.cs" Inherits="product" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
<%=title %>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">
  <div class="top">
    <div class="left"></div>
    <div class="right"></div>
    <div class="center">
      <h1><%=title %></h1>
    </div>
  </div>
  <div class="middle">
  <% if (!lk.MaLK.Equals(""))
     { %>
    <div style="width: 100%; margin-bottom: 30px;">
      <table style="width: 100%; border-collapse: collapse;">
      
        <tr>
          <td style="text-align: center; width: 250px; vertical-align: top;"><a href="./<%=lk.HinhAnh %>" title="<%=lk.TenLK %>" class="thickbox" rel="gallery"><img src="./<%=lk.HinhAnh %>" title="<%=title %>" alt="<%=title %>" id="img<%=lk.MaLK %>" style="margin-bottom: 3px; width:250px;height:250px" /></a><br />
            <span style="font-size: 11px;">Bấm vào để phóng to</span></td>
          <td style="padding-left: 15px; width: 296px; vertical-align: top;"><table width="100%">
              <tr>
                <td><b>Giá: </b></td>
                <td>
                  <span style="color: #F00;"><%=String.Format("{0:###,###,##0}",lk.DonGia) %>,000 VNĐ</span>
                </td>
              </tr>
              <tr>
                <td><b>Còn hàng? :</b></td>
                <td><%if (lk.SoLuong > 0)
                         {
                              %>Còn hàng<%}else{ %> Hết hàng <%} %>
                </td>
              </tr>
              <tr>
                <td><b>Nhà sản xuất:</b></td>
                <td><a href="./manufactuter.aspx?id=<%=nhasx.Mansx %>"><%=nhasx.Tennsx %></a></td>
              </tr>
			  <tr>
                <td><b>Đánh giá trung bình: </b></td>
                <td>Chưa có đánh giá</td>
              </tr>
            </table>
            <br />
              <div class="content">
                Số lượng:
                <input type="text" name="quantity" size="3" value="1" id="quantity"/>
                <a onclick="themVaoGH('<%=lk.MaLK %>',$('#quantity').val().toString())" id="add_to_cart" class="button"><span>Thêm vào giỏ</span></a>
              </div>
        </tr>
      </table>
    </div>
    <div class="tabs">
      <a tab="#tab_description">Mô tả</a>
      <a tab="#tab_image">Hình ảnh(0)</a>
      <a tab="#tab_related">Sản phẩm tương tự (0)</a>
    </div>
    <div id="tab_description" class="tab_page"><%=lk.ThongTin %></div>
    <div id="tab_image" class="tab_page">
      <div style="background: #F7F7F7; border: 1px solid #DDDDDD; padding: 10px; margin-bottom: 10px;">Không có hình nào khác</div>
    </div>
    <div id="tab_related" class="tab_page">
      <div style="background: #F7F7F7; border: 1px solid #DDDDDD; padding: 10px; margin-bottom: 10px;">Không có sản phẩm tương tự</div>
    </div>
    <%}%>
    <asp:Label ID="txtNoData" runat="server"></asp:Label>
  </div>
  <div class="bottom">
    <div class="left"></div>
    <div class="right"></div>
    <div class="center"></div>
  </div>
  <script src="Scripts/tab.js" type="text/javascript"></script>
<script type="text/javascript"><!--
    $('#review .pagination a').live('click', function () {
        $('#review').slideUp('slow');

        $('#review').load(this.href);

        $('#review').slideDown('slow');

        return false;
    });

    $('#review').load('index.php?route=product/product/review&product_id=<?php echo $product_id; ?>');

    function review() {
        $.ajax({
            type: 'POST',
            url: 'index.php?route=product/product/write&product_id=<?php echo $product_id; ?>',
            dataType: 'json',
            data: 'name=' + encodeURIComponent($('input[name=\'name\']').val()) + '&text=' + encodeURIComponent($('textarea[name=\'text\']').val()) + '&rating=' + encodeURIComponent($('input[name=\'rating\']:checked').val() ? $('input[name=\'rating\']:checked').val() : '') + '&captcha=' + encodeURIComponent($('input[name=\'captcha\']').val()),
            beforeSend: function () {
                $('.success, .warning').remove();
                $('#review_button').attr('disabled', 'disabled');
                $('#review_title').after('<div class="wait"><img src="catalog/view/theme/default/image/loading_1.gif" alt="" /> <?php echo $text_wait; ?></div>');
            },
            complete: function () {
                $('#review_button').attr('disabled', '');
                $('.wait').remove();
            },
            success: function (data) {
                if (data.error) {
                    $('#review_title').after('<div class="warning">' + data.error + '</div>');
                }

                if (data.success) {
                    $('#review_title').after('<div class="success">' + data.success + '</div>');

                    $('input[name=\'name\']').val('');
                    $('textarea[name=\'text\']').val('');
                    $('input[name=\'rating\']:checked').attr('checked', '');
                    $('input[name=\'captcha\']').val('');
                }
            }
        });
    }
//--></script>
<script type="text/javascript"><!--
    $.tabs('.tabs a'); 
//--></script>
</asp:Content>

