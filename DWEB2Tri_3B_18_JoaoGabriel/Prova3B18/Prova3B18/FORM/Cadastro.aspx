<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="Prova3B18.FORM.Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Cadastro</title>
</head>
<body>
    <div>
   <form id="frmRegistrarCliente" runat="server">
       <div>
        <h2>Cadastro Cliente</h2> 
           </div>
       <div>   
           Nome: <asp:TextBox ID="txtnome" placeholder="Digite o seu nome" runat="server" ></asp:TextBox>
           Endereço: <asp:TextBox ID="txtendereco" placeholder="Digite o seu endereço" runat="server"></asp:TextBox>
           Telefone: <asp:TextBox ID="txttelefone" placeholder="Digite o seu telefone" runat="server"></asp:TextBox>
           Placa Veiculo: <asp:TextBox ID="txtplaca" placeholder="Digite a sua placa" runat="server"></asp:TextBox>
            <br />
            <asp:Button  type="button" class="btn btn-primary" ID="btncadclientes" runat="server" Text="Cadastar" OnClick="btncadclientes_Click"  />
            <br />       
        </div>
    </form>
    </div>
    <div>
      <form id="frmRegistrarContrato" runat="server">
       <div>
        <h2>Cadastro Contrato</h2> 
           </div>
       <div>   
           ID Cliente: <asp:DropDownList ID="ddlcliente" runat="server" ></asp:DropDownList>
           ID Tipo de Contrato: <asp:DropDownList ID="ddltipocontrato"  runat="server"></asp:DropDownList>
           Valor: <asp:TextBox ID="txtvalor" placeholder="Digite o valor" runat="server"></asp:TextBox>
           Data de Abertura: <asp:TextBox ID="txtdata"  TextMode="Date" runat="server"></asp:TextBox>
           Número de Vagas: <asp:TextBox ID="txtnumerovagas" placeholder="Digite o número de vagas" runat="server"></asp:TextBox>
            <br />
            <asp:Button  type="button" class="btn btn-primary" ID="btncadcontrato" runat="server" Text="Cadastar" OnClick="btncadcontrato_Click"  />
            <br />       
        </div>
    </form>
        </div>
    <div class="center-form">
                        <h2 class="form-title">Explore nossos contratos</h2>    
                        <form runat="server" id="centerform">
                            <asp:GridView ID="gviewcontratos" runat="server">
                            </asp:GridView>
                            <br />
            <asp:Button  type="button" class="btn btn-primary" ID="btnexibir" runat="server" Text="Exibir com valores maiores que R$ 100,00" OnClick="btnexibir_Click"  />
            <br /> 
                        </form>
                    </div>  

</body>
</html>
