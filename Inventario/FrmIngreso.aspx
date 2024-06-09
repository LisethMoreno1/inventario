<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <title>Formulario De Ingreso productos</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f0f0f0;
            padding: 20px;
        }

        .styled-form {
            max-width: 600px; 
            margin: 0 auto;
            padding: 20px;
            border: 1px solid #ccc;
            border-radius: 10px;
            background-color: #fff;
            box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
        }

        .form-group {
            margin-bottom: 15px;
        }

        .form-label {
            display: block;
            font-weight: bold;
            margin-bottom: 5px;
            color: #333;
        }

        .form-input {
            width: 100%;
            padding: 10px;
            border: 1px solid #ccc;
            border-radius: 5px;
            box-sizing: border-box;
        }

        .form-input:focus {
            border-color: #007bff;
            box-shadow: 0 0 5px rgba(0, 123, 255, 0.5);
        }

        .form-calendar {
            width: 100%;
            border: 1px solid #ccc;
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
    </style>
</head>
<body>
    <form id="form1" runat="server" class="styled-form">
        <div class="form-group">
            <asp:Label ID="Label1" runat="server" Text="Nombre" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-input"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="Label2" runat="server" Text="Tipo" CssClass="form-label"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-input"></asp:DropDownList>
        </div>
        <div class="form-group">
            <asp:Label ID="Label4" runat="server" Text="Categoria" CssClass="form-label"></asp:Label>
            <asp:DropDownList ID="DropDownList2" runat="server" CssClass="form-input"></asp:DropDownList>
        </div>
        <div class="form-group">
            <asp:Label ID="Label3" runat="server" Text="Cantidad" CssClass="form-label"></asp:Label>
            <input type="number" class="form-input" />
        </div>
        <div class="date-group">
            <div class="form-group">
                <asp:Label ID="Label5" runat="server" Text="Fecha de Vencimiento" CssClass="form-label"></asp:Label>
                <asp:Calendar ID="Calendar1" runat="server" CssClass="form-calendar"></asp:Calendar>
            </div>
            <div class="form-group">
                <asp:Label ID="Label6" runat="server" Text="Fecha de Registro" CssClass="form-label"></asp:Label>
                <asp:Calendar ID="Calendar2" runat="server" CssClass="form-calendar"></asp:Calendar>
            </div>
        </div>
        <button>Registrar</button>
    </form>
</body>
</html>
