<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="UsuarioRegistrarLogin.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<meta name="viewport" content="width-device-width, initial-scale=1.0"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js"></script>
    <script src="https://code.jquery.com/jquery-3.7.0.js"></script>
    <link href="Resources/CSS/StyleSheet1.css" rel="stylesheet"/>
    <title>Crear Cuenta</title>
</head>

<body class="bg-light">
    <div class="wrapper">
        <div class="formcontrol">
           <form id="formulario_Sign" runat="server">
                <div class="form-control">
                    <div class="row text-center">
                        <asp:Label cass="h3" ID="lblHome" runat="server" Text="Bienvenido, Crea una nueva cuenta con nosotros."></asp:Label>
                    </div>
                    <div class="margin-form">
                        <asp:Label ID="lblUsuario" runat="server" Text="Usuario"></asp:Label>
                        <asp:TextBox ID="tbUsuario" CssClass="form-control" runat="server" placeholder="Ingresa tu nombre de usuario" TextMode="SingleLine"></asp:TextBox>
                    </div>
                    <div class="margin-form">
                        <asp:Label ID="lblCorreo" runat="server" Text="Correo Electrónico"></asp:Label>
                        <asp:TextBox ID="tbCorreo" CssClass="form-control" runat="server" placeholder="Ingresa tu Email" TextMode="Email"></asp:TextBox>
                    </div>
                    <div class="margin-form">
                        <asp:Label ID="lblPassword" runat="server" Text="Contraseña"></asp:Label>
                        <asp:TextBox ID="tbPassword" CssClass="form-control" runat="server" placeholder="Ingresa tu contraseña." TextMode="Password"></asp:TextBox>
                    </div>
                    <div class="margin-form">
                        <asp:Label ID="lblConfirmPassword" runat="server" Text="Confirmar Contraseña"></asp:Label>
                        <asp:TextBox ID="tbConfirmarPassword" CssClass="form-control" runat="server" placeholder="Escribe de nuevo tu contraseña." TextMode="Password"></asp:TextBox>
                    </div>
                    <div class="row text-center">
                        <asp:Label runat="server" ID="lblWarn" CssClass="alert-danger"></asp:Label>
                    </div>
                    <div class="row margin-form">
                        <asp:Button ID="btnSignUp" CssClass="btn btn-primary btn-dark" runat="server" Text="Registrar Usuario" OnClick="btnSignUp_Click"/>
                    </div>
                    <div>
                        <h4><a href="Login.aspx">O bien, Inicia Sesión en tu cuenta si ya estas registrado.</h4></a>
                    </div>
                </div>
            </form>
        </div>
    </div>
</body>
</html>
