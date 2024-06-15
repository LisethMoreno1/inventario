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
            <asp:Table ID="TableProductos" runat="server" CssClass="table table-striped">
    <asp:TableHeaderRow>
        <asp:TableHeaderCell>Nombre</asp:TableHeaderCell>
        <asp:TableHeaderCell>Tipo</asp:TableHeaderCell>
        <asp:TableHeaderCell>Categoría</asp:TableHeaderCell>
        <asp:TableHeaderCell>Cantidad</asp:TableHeaderCell>
        <asp:TableHeaderCell>Fecha Vencimiento</asp:TableHeaderCell>
        <asp:TableHeaderCell>Fecha Registro</asp:TableHeaderCell>
    </asp:TableHeaderRow>

</asp:Table>

            <table class="inventory-table">
                <thead>
                    <tr>
                        <th>Nombre</th>
                        <th>Tipo</th>
                        <th>Categoría</th>
                        <th>Cantidad</th>
                        <th>Fecha de Vencimiento</th>
                        <th>Fecha de Registro</th>
                        <th>Acciones</th>
                    </tr>
                </thead>
                <tbody>
                   
                    <tr>
                        <td>Ejemplo1</td>
                        <td>Producto</td>
                        <td>Electrónicos</td>
                        <td>10</td>
                        <td>2024-06-30</td>
                        <td>2024-05-20</td>
                         <td><button>Editar</button><button>Eliminar </button></td>
                    </tr>
                    <tr>
                        <td>Ejemplo2</td>
                        <td>Servicio</td>
                        <td>Software</td>
                        <td>5</td>
                        <td>2024-07-15</td>
                        <td>2024-05-25</td>
                        <td><button>Editar</button><button>Eliminar </button></td>
                    </tr>
                    
                </tbody>
            </table>
        </div>
    </form>
</body>
</html>
