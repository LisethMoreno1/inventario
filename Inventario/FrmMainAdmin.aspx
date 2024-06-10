<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmMainAdmin.aspx.cs" Inherits="Inventario.FrmMainAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Administración</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
            background-color: #f4f4f4;
        }
        #form1 {
            max-width: 800px;
            margin: 50px auto;
            padding: 20px;
            background: #fff;
            border: 1px solid #ddd;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }
        #form1 div {
            display: flex;
            justify-content: space-between;
            align-items: center;
        }
        #LblBienvenida {
            font-size: 1.2em;
            color: #333;
        }
        #LkbCerrarSesion {
            font-size: 1em;
            color: #007bff;
            text-decoration: none;
            background: none;
            border: none;
            padding: 5px 10px;
            cursor: pointer;
        }
        #LkbCerrarSesion:hover {
            color: #0056b3;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="LblBienvenida" runat="server" Text="Bienvenido, Administrador"></asp:Label>
            <asp:LinkButton ID="LkbCerrarSesion" runat="server" OnClick="LkbCerrarSesion_Click">Cerrar Sesión</asp:LinkButton>
        </div>
    </form>
</body>
</html>
