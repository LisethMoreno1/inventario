<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmListado.aspx.cs" Inherits="Inventario.FrmListado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Listado de Inventario</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f0f0f0;
            padding: 20px;
        }

        .inventory-table {
            width: 100%;
            border-collapse: collapse;
            margin-bottom: 20px;
        }

        .inventory-table th,
        .inventory-table td {
            border: 1px solid #ddd;
            padding: 8px;
            text-align: left;
        }

        .inventory-table th {
            background-color: #f2f2f2;
        }

        .inventory-table tbody tr:nth-child(even) {
            background-color: #f9f9f9;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
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
