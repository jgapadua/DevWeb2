<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cadHotel.aspx.cs" Inherits="Agenciaturismo.cadHotel" %>

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
    <form id="frmCadHotel" runat="server">
        <div>
            ID: <asp:TextBox ID="txtid" runat="server"></asp:TextBox>
           Nome: <asp:TextBox ID="txtnome" placeholder="Digite o nome do hotel" runat="server"  required="true"></asp:TextBox>
           CEP: <asp:TextBox ID="txtcep" placeholder="Digite o CEP do hotel" runat="server"></asp:TextBox>
          Número: <asp:TextBox ID="txtnum" placeholder="Digite o número do hotel" runat="server" TextMode="Number"></asp:TextBox>
           Complemento: <asp:TextBox ID="txtcomple" placeholder="Digite o complemento do hotel" runat="server"></asp:TextBox>
             Categoria: <asp:DropDownList ID="ddlCategoria" runat="server">
                 <asp:ListItem Value="1">1 Estrela</asp:ListItem>
                 <asp:ListItem Value="2">2 Estrela</asp:ListItem>
                 <asp:ListItem Value="3">3 Estrela</asp:ListItem>
                 <asp:ListItem Value="4">4 Estrela</asp:ListItem>
                 <asp:ListItem Value="5">5 Estrela</asp:ListItem>
             </asp:DropDownList>
           Cidade: <asp:DropDownList ID="ddlCidade" runat="server"></asp:DropDownList>
            <br />
            <asp:Button ID="btncad" runat="server" Text="Cadastar" OnClick="btncad_Click"  />
            <asp:Button ID="btnlist" runat="server" Text="Listar" OnClick="btnlist_Click" />
             <asp:Button ID="btnremove" runat="server" Text="Remover" OnClick="btnremove_Click" />
            <br />
           <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="idHotel" HeaderText="ID" />
                     <asp:BoundField DataField="nomeHotel" HeaderText="Nome" />
                     <asp:BoundField DataField="cepHotel" HeaderText="CEP" />
                     <asp:BoundField DataField="numHotel" HeaderText="Número" />
                     <asp:BoundField DataField="complementoHotel" HeaderText="Complemento" />
                     <asp:BoundField DataField="categoriaHotel" HeaderText="Categoria" />
                     <asp:BoundField DataField="Cidade_idCidade" HeaderText="ID-Cidade" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>