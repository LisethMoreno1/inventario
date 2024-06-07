<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmLogin.aspx.cs" Inherits="Presentacion.FrmLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="LblUsername" runat="server" Text="Username"></asp:Label>

        </div>

        <div>
            <asp:TextBox ID="TxtUsername" runat="server"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="LblPassword" runat="server" Text="Password"></asp:Label>
        </div>

        <div>
            <asp:TextBox ID="TxtPassword" runat="server" TextMode="Password"></asp:TextBox>
        </div>
        <div>

            <asp:Button ID="BtnLogin" runat="server" Text="Login" OnClick="BtnLogin_Click" />
            <asp:Button ID="BtnHome" runat="server" Text="Home" />
            
        </div>
        <div>
            <asp:Label ID="LblMensaje" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>

