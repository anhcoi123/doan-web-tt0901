<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="manufacturer.aspx.cs" Inherits="manufacturer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
<%=title %>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="top">
    <div class="left"></div>
    <div class="right"></div>
    <div class="center">
      <h1>
        <%=title %>
      </h1>
    </div>
  </div>
    <div class="middle">
        <div class="sort">
            <div class="div1">
                <asp:DropDownList ID="sortList" runat="server" 
                    onselectedindexchanged="sortList_SelectedIndexChanged" AutoPostBack="True">
                    <asp:ListItem Selected="True" Value="default">Mặc định</asp:ListItem>
                    <asp:ListItem Value="az">Theo tên A-Z</asp:ListItem>
                    <asp:ListItem Value="za">Theo tên Z-A</asp:ListItem>
                    <asp:ListItem Value="hl">Theo giá Cao-Thấp</asp:ListItem>
                    <asp:ListItem Value="lh">Theo giá Thấp-Cao</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="div2">Sắp xếp theo: </div>
        </div>
    <asp:DataList ID="LoadManufactuter" runat="server" RepeatColumns="4">
        <ItemTemplate>
            
        <table class="list">
          <tr>
            <td width="25%">
              <a href="./product.aspx?id=<%#Eval("MALK") %>"><div class="example" style="width:150px; height:150px; overflow:visible"><img id="img<%# Eval("MALK") %>" src="./<%#Eval("HINHANH") %>" title="<%#Eval("TENLK") %>" alt="<%#Eval("TENLK") %>" class="imgzoom" style="margin-left:15px;margin-top:15px; position:relative;float:left; width:120px; height:120px; cursor:pointer;overflow:visible;"/></div></a><br />
              <a href="./product.aspx?id=<%#Eval("MALK") %>"><%#Eval("TENLK") %></a><br />
              <span style="color: #900; font-weight: bold"><%#Eval("DONGIA","{0:###,###,##0}")%>,000 VNĐ</span><br />
              <a class="button_add_small" title="Thêm vào giỏ hàng" onclick="themVaoGH('<%# Eval("MALK") %>','1')">&nbsp;&nbsp;Thêm</a>
              <br />
            </td>
          </tr>
        </table>
        <div class="pagination"></div>
        </ItemTemplate>
    </asp:DataList>
    <asp:Label ID="txtNoData" runat="server"></asp:Label>
	
  </div>
  <div class="bottom">
    <div class="left"></div>
    <div class="right"></div>
    <div class="center"></div>
  </div>

</asp:Content>

