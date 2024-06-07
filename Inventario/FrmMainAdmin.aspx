<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmMainAdmin.aspx.cs" Inherits="Inventario.FrmMainAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="LblBienvenida" runat="server" Text=""></asp:Label>
            <asp:LinkButton ID="LkbCerrarSesion" runat="server" OnClick="LkbCerrarSesion_Click">Cerrar Sesión</asp:LinkButton>
        </div>
    </form>
</body>
</html>
