<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ElegirPremio.aspx.cs" Inherits="Web.ElegirPremio" %>

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
       <div style="text-align:center;">
           <br />
           <asp:Label ID="lblElegirPremio" runat="server" Text="Elija un Premio" style="font-size: 45px;"></asp:Label>
       </div>
       <div style="width:100%; height:auto; margin-top:50px; padding:10px; align-content:center;">
       <form id="form2" runat="server">
       <div class="clsPremio">
           <asp:Image ID="ImgPremio1" runat="server" ImageUrl="#" style="border:1px solid rgb(230,230,230);"/>
           <br />
           <asp:Label ID="lblNombrePremio1" runat="server" Text="Nombre" CssClass="clsNombrePremio"></asp:Label>
           <br />
           <asp:Label ID="lblDescripcionPremio1" runat="server" Text="Descripcion" CssClass="clsDescripcionPremio"></asp:Label>
           <br /><br />
           <asp:Button ID="ElegirPremio1" Text="Elegir" runat="server" cssClass="btn btn-primary" OnClick="ElegirPremio1_Click"/>
       </div>
       <div class="clsPremio">
           <asp:Image ID="ImgPremio2" runat="server" ImageUrl="#" style="border:1px solid rgb(230,230,230);"/>
           <br />
           <asp:Label ID="lblNombrePremio2" runat="server" Text="Nombre" CssClass="clsNombrePremio"></asp:Label>
           <br />
           <asp:Label ID="lblDescripcionPremio2" runat="server" Text="Descripcion" CssClass="clsDescripcionPremio"></asp:Label>
           <br /><br />
           
           <asp:Button ID="ElegirPremio2" Text="Elegir" runat="server" CssClass="btn btn-primary" OnClick="ElegirPremio2_Click" />
           
       </div>
       <div class="clsPremio">
           <asp:Image ID="ImgPremio3" runat="server" ImageUrl="#" style="border:1px solid rgb(230,230,230);"/>
           <br />
           <asp:Label ID="lblNombrePremio3" runat="server" Text="Nombre" CssClass="clsNombrePremio"></asp:Label>
           <br />
           <asp:Label ID="lblDescripcionPremio3" runat="server" Text="Descripcion" CssClass="clsDescripcionPremio"></asp:Label>
           <br /><br />
           <asp:Button ID="ElegirPremio3" Text="Elegir" runat="server" cssClass="btn btn-primary" OnClick="ElegirPremio3_Click"/>
        </div>
     </form>      
   </div>     
   
    
</body>
</html>
