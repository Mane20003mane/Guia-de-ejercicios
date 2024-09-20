<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ejercicio4.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calculadora de Descuento</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin:20px;">
            <h2>Calculadora de Descuento</h2>
            
            <label for="txtMonto">Monto de la Compra:</label>
            <asp:TextBox ID="txtMonto" runat="server"></asp:TextBox>
            <br /><br />
            
            <asp:Button ID="btnCalcular" runat="server" Text="Calcular Descuento" OnClick="btnCalcular_Click" />
            <br /><br />
            
            <asp:Label ID="lblResultado" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
