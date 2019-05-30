using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;

namespace Web
{
    public partial class ElegirPremio : System.Web.UI.Page
    {
        List<Producto> producto;
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductoNegocio productonegocio = new ProductoNegocio();
            producto = productonegocio.Leer();

            this.ImgPremio1.ImageUrl = "~/" + producto[0].url;
            this.lblNombrePremio1.Text = producto[0].titulo;
            this.lblDescripcionPremio1.Text = producto[0].descripcion;
            this.ImgPremio2.ImageUrl = "~/" + producto[1].url;
            this.lblNombrePremio2.Text = producto[1].titulo;
            this.lblDescripcionPremio2.Text = producto[1].descripcion;
            this.ImgPremio3.ImageUrl = "~/" + producto[2].url;
            this.lblNombrePremio3.Text = producto[2].titulo;
            this.lblDescripcionPremio3.Text = producto[2].descripcion;
        }

        protected void ElegirPremio1_Click(object sender, EventArgs e)
        {
            Session.Add("producto", producto[0]);
            Response.Redirect("~/FormularioCliente.aspx");
        }

        protected void ElegirPremio2_Click(object sender, EventArgs e)
        {
            Session.Add("producto", producto[1]);
            Response.Redirect("~/FormularioCliente.aspx");
        }

        protected void ElegirPremio3_Click(object sender, EventArgs e)
        {
            Session.Add("producto", producto[2]);
            Response.Redirect("~/FormularioCliente.aspx");
        }
    }
}