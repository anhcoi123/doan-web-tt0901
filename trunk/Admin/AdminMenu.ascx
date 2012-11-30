<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AdminMenu.ascx.cs" Inherits="AdminMenu" %>
<style type="text/css">
    .style1
    {
        width: 13%;
    }
    .style2
    {
        height: 21px;
    }
</style>
<table width="100%">
    <tr>
        <td class="style2">
            <asp:HyperLink ID="HyperLink1" runat="server" 
                NavigateUrl="~/Admin/AdminLinhKien.aspx">Linh Kiện</asp:HyperLink>
        </td>
    </tr>
    <tr>
        <td>
            <asp:HyperLink ID="HyperLink2" runat="server" 
                NavigateUrl="~/Admin/AdminDonDH.aspx">Đơn Đặt Hàng</asp:HyperLink>
        </td>
    </tr>
    <tr>
        <td>
            <asp:HyperLink ID="HyperLink3" runat="server" 
                NavigateUrl="~/Admin/AdminKhachHang.aspx">Khách Hàng</asp:HyperLink>
        </td>
    </tr>
</table>
