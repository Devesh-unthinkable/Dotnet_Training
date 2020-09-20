<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrossPagePostBack.aspx.cs" Inherits="PostBackVsCrossPagePostBack.CrossPagePostBack" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <table align="Center">
                <caption>Login Form</caption>
                <tr>
                    <td>Enter your name:</td>
                    <td><asp:TextBox ID="txtName" runat="server" Width="150px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Enter your password:</td>
                    <td><asp:Textbox ID="txtPwd" runat="server" Width="150px" TextMode="Password"></asp:TextBox></td>
                </tr>
                <tr>
                    <td align="Right"><asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" PostBackUrl="~/Validate.aspx"  /></td>
                    <td><asp:Button ID="btnReset" runat="server" Text="Reset" OnClick="btnReset_Click"/></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
