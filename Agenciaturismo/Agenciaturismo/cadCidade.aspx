<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cadCidade.aspx.cs" Inherits="Agenciaturismo.cadCidade" %>

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

    <form id="frmCadCid" runat="server">
        <div>
            ID: <asp:TextBox ID="txtid" runat="server"></asp:TextBox>
           Nome: <asp:TextBox ID="txtnome" placeholder="Digite o nome da cidade" runat="server" ></asp:TextBox>
           UF: <asp:TextBox ID="txtuf" placeholder="Digite o estado da cidade" runat="server"></asp:TextBox>
           População: <asp:TextBox ID="txtpop" placeholder="Digite a população" runat="server" TextMode="Number"></asp:TextBox>
            <br />
            <asp:Button ID="btncad" runat="server" Text="Cadastar" OnClick="btncad_Click"  />
            <asp:Button ID="btnlist" runat="server" Text="Listar" OnClick="btnlist_Click" />
            <asp:Button ID="btnlistUF" runat="server" Text="Listar UF" OnClick="btnlistUF_Click" />
             <asp:Button ID="btnremove" runat="server" Text="Remover" OnClick="btnremove_Click" />
            <asp:Button ID="btnpesquisa" runat="server" Text="Pesquisar" OnClick="btnpesquisa_Click" />
            <asp:Button ID="btnvisu" runat="server" Text="Visualizar" OnClick="btnvisu_Click" /> 
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
                <Columns>
                    <asp:BoundField DataField="idCidade" HeaderText="ID" />
                     <asp:BoundField DataField="nomeCidade" HeaderText="Nome" />
                     <asp:BoundField DataField="ufCidade" HeaderText="UF" />
                     <asp:BoundField DataField="populacaoCidade" HeaderText="População" />
                    <asp:CommandField ShowEditButton="True" />
                    <asp:CommandField ShowDeleteButton="True" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
