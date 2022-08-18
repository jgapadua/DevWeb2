<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="forum._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta http-equiv="X-UA-Compatible" content="ie=edge" />
    <title>Sign Up Stackoverflow</title>

    <!-- Font Icon -->
    <link rel="stylesheet" href="assets/fonts/material-icon/css/material-design-iconic-font.min.css" />

    <!-- Main css -->
    <link rel="stylesheet" href="assets/css/style.css" />
</head>
<body>
        <div class="main">

        <!-- Sign up form -->
        <section class="signup">
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <div class="container">
                <div class="signup-content">
                    <div class="center-form">
                        <h2 class="form-title">Explore nossas perguntas</h2>    
                        <form runat="server" id="centerform">
                            <asp:GridView ID="gviewPerguntas" runat="server"></asp:GridView>
                        </form>
                    </div>                    
                </div>
            </div>
        </section>
    </div>

    <!-- JS -->
    <script src="assets/vendor/jquery/jquery.min.js"></script>
    <script src="assets/js/main.js"></script>
</body>
</html>

