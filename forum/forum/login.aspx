<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="forum.login" %>

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

    <form id="frmLogin" runat="server">
        <div>       
      <asp:TextBox TextMode="Email" id="txtemail"  runat="server" required="true" name="email" placeholder="Email"></asp:TextBox>
            <asp:TextBox  TextMode="Password" id="txtsenha"  runat="server" required="true" name="senha" placeholder="Senha"> </asp:TextBox>
            <br />
            <asp:Button runat="server" name="signin" id="btnLogin" class="form-submit" Text="Login" OnClick="btnLogin_Click"/>
            <br/>
            
        </div>
    </form>
</body>
</html>
