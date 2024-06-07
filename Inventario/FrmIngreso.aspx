<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmIngreso.aspx.cs" Inherits="Inventario.FrmIngreso" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Tipo"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
        </div>
        <div>
            <asp:Label ID="Label4" runat="server" Text="Categoria"></asp:Label>
            <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList>
        </div>
        <div>
            <asp:Label ID="Label3" runat="server" Text="Cantidad"></asp:Label>
            <input type="number" />
        </div>
        <div>
            <asp:Label ID="Label5" runat="server" Text="Fecha de Vencimiento"></asp:Label>
            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        </div>
        <div>
            <asp:Label ID="Label6" runat="server" Text="Fecha de Registro"></asp:Label>
            <asp:Calendar ID="Calendar2" runat="server"></asp:Calendar>
        </div>
        <div>
    <asp:Label ID="Label7" runat="server" Text="Fecha de hola"></asp:Label>
    <asp:Calendar ID="Calendar3" runat="server"></asp:Calendar>
</div>
    </form>
</body>
</html>
