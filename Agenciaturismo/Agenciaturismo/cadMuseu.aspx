<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cadMuseu.aspx.cs" Inherits="Agenciaturismo.cadMuseu" %>

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
    <form id="frmCadMuseu" runat="server">
        <div>
            
            ID: <asp:TextBox ID="txtid" runat="server"></asp:TextBox>
            Descrição: <asp:TextBox ID="txtdescricao" placeholder="Digite a descrição do museu" runat="server" required="true"></asp:TextBox>
           CEP: <asp:TextBox ID="txtcep" placeholder="Digite o CEP do museu" runat="server"></asp:TextBox>
           Número: <asp:TextBox ID="txtnum" placeholder="Digite o número do museu" runat="server" TextMode="Number"></asp:TextBox>
            Complemento: <asp:TextBox ID="txtcomple" placeholder="Digite o complemento do museu" runat="server"></asp:TextBox>
            Data: <asp:TextBox ID="txtdata" runat="server" TextMode="Date"></asp:TextBox>      
              Salas: <asp:TextBox ID="txtsala" runat="server"></asp:TextBox>   
           Cidade: <asp:DropDownList ID="ddlCidade" runat="server"></asp:DropDownList>
            <br />
            <asp:Button ID="btncad" runat="server" Text="Cadastar" OnClick="btncad_Click"  />
            <asp:Button ID="btnlist" runat="server" Text="Listar" OnClick="btnlist_Click" />
             <asp:Button ID="btnremove" runat="server" Text="Remover" OnClick="btnremove_Click" />
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="idMuseu" HeaderText="ID" />
                     <asp:BoundField DataField="descricaoMuseu" HeaderText="Descrição" />
                     <asp:BoundField DataField="cepMuseu" HeaderText="CEP" />
                     <asp:BoundField DataField="numMuseu" HeaderText="Número" />
                     <asp:BoundField DataField="complementoMuseu" HeaderText="Complemento" />
                     <asp:BoundField DataField="dataMuseu" HeaderText="Data" />
                     <asp:BoundField DataField="salasMuseu" HeaderText="Salas" />
                      <asp:BoundField DataField="Cidade_idCidade" HeaderText="ID-Cidade" />
                </Columns>
            </asp:GridView>
           
        </div>
    </form>
</body>
</html>