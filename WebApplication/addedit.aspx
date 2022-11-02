<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addedit.aspx.cs" Inherits="WebApplication.WebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">       
            
                <div>
                    <table><tr><td> <asp:Button ID="add" runat="server" Text="add" OnClick="add_Click" />
                        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList>
                        <asp:Button ID="edit" runat="server" Text="edit" OnClick="edit_Click" /></td></tr></table>
                    <tr><td><asp:TextBox ID="passvalue"  runat="server"></asp:TextBox></td></tr>
                        
                </div>
    </form>
</body>
</html>
