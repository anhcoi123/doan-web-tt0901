<%@ Page Title="Register" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Register.aspx.cs" Inherits="Account_Register" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
  <div class="top">
    <div class="left"></div>
    <div class="right"></div>
    <div class="center">
      <h1>Tạo tài khoản</h1>
    </div>
  </div>
  <div class="middle">
    <% if (message.ToLower().Contains("lỗi")){ %>
    <div class="warning"><%#message %></div>
    <%} %>
    <form id="Form1" runat="server">
      <p>Nếu bạn đã có tài khoản, vui lòng đăng nhập <a href="./Login.aspx">Tại đây</a></p>
      <b style="margin-bottom: 2px; display: block;">Thông tin cá nhân</b>
      <div style="background: #F7F7F7; border: 1px solid #DDDDDD; padding: 10px; margin-bottom: 10px;">
        <table>
          <tr>
            <td width="150"><span class="required">*</span> Họ tên</td>
            <td><asp:TextBox ID="txtTenKH" runat="server"></asp:TextBox>
              <span class="error"><%=errorTenKH %></span>
              </td>
          </tr>
          <tr>
            <td width="150"><span class="required">*</span> Tên đăng nhập</td>
            <td><asp:TextBox ID="txtTenDN" runat="server"></asp:TextBox>
              <span class="error"><%=errorTenDN %></span>
              </td>
          </tr>
        </table>
      </div>
      <b style="margin-bottom: 2px; display: block;">Thông tin liên lạc</b>
      <div style="background: #F7F7F7; border: 1px solid #DDDDDD; padding: 10px; margin-bottom: 10px;">
        <table>
          <tr>
            <td width="150"><span class="required">*</span> Địa chỉ</td>
            <td><asp:TextBox ID="txtDiaChi" runat="server"></asp:TextBox>
              <span class="error"><%=errorDC %></span>
              </td>
          </tr>
          <tr>
            <td width="150">Số Điện thoại</td>
            <td><asp:TextBox ID="txtSoDT" runat="server"></asp:TextBox>
              </td>
          </tr>
          <tr>
            <td width="150"><span class="required">*</span> CMND</td>
            <td><asp:TextBox ID="txtCMND" runat="server"></asp:TextBox>
              <span class="error"><%=errorCMND %></span>
              </td>
          </tr>
        </table>
      </div>
      <b style="margin-bottom: 2px; display: block;">Mật khẩu của bạn</b>
      <div style="background: #F7F7F7; border: 1px solid #DDDDDD; padding: 10px; margin-bottom: 10px;">
        <table>
          <tr>
            <td width="150"><span class="required">*</span> Mật khẩu</td>
            <td><asp:TextBox TextMode="Password" ID="txtPass" runat="server"></asp:TextBox>
              <span class="error"><%=errorMK %></span>
              </td>
          </tr>
          <tr>
            <td><span class="required">*</span> Nhập lại mật khẩu</td>
            <td><asp:TextBox TextMode="Password" ID="txtConfirmPass" runat="server"></asp:TextBox>
              <span class="error"><%#errorNhaplaiMK %></span>
            </td>
          </tr>
        </table>
      </div>

      <div class="buttons">
        <table>
          <tr>
            <td align="right" style="padding-right: 5px;">Tôi đã đọc và chấp nhận thực hiện các chính sách trong <a href="tos.html">Điều lệ</a></td>
            <td width="5" style="padding-right: 10px;">
              <asp:CheckBox ID="agree" runat="server" /></td>
            <td align="right"><asp:LinkButton ID="btnRegister"  CssClass="button" runat="server" onclick="btnRegister_Click"><span>Đăng ký</span></asp:LinkButton></td>
          </tr>
        </table>
      </div>
    </form>
  </div>
  <div class="bottom">
    <div class="left"></div>
    <div class="right"></div>
    <div class="center"></div>
  </div>

</asp:Content>