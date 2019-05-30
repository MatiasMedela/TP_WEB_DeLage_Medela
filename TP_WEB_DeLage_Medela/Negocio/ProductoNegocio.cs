using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoADatos;

namespace Negocio
{
    public class ProductoNegocio
    {
        public List<Producto> Leer()
        {
            AccesoDatos conexion = null;
            List<Producto> productos = null;
            Producto aux;

            try
            {
                conexion = new AccesoDatos();
                conexion.setearConsulta("select * from Productos");
                conexion.abrirConexion();
                conexion.ejecutarConsulta();
                productos = new List<Producto>();

                while(conexion.Lector.Read())
                {
                    aux = new Producto();
                    aux.id = int.Parse(conexion.Lector["Id"].ToString());
                    aux.titulo = conexion.Lector["Titulo"].ToString();
                    aux.descripcion = conexion.Lector["Descripcion"].ToString();
                    aux.url = conexion.Lector["URLImagen"].ToString();

                    productos.Add(aux);
                }
              
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

            return productos;
        }
    }
}
