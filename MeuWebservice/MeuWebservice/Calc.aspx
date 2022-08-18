<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calc.aspx.cs" Inherits="MeuWebservice.Calc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="valor1" runat="server"></asp:TextBox><br /><br />
            <asp:TextBox ID="valor2" runat="server"></asp:TextBox><br /><br />
            <asp:Button ID="btnSoma" runat="server" Text="Somar" OnClick="btnSoma_Click" />
             <asp:Button ID="btnSubtrair" runat="server" Text="Subtrair" OnClick="btnSubtrair_Click" />
             <asp:Button ID="btnMultiplicar" runat="server" Text="Multiplicar" OnClick="btnMultiplicar_Click" />
             <asp:Button ID="btnDividir" runat="server" Text="Dividir" OnClick="btnDividir_Click" /><br /><br />
            <asp:TextBox ID="resultado" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>
