<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cadIgreja.aspx.cs" Inherits="Agenciaturismo.cadIgreja" %>

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
    <form id="frmCadIgreja" runat="server">
        <div>      
            ID: <asp:TextBox ID="txtid" runat="server"></asp:TextBox>
            Descrição: <asp:TextBox ID="txtdescricao" placeholder="Digite a descriçãoda igreja" runat="server" required="true"></asp:TextBox>
           CEP: <asp:TextBox ID="txtcep" placeholder="Digite o CEP da igreja" runat="server"></asp:TextBox>
           Número: <asp:TextBox ID="txtnum" placeholder="Digite o número da igreja" runat="server" TextMode="Number"></asp:TextBox>
            Complemento: <asp:TextBox ID="txtcomple" placeholder="Digite o complemento da igreja" runat="server"></asp:TextBox>
            Data: <asp:TextBox ID="txtdata" runat="server" TextMode="Date"></asp:TextBox>      
             Estilo: <asp:DropDownList ID="ddlEstilo" runat="server">
                 <asp:ListItem Value="Gótico"></asp:ListItem>
                 <asp:ListItem Value="Angelical"></asp:ListItem>
             </asp:DropDownList>
           Cidade: <asp:DropDownList ID="ddlCidade" runat="server"></asp:DropDownList>
            <br />
            <asp:Button ID="btncad" runat="server" Text="Cadastar" OnClick="btncad_Click"  />
            <asp:Button ID="btnlist" runat="server" Text="Listar" OnClick="btnlist_Click" />
             <asp:Button ID="btnremove" runat="server" Text="Remover" OnClick="btnremove_Click" />
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
                <Columns>
                    <asp:BoundField DataField="idIgreja" HeaderText="ID" />
                     <asp:BoundField DataField="descricaoIgreja" HeaderText="Descrição" />
                     <asp:BoundField DataField="cepIgreja" HeaderText="CEP" />
                     <asp:BoundField DataField="numIgreja" HeaderText="Número" />
                     <asp:BoundField DataField="complementoIgreja" HeaderText="Complemento" />
                     <asp:BoundField DataField="dataIgreja" HeaderText="Data" />
                     <asp:BoundField DataField="estiloIgreja" HeaderText="Estilo" />
                      <asp:BoundField DataField="Cidade_idCidade" HeaderText="ID-Cidade" />
                    <asp:CommandField ShowEditButton="True" />
                    <asp:CommandField ShowDeleteButton="True" />
                </Columns>
            </asp:GridView>
           
        </div>
    </form>
</body>
</html>