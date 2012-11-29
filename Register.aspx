<%@ Page Title="Register" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Register.aspx.cs" Inherits="Account_Register" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
<form runat="server">
<asp:CreateUserWizard ID="RegisterUser" Runat="server" OnCreatedUser="RegisterUser_CreatedUser">
  <WizardSteps>
    <asp:CreateUserWizardStep ID="CreateUserWizardStep1" runat="server">
    <ContentTemplate>
        <table border="0" style="font-size: 100%; font-family: Verdana">
            <tr>
                <td align="center" colspan="2" style="font-weight: bold; color: white; background-color: #5d7b9d">
                    Sign Up for Your New Account</td>
            </tr>
            <tr>
                <td align="right">
                    <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">
                        User Name:</asp:Label></td>
                <td>
                    <asp:TextBox ID="UserName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName"
                        ErrorMessage="User Name is required." ToolTip="User Name is required." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td align="right">
                    <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">
                        Password:</asp:Label></td>
                <td>
                    <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password"
                        ErrorMessage="Password is required." ToolTip="Password is required." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td align="right">
                    <asp:Label ID="ConfirmPasswordLabel" runat="server" AssociatedControlID="ConfirmPassword">
                        Confirm Password:</asp:Label></td>
                <td>
                    <asp:TextBox ID="ConfirmPassword" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="ConfirmPasswordRequired" runat="server" ControlToValidate="ConfirmPassword"
                        ErrorMessage="Confirm Password is required." ToolTip="Confirm Password is required."
                        ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td align="right">
                    <asp:Label ID="EmailLabel" runat="server" AssociatedControlID="Email">
                        E-mail:</asp:Label></td>
                <td>
                    <asp:TextBox ID="Email" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="EmailRequired" runat="server" ControlToValidate="Email"
                        ErrorMessage="E-mail is required." ToolTip="E-mail is required." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td align="right">
                    <asp:Label ID="QuestionLabel" runat="server" AssociatedControlID="Question">
                        Security Question:</asp:Label></td>
                <td>
                    <asp:TextBox ID="Question" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="QuestionRequired" runat="server" ControlToValidate="Question"
                        ErrorMessage="Security question is required." ToolTip="Security question is required."
                        ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td align="right">
                    <asp:Label ID="AnswerLabel" runat="server" AssociatedControlID="Answer">
                        Security Answer:</asp:Label></td>
                <td>
                    <asp:TextBox ID="Answer" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="AnswerRequired" runat="server" ControlToValidate="Answer"
                        ErrorMessage="Security answer is required." ToolTip="Security answer is required."
                        ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td align="center" colspan="2">
                    <asp:CompareValidator ID="PasswordCompare" runat="server" ControlToCompare="Password"
                        ControlToValidate="ConfirmPassword" Display="Dynamic" ErrorMessage="The Password and Confirmation Password must match."
                        ValidationGroup="CreateUserWizard1"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td align="center" colspan="2" style="color: red">
                    <asp:Literal ID="ErrorMessage" runat="server" EnableViewState="False"></asp:Literal>
                </td>
            </tr>
        </table>
        <asp:CheckBox ID="SubscribeCheckBox" runat="server" Checked="True" Text="Send me a monthly newsletter." />
        <br />
        <asp:CheckBox ID="ShareInfoCheckBox" runat="server" Checked="True" Text="Share my information with partner sites." />
    </ContentTemplate>
    
</asp:CreateUserWizardStep>
</WizardSteps>
</asp:CreateUserWizard>
</form>
</asp:Content>