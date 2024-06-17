<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmListado.aspx.cs" Inherits="Inventario.FrmListado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Listado de Inventario</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f0f0f0;
            padding: 20px;
            margin: 0;
        }

        .header {
            max-width: 800px;
            margin: 50px auto;
            padding: 30px;
            background-color: #fff;
            border-radius: 10px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
            display: flex;
            justify-content: space-between;
            align-items: center;
        }

        #LblBienvenida {
            font-size: 1.5em;
            color: #007bff;
        }

        #LkbCerrarSesion {
            font-size: 1em;
            color: #007bff;
            text-decoration: none;
            background: none;
            border: none;
            padding: 5px 10px;
            cursor: pointer;
            transition: color 0.3s ease;
        }

        #LkbCerrarSesion:hover {
            color: #0056b3;
        }

        #form1 {
            max-width: 100%;
            margin: 0 auto;
            padding: 20px;
            background-color: #fff;
            border-radius: 10px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
        }

        .inventory-table {
            width: 100%;
            border-collapse: collapse;
            margin-bottom: 20px;
        }

        .inventory-table th,
        .inventory-table td {
            border: 1px solid #ddd;
            padding: 10px;
            text-align: left;
        }

        .inventory-table th {
            background-color: #f2f2f2;
            font-weight: bold;
        }

        .inventory-table tbody tr:nth-child(even) {
            background-color: #f9f9f9;
        }

        .btn-editar,
        .btn-eliminar {
            padding: 5px 10px;
            margin-right: 5px;
            border: none;
            background-color: #007bff;
            color: #fff;
            cursor: pointer;
            border-radius: 5px;
            font-size: 14px;
            transition: background-color 0.3s ease;
        }

        .btn-editar:hover,
        .btn-eliminar:hover {
            background-color: #0056b3;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="header">
            <asp:Label ID="LblBienvenida" runat="server" Text="Bienvenido, Administrador"></asp:Label>
            <asp:LinkButton ID="LkbCerrarSesion" runat="server" OnClick="LkbCerrarSesion_Click">Cerrar Sesión</asp:LinkButton>
        </div>
        <div id="Lista" class="styled-form">
            <h2>Listado de Inventario</h2>
            <asp:GridView ID="GridView1" runat="server" CssClass="inventory-table" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="Tipo" HeaderText="Tipo" />
                    <asp:BoundField DataField="Categoria" HeaderText="Categoría" />
                    <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" />
                    <asp:BoundField DataField="FechaVencimiento" HeaderText="Fecha de Vencimiento" DataFormatString="{0:d}" />
                    <asp:BoundField DataField="FechaRegistro" HeaderText="Fecha de Registro" DataFormatString="{0:d}" />
                    <asp:TemplateField HeaderText="Acciones">
                        <ItemTemplate>
                            <asp:Button runat="server" Text="Editar" CssClass="btn-editar" />
                            <asp:Button runat="server" Text="Eliminar" CssClass="btn-eliminar" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
