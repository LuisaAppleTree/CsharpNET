<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Administrador.aspx.cs" Inherits="UsuarioRegistrarLogin.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<meta name="viewport" content="width-device-width, initial-scale=1.0"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js"></script>
    <script src="https://code.jquery.com/jquery-3.7.0.js"></script>
    <link href="Resources/CSS/StyleSheet1.css" rel="stylesheet"/>
    <title>Administrador Productos</title>
</head>
<body>
        <!-inicia navbar->
    <nav class="navbar navbar-expand-lg bg-body-tertiary">
  <div class="container-fluid">
    <a class="navbar-brand" href="Index.aspx">Bienvenid@  <asp:Label ID="lblBienvenida" runat="server" CssClass="h3" Text=" "></asp:Label></a>
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarTogglerDemo02" aria-controls="navbarTogglerDemo02" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navbarTogglerDemo02">
      <ul class="navbar-nav me-auto mb-2 mb-lg-0">
        <li class="nav-item">
            <a class="nav-link" href="Login.aspx">Cerrar Sesión</a>
        </li>
      </ul>
    </div>
  </div>
</nav>
    <!-termina navbar->
        <div class="mx-auto" style="width:250px">
            <asp:Label runat="server" CssClass="h2" ID="lblTitulo"></asp:Label>
        </div>
      <form runat="server" class="h-100 d-flex align-items-center justify-content-center">
        <div>
                <div class="mb-3">
            <label class="form-label">ID Producto</label>
            <asp:TextBox runat="server" CssClass="form-control" ID="tbIDProducto"></asp:TextBox>
        </div>
        <div class="mb-3">
            <label class="form-label">Nombre Producto</label>
            <asp:TextBox runat="server" CssClass="form-control" ID="tbNombreProducto"></asp:TextBox>
        </div>
         <div class="mb-3">
            <label class="form-label">Descripcion</label>
            <asp:TextBox runat="server" CssClass="form-control" ID="tbDescripcion"></asp:TextBox>
        </div>
        <div class="mb-3">
            <label class="form-label">Precio</label>
            <asp:TextBox runat="server" CssClass="form-control" ID="tbPrecio"></asp:TextBox>
        </div>
        <asp:Button runat="server" CssClass="btn btn-primary" ID="btnCreate" Text="Agregar" Visible="false" OnClick="btnCreate_Click"/>
        <asp:Button runat="server" CssClass="btn btn-primary" ID="btnUpdate" Text="Modificar" Visible="false" OnClick="btnUpdate_Click"/>
        <asp:Button runat="server" CssClass="btn btn-primary" ID="btnDelete" Text="Borrar" Visible="false" OnClick="btnDelete_Click"/>
        <asp:Button runat="server" CssClass="btn btn-primary btn-dark" ID="btnVolver" Text="Volver" Visible="true" OnClick="btnVolver_Click"/>
    </div>
    </form>
</body>
</html>
