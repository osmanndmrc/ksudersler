<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="W19102021.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Kullanıcı Adı:<asp:TextBox ID="tbKA" runat="server"></asp:TextBox>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Şifre:<asp:TextBox ID="tbSifre" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnGiris" runat="server" OnClick="btnGiris_Click" Text="Giriş" />
            <br />
            <asp:Label ID="lblSonuc" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
