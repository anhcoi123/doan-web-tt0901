<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminPage.master" AutoEventWireup="true" CodeFile="AdminLinhKien_ThemLK.aspx.cs" Inherits="Admin_AdminLinhKien_ThemLK" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style9
        {
            width: 100%;
        }
        .style10
        {
            text-align: left;
        }
        .style12
        {
            text-align: right;
            width: 387px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style9">
        <tr>
            <td class="style12">
                THÊM CHI TIẾT
            </td>
            <td class="style10">
                LINH KIỆN</td>
        </tr>
        <tr>
            <td class="style12">
                Mã Linh Kiện</td>
            <td>
                <asp:TextBox ID="txtMaLK" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style12">
                Tên Linh kiện</td>
            <td>
                <asp:TextBox ID="txtTenLK" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style12">
                Số Lượng</td>
            <td>
                <asp:TextBox ID="txtSoLuong" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style12">
                Đơn Giá</td>
            <td>
                <asp:TextBox ID="txtDonGia" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style12">
                Thông Tin</td>
            <td>
                <asp:TextBox ID="txtThongTin" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style12">
                Hình ảnh</td>
            <td>
                <asp:FileUpload ID="fileUpImage" runat="server" />
            </td>
        </tr>
        <tr>
            <td class="style12">
                Mã Loại Linh Kiện</td>
            <td>
                <asp:DropDownList ID="ddlMaLoaiLK" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style12">
                Mã Nhà Sản Xuất</td>
            <td>
                <asp:DropDownList ID="ddlMaNSX" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style12">
                &nbsp;</td>
            <td>
                <asp:Button ID="btnThem" runat="server" onclick="btnThem_Click" Text="Thêm" />
            </td>
        </tr>
    </table>
</asp:Content>

