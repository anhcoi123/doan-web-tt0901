<%@ Control Language="C#" AutoEventWireup="true" CodeFile="header.ascx.cs" Inherits="header" %>
<script src="Scripts/jquery-1.4.1.min.js" type="text/javascript"></script>
<script type="text/javascript"><!--
    $(document).ready(function () {
        //route = getURLVar('route');
        var route = "";
        
        route = window.location.pathname.split('/').pop();
        if (!route) {
            $('#tab_home').addClass('selected');
        } else {
            $('#tab_home').removeClass("selected");
            part = route.split('?');
            if (route == '') {
                $('#tab_home').addClass('selected');
            } else if (route.toLowerCase().match(/^giohang.*$/)) {
                $('#tab_cart').addClass('selected');
            } else if (route.toLowerCase().match(/^login.*$/) || route.toLowerCase().match(/^register.*$/)) {
                $('#tab_login').addClass('selected');
            } else if (route.toLowerCase().match(/^thanhtoan.*$/)) {
                $('#tab_checkout').addClass('selected');
            } else if (route.toLowerCase().match(/^about.*$/)) {
                $('#tab_about').addClass('selected');
            } else {
                $('#tab_home').addClass('selected');
            }
        }
    });

//--></script>
<div id="container">
<div id="header">
    <div class="div1">
        <div class="div2"><a href="<%=ResolveUrl("~/")%>"><img src="./image/logo.png" title="SHOP LINH KIỆN" alt="SHOP LINH KIỆN"/></a></div>
        <div class="div3">
        <% if (Session["KhachHang"] != null && !((DAO.KhachHang)Session["KhachHang"]).TenKH.Equals(""))
           {%> <a style="background-image: url('./image/special.png');" href="./">Chào bạn <%= ((DAO.KhachHang)Session["KhachHang"]).TenKH%></a>
           <%} %>
        </div>
        <div class="div4">
                <a id="tab_home" href="<%=ResolveUrl("~/")%>" class="selected">Trang chủ</a>
                <% if (Session["KhachHang"] != null && !((DAO.KhachHang)Session["KhachHang"]).TenKH.Equals(""))
                   { %>
                <a id="tab_login" href="<%=ResolveUrl("~/")%>Login.aspx?logout=true">Đăng xuất</a>
                <%}
                   else
                   { %>
                <a id="tab_login" href="<%=ResolveUrl("~/")%>Login.aspx">Đăng nhập</a>
                <%} %>
                <a id="tab_cart" href="<%=ResolveUrl("~/")%>giohang.aspx">Giỏ hàng</a>
                <a id="tab_checkout" href="<%=ResolveUrl("~/")%>thanhtoan.aspx">Thanh toán</a>
                <a id="tab_about" href="<%=ResolveUrl("~/")%>about.aspx">Thông tin</a>
            <br style="clear: left" />
        </div> <!-- end of templatemo_menu -->
      <div class="div5">
      <div class="left"></div>
      <div class="right"></div>
      <div class="center">
        <div id="search">
          <div class="div8">Tìm kiếm</div>
          <div class="div9">
          <form name="timkiem" method="post" action="category.aspx">
            <input type="text" value="Từ khóa" id="filter_keyword" onclick="this.value = '';" onkeydown="this.style.color = '#000000'" style="color: #999;" />
            <select id="filter_category_id">
              <option value="0">Tất cả loại sản phẩm</option>
                <asp:Repeater ID="LoadCategory" runat="server">
                <ItemTemplate>
                    <option value="<%#Eval("MALOAILK") %>"><%#Eval("TENLOAILK") %></option>
                    </ItemTemplate>
                </asp:Repeater>
              
            </select>
          </div>
          <div class="div10">&nbsp;&nbsp;<a onclick="moduleSearch();" class="button"><span>Tìm kiếm</span></a></div>
        </div>
      </div>
    </div>
    </div>
      <div class="div6">
            <div class="left"></div>
            <div class="right"></div>
            <div class="center"></div>
    </div>
    </div>
    </div>
    <script type="text/javascript" language="javascript">
        function moduleSearch() {
            url = 'category.aspx?';
            var filter_keyword = $('#filter_keyword').attr('value')
            if (filter_keyword) {
                url += '&keyword=' + encodeURIComponent(filter_keyword);
            }
            var filter_category_id = $('#filter_category_id').attr('value');
            if (filter_category_id) {
                url += '&maloailk=' + filter_category_id;
            }
            location = url;
        } 
    </script>