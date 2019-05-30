<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaginaMensajes.aspx.cs" Inherits="Web.PaginaMensajes" %>

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
    <title>Promo</title>
</head>
<body>
    <div class="clsNavegador">
        <br />
        Promo Gana!
    </div>
    <div class="clsSelection">
    <br />
    <hr />
    <form id="formMensaje" runat="server">
        <asp:Label ID="lblMensaje" runat="server" Text="" CssClass="clsLabel1"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnVolver" runat="server" Text="Volver" CssClass="btn btn-primary" OnClick="btnVolver_Click"/>
    </form>
    <br />
    <hr />
    </div>
    <br />
    <hr />
    <footer>
       <p>&copy; <%: DateTime.Now.Year %> - Mi aplicación ASP.NET</p>
    </footer>
</body>
</html>
