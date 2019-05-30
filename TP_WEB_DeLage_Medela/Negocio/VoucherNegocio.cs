using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoADatos;
using Dominio;

namespace Negocio
{
    public class VoucherNegocio
    {
        public Voucher ExisteVoucher(string nombre)
        {
            AccesoDatos conexion = null;
            Voucher voucher = null;

            try
            {
                conexion = new AccesoDatos();
                conexion.setearConsulta("select * from Vouchers where CodigoVoucher = @Codigo");
                conexion.Comando.Parameters.AddWithValue("@Codigo", nombre);
                conexion.abrirConexion();
                conexion.ejecutarConsulta();

                while(conexion.Lector.Read())
                {
                    voucher = new Voucher();
                    voucher.id = int.Parse(conexion.Lector["Id"].ToString());
                    voucher.codigo = conexion.Lector["CodigoVoucher"].ToString();
                    voucher.estado = (bool)conexion.Lector["Estado"];
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (conexion != null)
                {
                    conexion.cerrarConexion();
                }
            }
            return voucher;
        }
        public void Agregar(Voucher voucher)
        {
            AccesoDatos conexion = null;

            try
            {
                //Update[nombre_Tabla] set [col1] = value, [col2] = value where condition
                conexion = new AccesoDatos();
                conexion.setearConsulta("update Vouchers set Estado = @Estado, IdCliente = @IdCliente, IdProducto = @IdProducto, FechaRegistro = @FechaRegistro where CodigoVoucher = @Codigo");
                conexion.Comando.Parameters.AddWithValue("@Estado",voucher.estado);
                conexion.Comando.Parameters.AddWithValue("@IdCliente", voucher.cliente.id);
                conexion.Comando.Parameters.AddWithValue("@IdProducto", voucher.producto.id);
                conexion.Comando.Parameters.AddWithValue("@FechaRegistro", voucher.fecharegistro);
                conexion.Comando.Parameters.AddWithValue("@Codigo", voucher.codigo);
                conexion.abrirConexion();
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if(conexion != null)
                {
                    conexion.cerrarConexion();
                }
            }
        }
    }
}
