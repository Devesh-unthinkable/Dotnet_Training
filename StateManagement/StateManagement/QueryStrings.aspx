<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QueryStrings.aspx.cs" Inherits="StateManagement.QueryStrings" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div align="center"> 
            <h3>
                Login
            </h3>
            <table>
               <tr>
                   <td>Name:</td>
                   <td><asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
               </tr>
               <tr>
                   <td>Password:</td>
                   <td><asp:TextBox ID="txtPwd" runat="server" TextMode="Password"></asp:TextBox></td>
               </tr>
               <tr>
                   <td align="right"><asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" /></td>
                   <td><asp:Button ID="btnReset" runat="server" Text="Reset" OnClick="btnReset_Click" /></td>
               </tr>
            </table>
        </div>
    </form>
</body>
</html>
