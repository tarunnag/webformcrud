<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="edit.aspx.cs" Inherits="WebApplication.edit" %>

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
                <tr><td><asp:Button ID="update" runat="server" Text="update" OnClick="update_Click"  /></td></tr>
                <tr><td> class="auto style 2"<asp:Label ID="message2" runat="server" ></asp:Label></td></tr>
                <tr><td><asp:TextBox ID="passvalue2"  runat="server"></asp:TextBox> </td></tr>
              </table>
        </div>
    </form>
</body>
</html>
