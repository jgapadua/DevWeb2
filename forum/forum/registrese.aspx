<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registrese.aspx.cs" Inherits="forum.registrese" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">

    <title>Forum</title>
</head>
<body>
      <nav class="navbar navbar-default">
  <div class="container-fluid">
    <div class="navbar-header">
      <a class="navbar-brand">Forum</a>
    </div>
    <ul class="nav navbar-nav">
      <li><a href="registrese.aspx">Registrar</a></li>
      <li><a href="login.aspx">Login</a></li>
    </ul>
  </div>
</nav>

    <form id="frmRegistrar" runat="server">
        <div>
            ID: <asp:TextBox ID="txtid" runat="server"></asp:TextBox>
           Email: <asp:TextBox ID="txtemail" placeholder="Digite o seu email" runat="server" ></asp:TextBox>
           Nick: <asp:TextBox ID="txtnick" placeholder="Digite o seu nick" runat="server"></asp:TextBox>
           Nome: <asp:TextBox ID="txtnome" placeholder="Digite o seu nome" runat="server"></asp:TextBox>
           Senha: <asp:TextBox ID="txtsenha" placeholder="Digite a sua senha" runat="server"></asp:TextBox>
            <br />
            <asp:Button  type="button" class="btn btn-primary" ID="btncad" runat="server" Text="Cadastar" OnClick="btncad_Click"  />
            <br />
            
        </div>
    </form>
</body>
</html>
