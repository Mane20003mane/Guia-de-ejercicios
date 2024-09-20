<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MultiplicacionApp._Default" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Tabla de multiplicación</title>
    <style>
        
        .number-btn {
            width: 60px;
            height: 60px;
            margin: 10px;
            font-size: 16px;
            font-weight: bold;
            background-color: #1a1a1a; 
            color: white;
            border: none;
            border-radius: 10px;
            transition: background-color 0.3s ease, transform 0.2s ease;
            cursor: pointer;
            box-shadow: 2px 2px 5px rgba(0, 0, 0, 0.3);
        }

        
        .number-btn:hover {
            background-color: #333333; 
            transform: scale(1.1); 
        }

        
        table {
            margin-top: 20px;
            border-collapse: collapse;
            width: 300px;
            background-color: #f2f2f2; 
            box-shadow: 2px 2px 10px rgba(0, 0, 0, 0.2);
            margin-left: auto;
            margin-right: auto;
        }

        table, th, td {
            border: 2px solid #404040; 
            text-align: center;
        }

        th, td {
            padding: 12px;
            font-size: 18px;
        }

        th {
            background-color: #1a1a1a; 
            color: white;
        }

        td {
            background-color: #333333; 
            color: white;
        }

        
        body {
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            background-color: white; 
            color: black;
            display: flex;
            justify-content: center;
            align-items: flex-start;
            height: 100vh;
            padding: 20px;
        }

        .container {
            display: flex;
            justify-content: space-between;
            width: 80%;
        }

        .numbers-section, .multiplication-section {
            width: 45%;
        }

        .multiplication-section {
            text-align: center;
        }

        h2 {
            color: black; 
            text-align: center;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="numbers-section">
                <h2>Números del 1 al 100</h2>
                <asp:Panel ID="PanelNumeros" runat="server"></asp:Panel>
            </div>
            <div class="multiplication-section">
                <h2>Tabla de Multiplicación</h2>
                <asp:Label ID="lblTabla" runat="server" Text=""></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
