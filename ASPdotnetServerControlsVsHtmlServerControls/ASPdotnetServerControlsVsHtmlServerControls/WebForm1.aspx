<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ASPdotnetServerControlsVsHtmlServerControls.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID = "textbox1" runat = "server" />
            <asp:Button ID = "button1" runat = "server" Text ="Click me" ForeColor ="Black" />
            <br />
            <input type = "textbox" ID = "textbox2" />
            <input type = "submit" ID = "button2" value = "Click me" />
            <br />
            <input id="Text1" type="text" />
            <input id="Button3" type="button" value="button" />
            <br />
        </div>
    </form>
</body>
</html>
