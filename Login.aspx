<%@ Page Title="Log In" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Login.aspx.cs" Inherits="Account_Login" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
Anh Khoa SHOP - Đăng nhập
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
              <%if (Session["GioHang"] == null || (Session["GioHang"] != null && ((DAO.GioHang)Session["GioHang"]).LinhKien.Count() == 0))
                    {%>
              <input type="radio" name="account" value="register" id="register" checked="checked" />
              <%}
                    else
                    { %>
              <input type="radio" name="account" value="register" id="register" />
              <%
                } %>
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
            <form id="login" runat="server">
            Tôi là khách hàng cũ của shop<br />
            <br />
            <b>Địa chỉ E-Mail</b><br />
            <asp:TextBox ID="email" runat="server" CausesValidation="True"></asp:TextBox><br /><asp:RequiredFieldValidator
                ID="ReqEmail" runat="server" ErrorMessage="Chưa nhập email" 
                Font-Bold="True" ControlToValidate="email" ForeColor="Red" 
                Display="Dynamic"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                ControlToValidate="email" Display="Dynamic" ErrorMessage="Email sai định dạng" 
                Font-Bold="True" ForeColor="Red" 
                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            <br />
            <b>Mật khẩu</b><br />
            <asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox><br /><asp:RequiredFieldValidator
                ID="RequiredFieldValidator1" runat="server" ErrorMessage="Chưa nhập mật khẩu" 
                Font-Bold="True" ControlToValidate="password" ForeColor="Red" 
                Display="Dynamic"></asp:RequiredFieldValidator>
            <!-- <a href="<%=ResolveUrl("~/")%>Login.aspx?quenpass=1">Tôi đã quên mật khẩu</a><br /> -->
            <div style="text-align: right;"><asp:LinkButton CssClass="button" runat="server" 
                    ID="btnLogin" onclick="btnLogin_Click"><span>Đăng nhập</span></asp:LinkButton></div>
            
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