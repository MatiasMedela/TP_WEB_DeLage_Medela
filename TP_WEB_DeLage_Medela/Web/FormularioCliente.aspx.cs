using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace Web
{
    public partial class FormularioCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void tbxCiudad_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void btnParticipar_Click(object sender, EventArgs e)
        {
            Voucher voucher = (Voucher)Session["voucher"];
            Producto producto = (Producto)Session["producto"];
            ClienteNegocio clientenegocio = new ClienteNegocio();
            Cliente cliente = clientenegocio.ExisteCliente(int.Parse(this.tbxDni.Text.Trim()));
            VoucherNegocio vouchernegocio = new VoucherNegocio();

            if(cliente == null)
            {
                cliente = new Cliente();
                cliente.dni = int.Parse(this.tbxDni.Text.Trim());
                cliente.nombre = this.tbxNombre.Text.Trim().ToUpper();
                cliente.apellido = this.tbxApellido.Text.Trim().ToUpper();
                cliente.email = this.tbxEmail.Text.Trim().ToUpper();
                cliente.direccion = this.tbxDireccion.Text.Trim().ToUpper();
                cliente.ciudad = this.tbxCiudad.Text.Trim().ToUpper();
                cliente.codigopostal = this.tbxCp.Text.Trim().ToUpper();
                cliente.fecharegistro = DateTime.Today;

                //agregarlo a la base de datos
                clientenegocio.Agregar(cliente);
                //obtener el id
                cliente = clientenegocio.ExisteCliente(cliente.dni);

            }else
            {
                if(cliente.nombre != this.tbxNombre.Text.Trim().ToUpper() ||
                    cliente.apellido != this.tbxApellido.Text.Trim().ToUpper()||
                    cliente.direccion != this.tbxDireccion.Text.Trim().ToUpper()||
                    cliente.email != this.tbxEmail.Text.Trim().ToUpper()||
                    cliente.ciudad != this.tbxCiudad.Text.Trim().ToUpper() ||
                    cliente.codigopostal != this.tbxCp.Text.Trim().ToUpper()
                    )
                {
                    Session.Add("mensaje", 4);
                    Response.Redirect("~/PaginaMensajes.aspx");
                }
            }

            voucher.cliente = cliente;
            voucher.producto = producto;
            voucher.estado = true;
            voucher.fecharegistro = DateTime.Today;

            //setear voucher
            vouchernegocio.Agregar(voucher);

            Session.Add("mensaje", 2);
            Response.Redirect("~/PaginaMensajes.aspx");
            
        }
    }
}