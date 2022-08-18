<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultaMunicipio.aspx.cs" Inherits="Municipios.FORMS.ConsultaMunicipio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form  id="frmMunicipio" runat="server">
                            <div>
                                <label>Consultar Municipio por  Nome e UF</label>
                                <asp:TextBox ID="txtpesquisa"  runat="server" required="true" placeholder="Nome/UF"></asp:TextBox>
                            </div>
                                        
                            <div class="form-group form-button">
                                <asp:Button runat="server"  id="btnPesquisar" class="form-submit" Text="Pesquisar" OnClick="btnPesquisar_Click" />                                
                            </div>
        
                            <asp:GridView ID="gviewMunicipio" runat="server"></asp:GridView>
                        </form>
</body>
</html>
