<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="add.aspx.cs" Inherits="WebApplication.add" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr><td> studentname:<asp:TextBox ID="studentname" runat="server"></asp:TextBox></td></tr>
                <tr> <td> branch:<asp:TextBox ID="branch" runat="server"></asp:TextBox></td></tr>
                <tr><td> division:<asp:TextBox ID="division" runat="server"></asp:TextBox></td></tr>
                <tr><td><asp:Button ID="insert" runat="server" Text="insert" OnClick="insert_Click" /></td></tr>
                <tr><td><asp:Label ID="message" runat="server" ></asp:Label></td></tr>
              </table>
        </div>
    </form>
</body>
</html>
