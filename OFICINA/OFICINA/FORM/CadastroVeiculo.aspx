<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroVeiculo.aspx.cs" Inherits="OFICINA.FORM.CadastroVeiculo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    
        <div class="center-form">
            <h2 class="form=title">Cadastro Veículo </h2>
            <form id="centerform" runat="server" >
            <div>Placa do veículo sem hífen: <asp:TextBox ID="txtplaca" MaxLegth="8"  runat="server"></asp:TextBox></div>
          <div > Ano do veículo: <asp:TextBox ID="txtano" MaxLength="4" TextMode="Number"  runat="server"></asp:TextBox></div>
           <div >Cor do veículo: <asp:TextBox ID="txtcor"  TextMode="Color"  runat="server"></asp:TextBox></div>
            <div >Dono: <asp:DropDownList ID="drpDono" runat="server"></asp:DropDownList></div>
            <div >Modelo: <asp:DropDownList ID="drpModelo" runat="server"></asp:DropDownList></div>              
            <div><asp:Button runat="server"   id="btnCadastrar" class="form-submit" Text="Gravar" OnClick="btnCadastrar_Click" /></div>
            <asp:GridView ID="gviewVeiculos" runat="server"></asp:GridView>
        </form>
                </div>
    
</body>
</html>
