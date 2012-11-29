﻿<%@ Page Title="Log In" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Login.aspx.cs" Inherits="Account_Login" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div class="top">
    <div class="left"></div>
    <div class="right"></div>
    <div class="center">
      <h1>Đăng nhập</h1>
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
    <div style="margin-bottom: 10px; display: inline-block; width: 100%;">
      <div style="float: left; display: inline-block; width: 49%;"><b style="margin-bottom: 2px; display: block;">Khách mới</b>
        <div style="background: #F7F7F7; border: 1px solid #DDDDDD; padding: 10px; min-height: 210px;">
          <form action="<%=ResolveUrl("~/")%>Account/Register.aspx" method="post" enctype="multipart/form-data" id="account">
            <p>Lựa chọn thanh toán</p>
            <label for="register" style="cursor: pointer;">
              <%if (Session["GioHang"]!=null && ((DAO.GioHang)Session["GioHang"]).LinhKien.Count()==0) {%>
              <input type="radio" name="account" value="register" id="register" checked="checked" />
              <%}else{ %>
              <input type="radio" name="account" value="register" id="register" />
              <%} %>
              <b>Đăng ký tài khoản</b></label>
            <br />
            <%if (Session["GioHang"]!=null && ((DAO.GioHang)Session["GioHang"]).LinhKien.Count()!=0) {%>
            <label for="guest" style="cursor: pointer;">
              <input type="radio" name="account" value="guest" id="guest" checked="checked" />
              <b>Tài khoản khách</b></label>
            <br />
            <%} %>
            <br />
            <p>Tạo tài khoản sẽ giúp bạn được mua hàng dễ dàng, nhanh chóng cho những lần sau (Vì chỉ cần đăng nhập, và khi thanh toán bạn sẽ không cần phải nhập lại thông tin khách hàng)</p>
            <div style="text-align: right;"><a onclick="$('#account').submit();" class="button"><span>Tiếp tục</span></a></div>
          </form>

        </div>
      </div>
      <div style="float: right; display: inline-block; width: 49%;"><b style="margin-bottom: 2px; display: block;">Nếu bạn là khách cũ</b>
        <div style="background: #F7F7F7; border: 1px solid #DDDDDD; padding: 10px; min-height: 210px;">
          <form action="<%=ResolveUrl("~/")%>Account/Login.aspx" method="post" enctype="multipart/form-data" id="login">
            Tôi là khách hàng cũ của shop<br />
            <br />
            <b>Địa chỉ E-Mail</b><br />
            <input type="text" name="email" />
            <br />
            <br />
            <b>Mật khẩu</b><br />
            <input type="password" name="password" />
            <br />
            <a href="<%=ResolveUrl("~/")%>Account/Login.aspx?quenpass=1">Tôi đã quên mật khẩu</a><br />
            <div style="text-align: right;"><a onclick="$('#login').submit();" class="button"><span>Đăng nhập</span></a></div>
            <% if (!redirect.Equals("")){ %>
            <input type="hidden" name="redirect" value="<%=redirect %>" />
            <%} %>
          </form>
        </div>
      </div>
    </div>
  </div>
  <div class="bottom">
    <div class="left"></div>
    <div class="right"></div>
    <div class="center"></div>
  </div>

<script type="text/javascript"><!--
    $('#login input').keydown(function (e) {
        if (e.keyCode == 13) {
            $('#login').submit();
        }
    });
//--></script>
</asp:Content>