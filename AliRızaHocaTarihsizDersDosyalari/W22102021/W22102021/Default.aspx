<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="W22102021.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            BOŞ<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <br />
            <br />
            KA:
            <asp:TextBox ID="tbKA" runat="server"></asp:TextBox>
            <br />
            Ş:&nbsp;
            <asp:TextBox ID="tbS" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Giriş" />
            <br />
            <asp:Label ID="lbDurum" runat="server" Text="-"></asp:Label>
        </div>
    </form>
</body>
</html>
