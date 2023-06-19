<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="UsuarioRegistrarLogin.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<meta name="viewport" content="width-device-width, initial-scale=1.0"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js"></script>
    <script src="https://code.jquery.com/jquery-3.7.0.js"></script>
    <link href="Resources/CSS/StyleSheet1.css" rel="stylesheet"/>
    <title>Bienvenido a tu cuenta.</title>
</head>

<body class="bg-light">
    <!-inicia navbar->
    <nav class="navbar navbar-expand-lg bg-body-tertiary">
  <div class="container-fluid">
    <a class="navbar-brand" href="Index.aspx">Bienvenid@  <asp:Label ID="lblBienvenida" runat="server" CssClass="h3" Text=" "></asp:Label></a>
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarTogglerDemo02" aria-controls="navbarTogglerDemo02" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navbarTogglerDemo02">
      <ul class="navbar-nav me-auto mb-2 mb-lg-0">
        <li class="nav-item" style='margin-left:1200px'>
            <a class="nav-link" href="Login.aspx">Cerrar Sesión</a>
        </li>
      </ul>
    </div>
  </div>
</nav>
    <!-termina navbar->
        <!-inicia main body->
    <div class="wrapper">
      <form id="form1" runat="server" class="formcontrol">
          <div>
          </div>
          <div class="mx-auto text-center" style="width:500px">
              <h4>Listado y manejo de productos</h4>
              <br />
                    <div class="col align-center">
                      <asp:Button runat="server" ID="btnAgregarProducto" CssClass="btn btn-success form-control-sm" Text="Añadir Productos." OnClick="btnAgregarProducto_Click"/>
                  </div>
          </div>
          <br />
          <div class="container-row">
              <div class="table small">
                  <asp:GridView runat="server" ID="gridViewTablaProductos" class="table table-borderless table-hover">
                      <Columns>
                          <asp:TemplateField HeaderText="Manejo de los productos:">
                              <ItemTemplate>
                                  <asp:Button runat="server" Text="Ver" CssClass="btn form-control-sm btn-info" ID="btnVer" OnClick="btnVer_Click"/>
                                  <asp:Button runat="server" Text="Modificar" CssClass="btn form-control-sm btn-warning" ID="btnModificar" OnClick="btnModificar_Click"/>
                                  <asp:Button runat="server" Text="Borrar" CssClass="btn form-control-sm btn-danger" ID="btnBorrar" OnClick="btnBorrar_Click"/>
                              </ItemTemplate>
                          </asp:TemplateField>
                      </Columns>
                  </asp:GridView>
              </div>
          </div>
    </form>
    </div>
    <!-termina main body->
</body>
</html>
