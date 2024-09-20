<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio6.aspx.cs" Inherits="TuProyecto.Ejercicio6" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tabla de Multiplicación con Imágenes</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Seleccione un número para ver su tabla de multiplicar</h2>
            <table>
                <tr>
                    <td>?&gt;<asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/numero1.png" OnClick="ImageButton1_Click" /></td>
                    <td><asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/Images/numero2.png" OnClick="ImageButton2_Click" /></td>
                    <td><asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/Images/numero3.jpg" OnClick="ImageButton3_Click" /></td>
                </tr>
                <tr>
                    <td><asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="~/Images/numero4.jpg" OnClick="ImageButton4_Click" /></td>
                    <td><asp:ImageButton ID="ImageButton5" runat="server" ImageUrl="~/Images/numero5.jpg" OnClick="ImageButton5_Click" /></td>
                    <td><asp:ImageButton ID="ImageButton6" runat="server" ImageUrl="~/Images/numero6.jpg" OnClick="ImageButton6_Click" /></td>
                </tr>
                <tr>
                    <td><asp:ImageButton ID="ImageButton7" runat="server" ImageUrl="~/Images/numero7.jpg" OnClick="ImageButton7_Click" /></td>
                    <td><asp:ImageButton ID="ImageButton8" runat="server" ImageUrl="~/Images/numero8.jpg" OnClick="ImageButton8_Click" /></td>
                    <td><asp:ImageButton ID="ImageButton9" runat="server" ImageUrl="~/Images/numero9.jpg" OnClick="ImageButton9_Click" /></td>
                </tr>
            </table>

            <!-- Aquí se mostrará la tabla de multiplicación -->
            <asp:Label ID="lblTablaMultiplicar" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
