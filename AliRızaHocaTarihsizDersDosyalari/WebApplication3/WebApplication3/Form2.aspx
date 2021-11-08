<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form2.aspx.cs" Inherits="WebApplication3.Form2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-top: 2px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            K.A.
            <asp:TextBox ID="tbKA" runat="server"></asp:TextBox>
            <br />
&nbsp;&nbsp;&nbsp; Ş:
            <asp:TextBox ID="tbS" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" CssClass="auto-style1" OnClick="Button1_Click" Text="Giriş" />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox1_CheckedChanged" Text="Kapat" />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" OnTextChanged="RadioButtonList1_TextChanged">
                <asp:ListItem>Kırmızı</asp:ListItem>
                <asp:ListItem>Yeşil</asp:ListItem>
                <asp:ListItem>Beyaz</asp:ListItem>
                <asp:ListItem>Siyah</asp:ListItem>
            </asp:RadioButtonList>
            <asp:Label ID="lblRadioButtons" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:CheckBoxList ID="CheckBoxList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged" OnTextChanged="CheckBoxList1_TextChanged">
                <asp:ListItem>Beyaz</asp:ListItem>
                <asp:ListItem>Siyah</asp:ListItem>
            </asp:CheckBoxList>
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
