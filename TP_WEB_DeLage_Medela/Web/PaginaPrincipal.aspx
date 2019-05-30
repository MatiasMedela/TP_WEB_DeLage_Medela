<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaginaPrincipal.aspx.cs" Inherits="Web.PaginaPrincipal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="~/Content/MyStyle.css" rel="stylesheet" type="text/css"/>
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
    <div class="clsSelection">
        <form id="form1" runat="server" onsubmit="return ValidarVoucher();">
            <br /><hr />
            <asp:Label ID="lblVaucher" runat="server" Text="Ingresa el codigo voucher!" CssClass="clsLabel1"></asp:Label>
            <br /><br />
            <asp:TextBox ID="txtCodigo" runat="server" CssClass="clsTextBox1" required="required"></asp:TextBox>
            <br /><br />
            <asp:Button ID="btnSiguiente" runat="server" Text="Siguiente" CssClass="btn btn-primary" OnClick="btnSiguiente_Click"/>
            <br /><br />
        </form>
        <hr />
        <footer>
                <p>&copy; <%: DateTime.Now.Year %> - Mi aplicación ASP.NET</p>
        </footer>
    </div >
   </body>
</html>
