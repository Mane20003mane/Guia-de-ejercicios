<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="leernotas.aspx.cs" Inherits="ejercicio4.leernotas" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Leer Notas</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table border="1">
            <tr>
                <td>Alumno:</td>
                <td><asp:TextBox ID="txtAlumno" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>E1:</td>
                <td><asp:TextBox ID="txtE1" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>E2:</td>
                <td><asp:TextBox ID="txtE2" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>E3:</td>
                <td><asp:TextBox ID="txtE3" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>E4:</td>
                <td><asp:TextBox ID="txtE4" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>E5:</td>
                <td><asp:TextBox ID="txtE5" runat="server"></asp:TextBox></td>
            </tr>
        </table>
        <asp:Button ID="btnCalcular" runat="server" Text="Calcular" OnClick="btnCalcular_Click" />
    </div>
    </form>
</body>
</html>
