<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="notas.aspx.cs" Inherits="ejercicio4.notas" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Notas Finales</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>Resultados de Evaluaciones</h2>
        <table border="1">
            <tr>
                <th>Evaluación</th>
                <th>Nota</th>
                <th>Porcentaje</th>
                <th>Puntos Ganados</th>
            </tr>
            <tr>
                <td>E1</td>
                <td><asp:Label ID="lblE1" runat="server" /></td>
                <td><asp:Label ID="lblP1" runat="server" /></td>
                <td><asp:Label ID="lblPG1" runat="server" /></td>
            </tr>
            <tr>
                <td>E2</td>
                <td><asp:Label ID="lblE2" runat="server" /></td>
                <td><asp:Label ID="lblP2" runat="server" /></td>
                <td><asp:Label ID="lblPG2" runat="server" /></td>
            </tr>
            <tr>
                <td>E3</td>
                <td><asp:Label ID="lblE3" runat="server" /></td>
                <td><asp:Label ID="lblP3" runat="server" /></td>
                <td><asp:Label ID="lblPG3" runat="server" /></td>
            </tr>
            <tr>
                <td>E4</td>
                <td><asp:Label ID="lblE4" runat="server" /></td>
                <td><asp:Label ID="lblP4" runat="server" /></td>
                <td><asp:Label ID="lblPG4" runat="server" /></td>
            </tr>
            <tr>
                <td>E5</td>
                <td><asp:Label ID="lblE5" runat="server" /></td>
                <td><asp:Label ID="lblP5" runat="server" /></td>
                <td><asp:Label ID="lblPG5" runat="server" /></td>
            </tr>
            <tr>
                <td colspan="3">Nota Final</td>
                <td><asp:Label ID="lblNotaFinal" runat="server" /></td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
