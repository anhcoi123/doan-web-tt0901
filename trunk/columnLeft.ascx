<%@ Control Language="C#" AutoEventWireup="true" CodeFile="columnLeft.ascx.cs" Inherits="columnLeft" %>
<div id="column_left">
    <div class="box">
      <div class="top"><img src="./image/category.png" alt="" />Loại sản phẩm</div>
      <div id="category" class="middle">
      <ul>
      <asp:Repeater ID="LoadLoaiLK" runat="server">
        <ItemTemplate>
            <li>
                <a href="./category.aspx?&maloailk=<%# Eval("MALOAILK")%>"><%# Eval("TENLOAILK") %></a>
            </li>
        </ItemTemplate>
        </asp:Repeater>
        </ul>
      </div>
      <div class="bottom">&nbsp;</div>
    </div>
    <div class="box">
      <div class="top"><img src="./image/brands.png" alt="" />Nhà sản xuất</div>
      <div id="category" class="middle">
      <ul>
      <asp:Repeater ID="LoadNhaSX" runat="server">
        <ItemTemplate>
            <li>
                <a href="./manufacturer.aspx?&mansx=<%# Eval("MANSX")%>"><%# Eval("TENNSX") %></a>
            </li>
        </ItemTemplate>
        </asp:Repeater>
        </ul>
      </div>
      <div class="bottom">&nbsp;</div>
    </div>
</div>
