<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SalarioNetoCalculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calculadora de Salario Neto</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Calculadora de Salario Neto</h2>
            <asp:Label ID="LblSalarioBruto" runat="server" Text="Salario Bruto:"></asp:Label>
            <asp:TextBox ID="TxtSalarioBruto" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Button ID="BtnCalcular" runat="server" Text="Calcular Salario Neto" OnClick="BtnCalcular_Click" />
            <br /><br />
            <asp:Label ID="LblResultado" runat="server"></asp:Label>
            <br />
            <asp:Label ID="LblDescuentoIsss" runat="server"></asp:Label>
            <br />
            <asp:Label ID="LblDescuentoRenta" runat="server"></asp:Label>
            <br />
            <asp:Label ID="LblDescuentoAfp" runat="server"></asp:Label>
            <br />
            <asp:Label ID="LblDescuentoSeguro" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>