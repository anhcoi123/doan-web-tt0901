<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script language=javascript>
    var i = 0;
    setTimeout(chay, 1000);
    function chay() {
        $('#test').fadeOut(500, function () {
            $('#test').html($('#SP li').eq(i).html());
            $('#test').fadeIn(2000,function(){
                i++;
                if (i >= $('#SP li').length) i = 0;
                setTimeout(chay, 1000);
                });
            });
    }

    function enLarge(a) {
        $('#list' + a).css({ 'width': $('#list' + a).width() + 100, 'height': $('#list' + a).height() + 100 });
        //$('#list' + a).animate({ 'font-size': $('#list' + a).attr('font-size').valueOf() + 50}, 'fast');
    }
    function unenLarge(a) {
        $('#list' + a).css({ 'width': $('#list' + a).width() - 100, 'height': $('#list' + a).height() - 100 });
        //$('#list' + a).animate({ 'font-size': $('#list' + a).attr('font-size').valueOf() - 50 }, 'fast');
    }

</script>
    <div id="test"><ul>
    <li></li><li></li></ul></div>
   <div style="margin-left:10px" id="SP">
    <asp:Repeater ID="load" runat="server">
        <ItemTemplate>
            <ul style="float:left">
                <li id="list<%# Eval("MALK") %>" onmouseover="enLarge('<%# Eval("MALK") %>')" onmouseout="unenLarge('<%# Eval("MALK") %>')">
                    <%#Eval("TENLK") %><br />
                    <%#Eval("DONGIA") %>
                </li>
            </ul>
        </ItemTemplate>
    </asp:Repeater>
    </div>
    <img id="listabc" onmouseover="enLarge('abc')" src="images/desktop_aurora_borealis.png" onmouseout="unenLarge('abc')"></img>
</asp:Content>

