<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmMainAdmin.aspx.cs" Inherits="Inventario.FrmMainAdmin" MasterPageFile="~/Site.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
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
    <div id="form1">
        <div>
            <asp:Label ID="LblBienvenida" runat="server" Text="Bienvenido, Administrador"></asp:Label>
        </div>
        <p>En este aplicativo podrá registrar productos, actualizarlos y eliminarlos</p>
    </div>
</asp:Content>
