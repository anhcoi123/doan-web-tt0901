<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminPage.master" AutoEventWireup="true" CodeFile="AdminLinhKien_SuaLK.aspx.cs" Inherits="Admin_AdminLinhKien_SuaLK" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style9
        {
            width: 100%;
        }
        .style11
        {
            width: 476px;
            text-align: right;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style9">
        <tr>
            <td class="style11">
                SỬA LINH
            </td>
            <td>
                KIỆN</td>
        </tr>
        <tr>
            <td class="style11">
                Mã Linh Kiện</td>
            <td>
                <asp:Label ID="lblMaLK" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style11">
                Tên Linh Kiện</td>
            <td>
                <asp:TextBox ID="txtTenLK" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style11">
                Đơn Giá</td>
            <td>
                <asp:TextBox ID="txtDonGia" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style11">
                &nbsp;</td>
            <td>
                <asp:Button ID="btnSua" runat="server" onclick="btnSua_Click" Text="Sửa" />
            </td>
        </tr>
    </table>
</asp:Content>

