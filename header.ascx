<%@ Control Language="C#" AutoEventWireup="true" CodeFile="header.ascx.cs" Inherits="header" %>
<script src="Scripts/jquery-1.4.1.min.js" type="text/javascript"></script>
<script type="text/javascript"><!--
    function bookmark(url, title) {
        if (window.sidebar) { // firefox
            window.sidebar.addPanel(title, url, "");
        } else if (window.opera && window.print) { // opera
            var elem = document.createElement('a');
            elem.setAttribute('href', url);
            elem.setAttribute('title', title);
            elem.setAttribute('rel', 'sidebar');
            elem.click();
        } else if (document.all) {// ie
            window.external.AddFavorite(url, title);
        }
    }
    function getURLVar(urlVarName) {
        var urlHalves = String(document.location).toLowerCase().split('?');
        var urlVarValue = '';
        if (urlHalves[1]) {
            var urlVars = urlHalves[1].split('&');

            for (var i = 0; i <= (urlVars.length); i++) {
                if (urlVars[i]) {
                    var urlVarPair = urlVars[i].split('=');

                    if (urlVarPair[0] && urlVarPair[0] == urlVarName.toLowerCase()) {
                        urlVarValue = urlVarPair[1];
                    }
                }
            }
        }

        return urlVarValue;
    }
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
            } else if (route.toLowerCase().match(/^giohang.*$/)) {
                $('#tab_cart').addClass('selected');
            } else if (part[0] == 'checkout') {
                $('#tab_checkout').addClass('selected');
            } else {
                $('#tab_home').addClass('selected');
            }
        }
    });

//--></script>
<div id="container">
<div id="header">
        <div id="site_title"><a href="<%=ResolveUrl("~/")%>">SHOP<span> LINH KIỆN</span></a></div>
        <div class="div4">
                <a id="tab_home" href="<%=ResolveUrl("~/")%>" class="selected">Trang chủ</a>
                <a id="tab_cart" href="<%=ResolveUrl("~/")%>giohang.aspx">Giỏ hàng</a>
                <a id="tab_login" href="<%=ResolveUrl("~/")%>Login.aspx">Đăng nhập</a>
                <a href="<%=ResolveUrl("~/")%>about.html">Thông tin</a>
                <a href="<%=ResolveUrl("~/")%>contact.html">Liên hệ</a>
            <br style="clear: left" />
        </div> <!-- end of templatemo_menu -->
      <div class="div5">
      <div class="left"></div>
      <div class="right"></div>
      <div class="center">
        <div id="search">
          <div class="div8">Tìm kiếm</div>
          <div class="div9">
            <input type="text" value="Từ khóa" id="filter_keyword" onclick="this.value = '';" onkeydown="this.style.color = '#000000'" style="color: #999;" />
            <select id="filter_category_id">
              <option value="0"><?php echo $text_category; ?></option>
              <?php foreach ($categories as $category) { ?>
              <?php if ($category['category_id'] == $category_id) { ?>
              <option value="<?php echo $category['category_id']; ?>" selected="selected"><?php echo $category['name']; ?></option>
              <?php } else { ?>
              <option value="<?php echo $category['category_id']; ?>"><?php echo $category['name']; ?></option>
              <?php } ?>
              <?php } ?>
            </select>
          </div>
          <div class="div10">&nbsp;&nbsp;<a onclick="moduleSearch();" class="button"><span>Tìm kiếm</span></a> <a href="<?php echo str_replace('&', '&amp;', $advanced); ?>">Tìm kiếm nâng cao</a></div>
        </div>
      </div>
    </div>
      <div class="div6">
    <div class="left"></div>
    <div class="right"></div>
    <div class="center">
</div>
  </div>