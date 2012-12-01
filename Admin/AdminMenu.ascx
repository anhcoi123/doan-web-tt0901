<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AdminMenu.ascx.cs" Inherits="AdminMenu" %>
<style type="text/css">
    .style2
    {
        height: 21px;
        text-align: center;
    }
    .style3
    {
        text-align: center;
    }
</style>
<table width="100%" style="vertical-align:top">
    <tr>
        <td class="style2">
            <asp:HyperLink ID="HyperLink1" runat="server" 
                NavigateUrl="~/Admin/AdminLinhKien.aspx">Linh Kiện</asp:HyperLink>
        </td>
    </tr>
    <tr>
        <td class="style3">
            <asp:HyperLink ID="HyperLink2" runat="server" 
                NavigateUrl="~/Admin/AdminDonDH.aspx">Đơn Đặt Hàng</asp:HyperLink>
        </td>
    </tr>
    <tr>
        <td class="style3">
            <asp:HyperLink ID="HyperLink3" runat="server" 
                NavigateUrl="~/Admin/AdminKhachHang.aspx">Khách Hàng</asp:HyperLink>
        </td>
    </tr>
    <tr>
        <td class="style3">
            <asp:HyperLink ID="HyperLink4" runat="server" 
                NavigateUrl="~/Admin/AdminLogin.aspx?logout=true">Đăng thoát</asp:HyperLink>
        </td>
    </tr>
</table>
