<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cadCasaShow.aspx.cs" Inherits="Agenciaturismo.cadCasaShow" %>

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
    <form id="frmCadCasaShow" runat="server">
        <div>      
            ID: <asp:TextBox ID="txtid" runat="server"></asp:TextBox>
            Descrição: <asp:TextBox ID="txtdescricao" placeholder="Digite a descrição da casa de show" runat="server" required="true"></asp:TextBox>
           CEP: <asp:TextBox ID="txtcep" placeholder="Digite o CEP da casa de show" runat="server"></asp:TextBox>
           Número: <asp:TextBox ID="txtnum" placeholder="Digite o número da casa de show" runat="server" TextMode="Number"></asp:TextBox>
            Complemento: <asp:TextBox ID="txtcomple" placeholder="Digite o complemento da casa de show" runat="server"></asp:TextBox>
            Data: <asp:TextBox ID="txtdata" runat="server" TextMode="Date"></asp:TextBox>      
              Fechamento: <asp:TextBox ID="txtfecha" runat="server"></asp:TextBox>   
           Cidade: <asp:DropDownList ID="ddlCidade" runat="server"></asp:DropDownList>
            <br />
            <asp:Button ID="btncad" runat="server" Text="Cadastar" OnClick="btncad_Click"  />
            <asp:Button ID="btnlist" runat="server" Text="Listar" OnClick="btnlist_Click" />
             <asp:Button ID="btnremove" runat="server" Text="Remover" OnClick="btnremove_Click" />
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
                <Columns>
                    <asp:BoundField DataField="idShow" HeaderText="ID" />
                     <asp:BoundField DataField="descricaoShow" HeaderText="Descrição" />
                     <asp:BoundField DataField="cepShow" HeaderText="CEP" />
                     <asp:BoundField DataField="numShow" HeaderText="Número" />
                     <asp:BoundField DataField="complementoShow" HeaderText="Complemento" />
                     <asp:BoundField DataField="dataShow" HeaderText="Data" />
                     <asp:BoundField DataField="fechamentoShow" HeaderText="Fechamento" />
                      <asp:BoundField DataField="Cidade_idCidade" HeaderText="ID-Cidade" />
                    <asp:CommandField ShowEditButton="True" />
                    <asp:CommandField ShowDeleteButton="True" />
                </Columns>
            </asp:GridView>
           
        </div>
    </form>
</body>
</html>