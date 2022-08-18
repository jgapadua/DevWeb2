<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cadRestaurante.aspx.cs" Inherits="Agenciaturismo.cadRestaurante" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
      <nav class="navbar navbar-default">
  <div class="container-fluid">
    <div class="navbar-header">
      <a class="navbar-brand">Cadastro</a>
    </div>
    <ul class="nav navbar-nav">
      <li><a href="cadCidade.aspx">Cidade</a></li>
      <li><a href="cadHotel.aspx">Hotel</a></li>
      <li><a href="cadRestaurante.aspx">Restaurante</a></li>
      <li><a href="cadCasaShow.aspx">Casa de Show</a></li>
      <li><a href="cadIgreja.aspx">Igreja</a></li>
      <li><a href="cadMuseu.aspx">Museu</a></li>
    </ul>
  </div>
</nav>
    <form id="frmCadRestaurante" runat="server">
        <div>        
           ID: <asp:TextBox ID="txtid" runat="server"></asp:TextBox>
           Nome: <asp:TextBox ID="txtnome" placeholder="Digite o nome do restaurante" runat="server" required="true"></asp:TextBox>
            CEP: <asp:TextBox ID="txtcep" placeholder="Digite o CEP do restaurante" runat="server"></asp:TextBox>
           Número: <asp:TextBox ID="txtnum" placeholder="Digite o número do restaurante" runat="server" TextMode="Number"></asp:TextBox>
            Complemento: <asp:TextBox ID="txtcomple" placeholder="Digite o complemento do restaurante" runat="server"></asp:TextBox>
             Categoria: <asp:DropDownList ID="ddlCategoria" runat="server">
                 <asp:ListItem Value="1">Simples</asp:ListItem>
                 <asp:ListItem Value="2">Luxo</asp:ListItem>
                 <asp:ListItem Value="3">Superluxo</asp:ListItem>
             </asp:DropDownList>
            Cidade: <asp:DropDownList ID="ddlCidade" runat="server"></asp:DropDownList>
            Hotel: <asp:DropDownList ID="ddlHotel" runat="server"></asp:DropDownList>
            <br />
            <asp:Button ID="btncad" runat="server" Text="Cadastar" OnClick="btncad_Click"  />
            <asp:Button ID="btnlist" runat="server" Text="Listar" OnClick="btnlist_Click" />
             <asp:Button ID="btnremove" runat="server" Text="Remover" OnClick="btnremove_Click" />
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="idRestaurante" HeaderText="ID" />
                     <asp:BoundField DataField="nomeRestaurante" HeaderText="Nome" />
                     <asp:BoundField DataField="cepRestaurante" HeaderText="CEP" />
                     <asp:BoundField DataField="numRestaurante" HeaderText="Número" />
                     <asp:BoundField DataField="complementoRestaurante" HeaderText="Complemento" />
                     <asp:BoundField DataField="categoriaRestaurante" HeaderText="Categoria" />
                     <asp:BoundField DataField="Cidade_idCidade" HeaderText="ID-Cidade" />
                      <asp:BoundField DataField="Hotel_idHotel" HeaderText="ID-Hotel" />
                </Columns>
            </asp:GridView>
       
        </div>
    </form>
</body>
</html>