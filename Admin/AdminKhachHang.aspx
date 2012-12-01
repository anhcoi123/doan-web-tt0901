<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminPage.master" AutoEventWireup="true" CodeFile="AdminKhachHang.aspx.cs" Inherits="Admin_AdminKhachHang" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style9
        {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p style="text-align: left">
        QUẢN LÝ USER
    </p>
    <p style="text-align: right">
        <asp:Button ID="btnThemKH" runat="server" Text="Thêm User" 
            onclick="btnThemKH_Click" />
    </p>
    <p style="text-align: left">
        <table class="style9">
            <tr>
                <td>
                    MÃ KH</td>
                <td>
                    TÊN KH</td>
                <td>
                    TÊN ĐĂNG NHẬP</td>
                <td>
                    MẬT KHẨU</td>
                <td>
                    ĐỊA CHỈ</td>
                <td>
                    SỐ ĐT</td>
                <td>
                    CMND</td>
                <td>
                    TRẠNG THÁI</td>
                <td>
                    &nbsp;</td>
            </tr>
            <asp:Repeater ID="load" runat="server">
            <ItemTemplate>
            <tr>
                <td><%# Eval("MAKH") %></td>
                <td><%# Eval("TENKH") %></td>
                <td><%# Eval("TENDANGNHAP")%></td>
                <td><%# Eval("MATKHAU") %></td>
                <td><%# Eval("DIACHI")%></td>
                <td><%# Eval("SODT") %></td>
                <td><%# Eval("CMND") %></td>
                <td><%# Eval("ROLE") %></td>
                <td><a href="AdminKhachHang_SuaKH.aspx?MAKH=<%# Eval("MAKH") %>>">Sửa</a></td>
            </tr>
            </ItemTemplate>
            </asp:Repeater>
        </table>
        <br />
    </p>
</asp:Content>

