<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SamplePage.aspx.cs" Inherits="Firstwebapp.SamplePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <% Response.Write("My first app created in IIS express"); %>
        </div>
    </form>
</body>
</html>
