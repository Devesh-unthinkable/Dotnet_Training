<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HiddenField.aspx.cs" Inherits="StateManagement.HiddenField" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnClickMe" runat="server" Text="Click Me" OnClick="btnClick_Click" />
            <asp:Button ID="btnOtherPage" runat="server" Text="Go to other Page" PostBackUrl="~/HiddenFieldValue.aspx" />
            <asp:HiddenField ID="hfCount" runat="server" Value="0"/>
        </div>
    </form>
</body>
</html>
