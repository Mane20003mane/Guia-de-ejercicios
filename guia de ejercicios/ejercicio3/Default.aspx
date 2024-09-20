<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalculoDescuento.aspx.cs" Inherits="DescuentoCalculator.CalculoDescuento" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calculadora de Descuento</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Calculadora de Descuento</h2>
            <asp:Label ID="lblCantidadArticulos" runat="server" Text="Cantidad de Artículos:"></asp:Label>
            <asp:TextBox ID="txtCantidadArticulos" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Label ID="lblPrecioUnitario" runat="server" Text="Precio Unitario:"></asp:Label>
            <asp:TextBox ID="txtPrecioUnitario" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Button ID="btnCalcular" runat="server" Text="Calcular Total a Pagar" OnClick="btnCalcular_Click" />
            <br /><br />
            <asp:Label ID="lblResultado" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>