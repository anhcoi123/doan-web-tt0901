<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <div style="width:1200px; margin-left:130px">
    <asp:Repeater ID="load" runat="server">
        <ItemTemplate>
            <ul >
                <li id="list" style="float:left;margin-top:100px; background-color:Black; width:200px; height:100px; color:White">
                    <%#Eval("TENLK") %><br />
                    <%#Eval("DONGIA") %><br />
                </li>
            </ul>
        </ItemTemplate>
    </asp:Repeater>
    </div>
</asp:Content>

