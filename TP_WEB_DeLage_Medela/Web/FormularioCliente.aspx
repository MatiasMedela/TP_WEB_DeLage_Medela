<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormularioCliente.aspx.cs" Inherits="Web.FormularioCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="Content/MyStyle.css" rel="stylesheet" />
    <link href="MyContent/bootstrap-grid.css" rel="stylesheet" />
    <link href="MyContent/bootstrap-grid.min.css" rel="stylesheet" />
    <link href="MyContent/bootstrap-reboot.css" rel="stylesheet" />
    <link href="MyContent/bootstrap-reboot.min.css" rel="stylesheet" />
    <link href="MyContent/bootstrap.css" rel="stylesheet" />
    <link href="MyContent/bootstrap.min.css" rel="stylesheet" />
    <script src="<%=ResolveClientUrl("~/scriptsJavaScript/Funcionamiento.js") %>"type="text/javascript"></script>
   
    <title>Promo</title>
    
</head>


    
<body>
    <div class="clsNavegador">
        <br />
        Promo Gana!
    </div>
    <div style="padding-left:300px">
    <br />
    <hr />
    <form id="frmFormularioCliente" runat="server" onsubmit="return ValidarFormularioCliente();">
       <div class="form-row">
           <div class="form-group col-md-6">
                <asp:Label ID="lblDni" runat="server" Text="DNI"></asp:Label>
                <br />
                <asp:TextBox ID="tbxDni" runat="server" CssClass="clsTextBox1" required="required" OnTextChanged="tbxDni_TextChanged"></asp:TextBox>
            </div>
        </div>
       <div class="form-row">
       <div style="margin:5px;">
            <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
            <br />
            <asp:TextBox ID="tbxNombre" runat="server" CssClass="clsTextBox1" required="required"></asp:TextBox>
       </div>
        <div style="margin:5px;">
           <asp:Label ID="lblApellido" runat="server" Text="Apellido"></asp:Label>
           <br />
           <asp:TextBox ID="tbxApellido" runat="server" style="width:200px; text-align:center;" required="required"></asp:TextBox>
       </div>
      <div style="margin:5px;">
           <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
          <br />
           <asp:TextBox ID="tbxEmail" runat="server" type="Email" style="width:200px; text-align:center;" required="required"></asp:TextBox>
      </div> 
      </div>
      <div class="form-row">
      <div style="margin:5px;">
          <asp:Label ID="lblDireccion" runat="server" Text="Direccion"></asp:Label>
          <br />
          <asp:TextBox ID="tbxDireccion" runat="server" CssClass="clsTextBox1" required="required"></asp:TextBox>
       </div>
       <div style="margin:5px;">
          <asp:Label ID="lblCiudad" runat="server" Text="Ciudad"></asp:Label>
          <br />
          <asp:TextBox ID="tbxCiudad" runat="server" style="width:200px;text-align:center;" OnTextChanged="tbxCiudad_TextChanged" required="required"></asp:TextBox>
      </div>
      <div style="margin:5px;">
          <asp:Label ID="lblCp" runat="server" Text="CP"></asp:Label>
          <br />
          <asp:TextBox ID="tbxCp" runat="server" style="width:200px;text-align:center;"></asp:TextBox>
      </div> 
      </div>
      <div class="form-group">
      <br />
      <div class="form-check">
        <asp:CheckBox ID="cbxTerminos" runat="server"/>
        <asp:Label ID="lblTerminos" runat="server" Text="Terminos y Condiciones"></asp:Label>
      </div>
  </div>
  <br />
  <asp:Button ID="btnParticipar" runat="server" Text="Participar" CssClass="btn btn-primary" OnClick="btnParticipar_Click" />
</form>
    <br />
    <hr />
    <footer>
       <p>&copy; <%: DateTime.Now.Year %> - Mi aplicación ASP.NET</p>
    </footer>

</div>
</body>
</html>
