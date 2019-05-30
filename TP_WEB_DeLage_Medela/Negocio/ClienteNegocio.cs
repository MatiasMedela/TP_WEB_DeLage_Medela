using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoADatos;

namespace Negocio
{
    public class ClienteNegocio
    {
        public Cliente ExisteCliente(int dni)
        {
            AccesoDatos conexion = null;
            Cliente cliente = null;

            try
            {

                conexion = new AccesoDatos();
                conexion.setearConsulta("select Id, DNI, Nombre, Apellido, Email, Direccion, Ciudad, CodigoPostal from Clientes where DNI = @Dni");
                conexion.Comando.Parameters.AddWithValue("@Dni", dni);
                conexion.abrirConexion();
                conexion.ejecutarConsulta();

                while(conexion.Lector.Read())
                {
                    cliente = new Cliente();

                    cliente.id = int.Parse(conexion.Lector["Id"].ToString());
                    cliente.nombre = conexion.Lector["Nombre"].ToString();
                    cliente.apellido = conexion.Lector["Apellido"].ToString();
                    cliente.email = conexion.Lector["Email"].ToString();
                    cliente.direccion = conexion.Lector["Direccion"].ToString();
                    cliente.ciudad = conexion.Lector["Ciudad"].ToString();
                    cliente.codigopostal = conexion.Lector["CodigoPostal"].ToString();
                }

            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                if(conexion != null)
                {
                    conexion.cerrarConexion();
                }
            }

            return cliente;
        }

        public void Agregar(Cliente cliente)
        {
            AccesoDatos conexion = null;

            try
            {
                conexion = new AccesoDatos();
                conexion.setearConsulta("insert Clientes(DNI,Nombre,Apellido,Email,Direccion,Ciudad,CodigoPostal,FechaRegistro)values(@Dni,@Nombre,@Apellido,@Email,@Direccion,@Ciudad,@CodigoPostal,@FechaRegistro)");
                conexion.Comando.Parameters.AddWithValue("@Dni", cliente.dni);
                conexion.Comando.Parameters.AddWithValue("@Nombre", cliente.nombre);
                conexion.Comando.Parameters.AddWithValue("@Apellido", cliente.apellido);
                conexion.Comando.Parameters.AddWithValue("@Email", cliente.email);
                conexion.Comando.Parameters.AddWithValue("@Direccion", cliente.direccion);
                conexion.Comando.Parameters.AddWithValue("@Ciudad", cliente.ciudad);
                conexion.Comando.Parameters.AddWithValue("@CodigoPostal", cliente.codigopostal);
                conexion.Comando.Parameters.AddWithValue("@FechaRegistro", cliente.fecharegistro);

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
