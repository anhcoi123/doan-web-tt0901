<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminPage.master" AutoEventWireup="true" CodeFile="AdminLogin.aspx.cs" Inherits="Admin_AdminLogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style6
        {
            width: 512px;
            text-align: right;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1">
        <tr>
            <td class="style6" style="text-align: right">
                ID</td>
            <td>
                <asp:TextBox ID="txtID" runat="server" Width="213px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style6">
                Password</td>
            <td>
                <asp:TextBox ID="txtPass" runat="server" Width="213px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style6">
                <asp:Button ID="btnLogin" runat="server" Text="Đăng Nhập" 
                    onclick="btnLogin_Click" />
            </td>
            <td>
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" 
                    onclick="btnCancel_Click" />
            </td>
        </tr>
    </table>
    <div style="text-align: center">

        <asp:Label ID="lblError" runat="server"></asp:Label>

    </div>

</asp:Content>

