<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminPage.master" AutoEventWireup="true" CodeFile="AdminLinhKien.aspx.cs" Inherits="Admin_AdminLinhKien" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style9
        {
            width: 100%;
        }
        .style10
        {
        }
        .style11
        {
            width: 64px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style9">
        <tr>
            <td class="style10" colspan="7">
                QUẢN LÝ LINH KIỆN</td>
            <td colspan="2">
                <asp:Button ID="btnThemLK" runat="server" onclick="btnThemLK_Click" 
                    Text="Thêm LK" Width="61px" />
            </td>
            
        </tr>
        <tr>
            <td class="style10">
                MÃ MH</td>
            <td class="style11">
                TÊN MH</td>
            <td>
                ĐV TÍNH</td>
            <td>
                SỐ LƯỢNG</td>
            <td>
                ĐƠN GIÁ</td>
            <td>
                THÔNG TIN</td>
            <td>
                HÌNH ẢNH</td>
            <td>
                XÓA</td>
            
            <td>
                SỬA</td>
            
        </tr>
        <asp:Repeater ID="load" runat="server">
            <ItemTemplate>
            <tr>
            <td><%# Eval("MALK") %></td>
            <td><%# Eval("TENLK") %></td>
            <td><%# Eval("DVTINH") %></td>
            <td><%# Eval("SOLUONG")%></td>
            <td><%# Eval("DONGIA")%></td>
            <td><%# Eval("THONGTIN") %></td>
            <td><%# Eval("HINHANH") %></td>
            <td><a href="AdminLinhKien_SuaLK.aspx?MALK=<%#Eval(MALK) %>">Sửa</a></td>
            <td></td>
            
            </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
</asp:Content>

