<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmListado.aspx.cs" Inherits="Inventario.FrmListado" MasterPageFile="~/Site.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>

        #LblBienvenida {
            font-size: 1.5em;
            color: #007bff;
        }

        #LkbCerrarSesion {
            font-size: 1em;
            color: #007bff;
            text-decoration: none;
            background-color:white;
            border: 1px solid white;
            border-radius: 5px;
            padding: 5px 10px;
            cursor: pointer;
            transition: color 0.3s ease;
        }

        #LkbCerrarSesion:hover {
            color: #0056b3;
            background-color: #EFE6E5;
        }

        #form1 {
            width: 100%;
            margin: 0 auto;
            padding: 20px;
            background-color: #fff;
            border-radius: 10px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
        }

        .inventory-table {
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
            padding: 8px 15px;
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
    <div>
        <div id="form1">
            <h2>Listado de Inventario</h2>
            <asp:GridView ID="GridView1" runat="server" CssClass="inventory-table " AutoGenerateColumns="False" OnRowDataBound="GridView1_RowDataBound" DataKeyNames="IdProducto">
                <Columns>
                    <asp:TemplateField HeaderText="Id">
                        <ItemTemplate>
                            <asp:TextBox ID="TxtIdProducto" runat="server" CssClass="form-control"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="RevIdProducto" runat="server" ControlToValidate="TxtIdProducto"
                                ErrorMessage="Solo se permiten números." ValidationExpression="^\d+$" Display="Dynamic" CssClass="text-danger"></asp:RegularExpressionValidator>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Nombre">
                        <ItemTemplate>
                            <asp:TextBox ID="TxtNombre" runat="server" CssClass="form-control"></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Tipo">
                        <ItemTemplate>
                            <asp:DropDownList ID="CmbTipoProducto" Enabled="false" runat="server" CssClass="form-control"></asp:DropDownList>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Categoria">
                        <ItemTemplate>
                            <asp:DropDownList ID="CmbCategoria" runat="server" CssClass="form-control"></asp:DropDownList>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Cantidad">
                        <ItemTemplate>
                            <asp:TextBox ID="TxtCantidad" runat="server" CssClass="form-control"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="RevCantidad" runat="server" ControlToValidate="TxtCantidad"
                                ErrorMessage="Solo se permiten números." ValidationExpression="^\d+$" Display="Dynamic" CssClass="text-danger"></asp:RegularExpressionValidator>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Fecha de Vencimiento">
                        <ItemTemplate>
                            <asp:TextBox ID="TxtFechaVencimiento" runat="server" CssClass="form-control"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="RevFechaVencimiento" runat="server" ControlToValidate="TxtFechaVencimiento"
                                ErrorMessage="Formato de fecha inválido. Use 'dd/MM/yyyy' o 'No Aplica' y sólo numeros."
                                ValidationExpression="^(?:\d{2}/\d{2}/\d{4}|No Aplica)$" Display="Dynamic" CssClass="text-danger"></asp:RegularExpressionValidator>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Fecha de Registro">
                        <ItemTemplate>
                            <asp:TextBox ID="TxtFechaRegistro" runat="server" CssClass="form-control"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="RevFechaRegistro" runat="server" ControlToValidate="TxtFechaRegistro"
                                ErrorMessage="Formato de fecha inválido. Use 'dd/MM/yyyy' y solo números."
                                ValidationExpression="^(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[0-2])/\d{4}$" Display="Dynamic" CssClass="text-danger"></asp:RegularExpressionValidator>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Acciones">
                        <ItemTemplate>
                            <asp:Button ID="BtnEditar" runat="server" Text="Editar" CssClass="btn-editar" OnClick="BtnEditar_Click" CommandArgument='<%# Eval("IdProducto") %>' />
                            <asp:Button ID="BtnEliminar" runat="server" Text="Eliminar" CssClass="btn-eliminar" OnClick="BtnEliminar_Click" CommandArgument='<%# Eval("IdProducto") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>

            <div class="form-group">
                <asp:Label ID="LblMensaje" runat="server" Text="" CssClass="text-danger"></asp:Label>
            </div>
            <div class="form-group">
                <asp:ValidationSummary ID="ValidationSummary3" runat="server" CssClass="text-danger" ValidationGroup="Grupo1" />
                <asp:ValidationSummary ID="ValidationSummary4" runat="server" CssClass="text-danger" ValidationGroup="Grupo2" />
            </div>
        </div>
    </div>
</asp:Content>
