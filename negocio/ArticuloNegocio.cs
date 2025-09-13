using dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List <Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "Data Source=.\\SQLEXPRESS; Initial Catalog=CATALOGO_P3_DB; Integrated Security=true";
                
                comando.CommandType = System.Data.CommandType.Text;
                
                comando.Connection = conexion;
                comando.CommandText = "SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, A.Precio, " +
                                 "       ISNULL(I.ImagenUrl,'')    AS ImagenUrl, " +
                                 "       ISNULL(M.Descripcion,'')  AS Marca, " +
                                 "       ISNULL(C.Descripcion,'')  AS Categoria " +
                                 "FROM ARTICULOS A " +
                                 "LEFT JOIN MARCAS      M ON A.IdMarca     = M.Id " +
                                 "LEFT JOIN CATEGORIAS  C ON A.IdCategoria = C.Id " +
                                 "LEFT JOIN IMAGENES    I ON I.IdArticulo  = A.Id;";


                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)lector["Id"];
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.Imagenes = (string)lector["ImagenUrl"];
                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)lector["Marca"];
                    aux.Categoria=new Categoria();
                    aux.Categoria.Descripcion = (string)lector["Categoria"];
                    aux.Precio = (decimal)lector["Precio"];
                    lista.Add(aux);
                }

                conexion.Close();
                return lista;

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, Precio, IdMarca, IdCategoria) " +
                 "VALUES ('" + nuevo.Codigo + "', '" + nuevo.Nombre + "', '" +
                nuevo.Descripcion + "', " + nuevo.Precio +
                ", @IdMarca, @IdCategoria)");
                datos.setearParametros("@IdMarca",nuevo.Marca.Id);
                datos.setearParametros("@IdCategoria", nuevo.Categoria.Id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarconexion();
            }
        }

        public void modificar(Articulo art)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                // Solo Pongo algunos para probar hasta encontrar la forma de modificar todos
                datos.setearConsulta("UPDATE ARTICULOS SET Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, Precio = @Precio WHERE Id = @Id");

                datos.setearParametros("@Codigo", art.Codigo);
                datos.setearParametros("@Nombre", art.Nombre);
                datos.setearParametros("@Descripcion", art.Descripcion);
                datos.setearParametros("@Precio", art.Precio);
                datos.setearParametros("@Id", art.Id);

                datos.ejecutarAccion();


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally 
            { 
                datos.cerrarconexion(); 
            }
        }
    }
}
