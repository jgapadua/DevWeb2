<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroFuncionario.aspx.cs" Inherits="OFICINA.FORM.CadastroFuncionario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
     <div class="center-form">
            <h2 class="form=title">Cadastro Funcionários </h2>
            <form id="centerform" runat="server" >
            <div >Nome: <asp:TextBox ID="txtnome" MaxLegth="50" TextMode="SingleLine" runat="server"></asp:TextBox></div>
          <div >Data de nascimento: <asp:TextBox ID="txtdatanascimento" TextMode="Date"  runat="server"></asp:TextBox></div>
           <div >Telefone: <asp:TextBox ID="txttelefone" TextMode="Phone"  runat="server"></asp:TextBox></div>
           <div>CPF: <asp:TextBox ID="txtcpf"  TextMode="Number" MaxLength="11" runat="server"></asp:TextBox></div>
                 <div >Endereço: <asp:TextBox ID="txtendereco"  runat="server"></asp:TextBox></div>
             <div >Número: <asp:TextBox ID="txtnumero"  TextMode="Number" runat="server"></asp:TextBox></div>  
                 <div >Complemento: <asp:TextBox ID="txtcomplemento"  runat="server"></asp:TextBox></div>
                 <div >Bairro: <asp:TextBox ID="txtbairro" runat="server" ReadOnly="True"></asp:TextBox></div>
                 <div >CEP: <asp:TextBox ID="txtcep" runat="server"></asp:TextBox></div>            
                 <div >Cidade: <asp:TextBox ID="txtcidade"  runat="server"></asp:TextBox></div>
                 <div >UF: <asp:TextBox ID="txtuf" MaxLenght="2" runat="server"></asp:TextBox></div>         
                  <div><asp:Button runat="server"   id="btnConsulta" class="form-submit" Text="Consultar CEP" OnClick="btnConsulta_Click" /></div>         
        </form>
                </div>
</body>
</html>
