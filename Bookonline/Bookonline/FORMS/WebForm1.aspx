<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Bookonline.FORMS.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form  id="frmlivros" runat="server">
                            <div>
                                <label> Título do Livro</label>
                                <asp:TextBox ID="Txttitulo"  runat="server" required="true" placeholder="Digite o título do livro"></asp:TextBox>
                            </div>
                                        
                            <div class="form-group form-button">
                                <asp:Button runat="server"  id="btnPesquisar" class="form-submit" Text="Pesquisar" OnClick="btnPesquisar_Click" />                                
                            </div>
                        </form>
    <form runat="server" id="centerform">
                            <asp:GridView ID="gviewLivros" runat="server"></asp:GridView>
                        </form>
</body>
</html>
