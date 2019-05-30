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
    public partial class PaginaPrincipal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSiguiente_Click(object sender, EventArgs e)
        {
            VoucherNegocio voucherNegocio;
            Voucher voucher;
            if (this.txtCodigo.Text.Trim().Count() > 0)
            {
                voucherNegocio = new VoucherNegocio();
                voucher = voucherNegocio.ExisteVoucher(this.txtCodigo.Text.Trim().ToUpper());

                if (voucher != null)
                {
                    if (!voucher.estado)
                    {
                        Session.Add("voucher", voucher);
                        Response.Redirect("~/ElegirPremio.aspx");

                    }
                    else
                    {
                        Session.Add("mensaje", 1);
                        Response.Redirect("~/PaginaMensajes.aspx");
                    }
                }else
                {
                    Session.Add("mensaje", 3);
                    Response.Redirect("~/PaginaMensajes.aspx");
                }
            }
        }
    }
}