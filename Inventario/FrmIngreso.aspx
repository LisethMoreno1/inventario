<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmIngreso.aspx.cs" Inherits="Inventario.FrmIngreso" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
    <title>Formulario De Ingreso de Productos</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f0f8ff;
            margin: 0;
            padding: 0;
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
            max-width: 60%;
            max-height: 100%;
            margin: 0 auto;
            padding: 20px;
            background-color: #fff;
            border-radius: 10px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
        }

        .styled-form {
            width: 98%;
            padding: 10px;
            border-radius: 10px;
            background-color: #fff;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
            margin-top: 20px;
        }


        .form-group {
            margin-bottom: 15px;
        }

        .form-label {
            display: block;
            font-weight: bold;
            margin-bottom: 5px;
            color: #007bff;
        }

        .form-input {
            width: 100%;
            padding: 12px;
            border: 1px solid #ddd;
            border-radius: 5px;
            box-sizing: border-box;
            font-size: 16px;
        }

            .form-input:focus {
                border-color: #007bff;
                box-shadow: 0 0 5px rgba(0, 123, 255, 0.5);
            }

        .form-calendar {
            width: 100%;
            border: 1px solid #ddd;
            border-radius: 5px;
            padding: 5px;
            background-color: #fff;
        }

        .date-group {
            display: flex;
            justify-content: space-between;
            gap: 20px;
        }

            .date-group .form-group {
                flex: 1;
            }

            .date-group .form-calendar {
                width: 100%;
            }

        .button {
            width: 100%;
            padding: 12px;
            background-color: #007bff;
            color: #fff;
            border: none;
            border-radius: 5px;
            font-size: 16px;
            cursor: pointer;
            transition: background-color 0.3s ease;
        }

            .button:hover {
                background-color: #0056b3;
            }

        .text-danger {
            color: red;
        }
    </style>
</head>
<body>


    <form id="form1" runat="server">
        <div class="header">
            <asp:Label ID="LblBienvenida" runat="server" Text="Bienvenido, Administrador"></asp:Label>
            <asp:LinkButton ID="LkbCerrarSesion" runat="server" OnClick="LkbCerrarSesion_Click">Cerrar Sesión</asp:LinkButton>
        </div>

        <div class="styled-form">
            <div class="form-group">
                <asp:Label ID="LblNombre" runat="server" Text="Nombre" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="TxtNombre" runat="server" CssClass="form-input"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="LblTipo" runat="server" Text="Tipo" CssClass="form-label"></asp:Label>
                <asp:DropDownList ID="CmbTipoProducto" runat="server" CssClass="form-input"></asp:DropDownList>
            </div>
            <div class="form-group">
                <asp:Label ID="LblCategoria" runat="server" Text="Categoría" CssClass="form-label"></asp:Label>
                <asp:DropDownList ID="CmbCategoria" runat="server" CssClass="form-input"></asp:DropDownList>
            </div>
            <div class="form-group">
                <asp:Label ID="LblCantidad" runat="server" Text="Cantidad" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="TxtCantidad" runat="server" CssClass="form-input"></asp:TextBox>
            </div>
            <div class="date-group">
                <div class="form-group">
                    <asp:Label ID="LblFechaVencimiento" runat="server" Text="Fecha de Vencimiento" CssClass="form-label"></asp:Label>
                    <asp:Calendar ID="CalFechaVencimiento" runat="server" CssClass="form-calendar"></asp:Calendar>
                </div>
                <div class="form-group">
                    <asp:Label ID="LblFechaRegistro" runat="server" Text="Fecha de Registro" CssClass="form-label"></asp:Label>
                    <asp:Calendar ID="CalFechaRegistro" runat="server" CssClass="form-calendar"></asp:Calendar>
                </div>
            </div>
            <div class="form-group">
                <asp:Label ID="LblMensaje" runat="server" Text="" CssClass="text-danger"></asp:Label>
            </div>
            <div class="form-group">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="text-danger" ValidationGroup="Grupo1" />
                <asp:ValidationSummary ID="ValidationSummary2" runat="server" CssClass="text-danger" ValidationGroup="Grupo2" />
            </div>
            <asp:Button ID="BtnRegistro" runat="server" CssClass="button" ValidationGroup="Grupo1" OnClick="BtnRegistro_Click" Text="Registrar" />
        </div>
    </form>
</body>
</html>
