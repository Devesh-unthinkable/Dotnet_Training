<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DatabaseBuilder.aspx.cs" Inherits="DataManagementSystem.DatabaseBuilder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="Center">
                <caption>Database System</caption>
                <tr>
                    <td>Dept ID:</td>
                    <td><asp:TextBox ID="txt_DeptName" runat="server" Width="150px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Dept Name:</td>
                    <td><asp:Textbox ID="txt_DeptId" runat="server" Width="150px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Location ID:</td>
                    <td><asp:Textbox ID="txt_LocationId" runat="server" Width="150px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Button ID="btn_Add" runat="server" Text="Add" OnClick="btn_Add_Click" Width="80px"/></td>
                    <td><asp:Button ID="btn_Save" runat="server" Text="Save" OnClick="btn_Save_Click" Width="77px"/></td>
                </tr>
                <tr>
                    <td><asp:Button ID="btn_Search" runat="server" Text="Search" OnClick="btn_Search_Click" Width="79px"/></td>
                    <td><asp:Button ID="btn_Update" runat="server" Text="Update" OnClick="btn_Update_Click"/></td>
                </tr>
                <tr>
                    <td><asp:Button ID="btn_Delete" runat="server" Text="Delete" OnClick="btn_Delete_Click" Width="80px"/></td>
                </tr>
        </div>
    </form>
</body>
</html>
