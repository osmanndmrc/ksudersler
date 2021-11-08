<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication2.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            K.A:
            <asp:TextBox ID="tbKA" runat="server"></asp:TextBox>
            <br />
&nbsp;&nbsp;&nbsp; Ş:<asp:TextBox ID="tbSifre" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnİslem" runat="server" OnClick="btnİslem_Click" Text="Button" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
