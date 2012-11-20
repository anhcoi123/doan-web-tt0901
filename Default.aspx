<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script language="javascript">
    var i = 0;
    setTimeout(chay, 1000);
    function chay() {
        $('#test').fadeOut(500, function () {
            $('#test').attr("src",($('#SP img').eq(i).attr("src")));
            $('#test').fadeIn(2000,function(){
                i++;
                if (i >= $('#SP img').length) i = 0;
                setTimeout(chay, 1000);
                });
            });
    }
    
    function enLarge(a,b) {
        if (b) {
            $('#list' + a).css({'z-index': '+=99'});
            $('#list' + a).animate({ 'width': '+=50', 'height': '+=50','left':'-=25','top':'-=25'}, 'slow');
        }
        else {
            $('#list' + a).css({'z-index': '-=99' });
            $('#list' + a).animate({ 'width': '-=50', 'height': '-=50', 'left': '+=25', 'top': '+=25' }, 'slow');
        }
        //$('#list' + a).animate({ 'font-size': $('#list' + a).attr('font-size').valueOf() + 50}, 'fast');
    }

</script>
    <div style="height:300px">
    <img id="test" width=300 height=300/>
    </div>
   <div style="margin-left:10px" id="SP">
   <ul >
    <asp:Repeater ID="load" runat="server">
        <ItemTemplate>
            
                <li id="list<%# Eval("MALK") %>" style="list-style-position:inside;float:left">
                    <img id="listh<%# Eval("MALK") %>" src="<%# Eval("HINHANH") %>"  onmouseover="enLarge('h<%# Eval("MALK") %>',true)" onmouseout="enLarge('h<%# Eval("MALK") %>',false)" style="position:relative;float:left;"/><br />
                    <%#Eval("TENLK") %><br />
                    <%#Eval("DONGIA") %>
                </li>
            
        </ItemTemplate>
    </asp:Repeater>
    </ul>
    </div>
</asp:Content>

