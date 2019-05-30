using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class PaginaMensajes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int mensaje = (int)Session["mensaje"];

            switch(mensaje)
            {
                case 1:
                    {
                        this.lblMensaje.Text = "ERROR el Voucher ingresado ya tiene asociado un Cliente";
                        break;
                    }
                case 2:
                    {
                        this.lblMensaje.Text = "Datos cargados correctamente, Gracias por participar!!!";
                        break;
                    }
                case 3:
                    {
                        this.lblMensaje.Text = "El Voucher ingresado no se encuentra en el sistema";
                        break;
                    }
                case 4:
                    {
                        this.lblMensaje.Text = "Error!!! Chequear los datos ingresados no corresponden con el dni";
                        break;
                    }
                default: {
                        this.lblMensaje.Text = " "; break; }
            }
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/PaginaPrincipal.aspx");
        }
    }
}