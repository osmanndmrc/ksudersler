<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="W26102021.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            <br />
            K.A:<asp:TextBox ID="tbKADI" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
            <br />
&nbsp;&nbsp;&nbsp; Ş:
            <asp:TextBox ID="tbSifre" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <asp:Button ID="btGiris" runat="server" OnClick="btGiris_Click" Text="Giriş" />
            <br />
            <asp:Label ID="lblSonuc" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <br />
            EKLE<br />
            K.A:<asp:TextBox ID="tbEkleKADI" runat="server"></asp:TextBox>
            <br />
&nbsp;&nbsp;&nbsp; Ş:<asp:TextBox ID="tbEkleSifre" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnEkle" runat="server" OnClick="btnEkle_Click" Text="Ekle" />
            <br />
            <br />
            SİL<br />
&nbsp; ID:<asp:TextBox ID="tbDegistirID" runat="server"></asp:TextBox>
            <br />
            K.A:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
&nbsp;&nbsp;&nbsp; Ş:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnSil" runat="server" OnClick="btnSil_Click" Text="Button" />
            <br />
            <asp:Label ID="lblSil" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            ID:
            <asp:TextBox ID="tbDID" runat="server"></asp:TextBox>
            <br />
            K.A:<asp:TextBox ID="tbDKADI" runat="server"></asp:TextBox>
            <br />
&nbsp;&nbsp;&nbsp; Ş:<asp:TextBox ID="tbDSifre" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnDuzelt" runat="server" OnClick="btnDuzelt_Click" Text="Değiştir" />
            <br />
            <asp:Label ID="lblD" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
