<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminPage.master" AutoEventWireup="true" CodeFile="AdminKhachHang_ThemKH.aspx.cs" Inherits="Admin_AdminKhachHang_ThemKH" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style9
        {
            width: 100%;
        }
        .style10
        {
            width: 485px;
            text-align: right;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style9">
        <tr>
            <td class="style10">
                THÊM KHÁCH</td>
            <td>
                HÀNG</td>
        </tr>
        <tr>
            <td class="style10">
                Mã KH</td>
            <td>
                <asp:TextBox ID="txtMaKH" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style10">
                Tên KH</td>
            <td>
                <asp:TextBox ID="txtTenKH" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style10">
                Tên Đăng Nhập</td>
            <td>
                <asp:TextBox ID="txtTenDangNhap" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style10">
                Mật Khẩu</td>
            <td>
                <asp:TextBox ID="txtMatKhau" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style10">
                Địa Chỉ</td>
            <td>
                <asp:TextBox ID="txtDiaChi" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style10">
                Số ĐT</td>
            <td>
                <asp:TextBox ID="txtSoDT" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style10">
                CMND</td>
            <td>
                <asp:TextBox ID="txtCMND" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style10">
                Role</td>
            <td>
                <asp:DropDownList ID="ddlRole" runat="server">
                    <asp:ListItem Value="0">0</asp:ListItem>
                    <asp:ListItem Value="1">1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style10">
                <asp:Button ID="btnThem" runat="server" onclick="btnThem_Click" Text="Thêm" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

