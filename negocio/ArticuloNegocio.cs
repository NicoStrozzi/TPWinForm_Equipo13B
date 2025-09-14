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
                ", @IdMarca, @IdCategoria)" + "INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (SCOPE_IDENTITY(), @ImagenUrl);");
                datos.setearParametros("@IdMarca", nuevo.Marca.Id);
                datos.setearParametros("@IdCategoria", nuevo.Categoria.Id);
                datos.setearParametros("@ImagenUrl", nuevo.Imagenes);
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
                 datos.setearConsulta(
                    "UPDATE ARTICULOS SET " +
                    "Codigo = @Codigo, " +
                    "Nombre = @Nombre, " +
                    "Descripcion = @Descripcion, " +
                    "Precio = @Precio, " +
                    "IdMarca = @IdMarca, " +
                    "IdCategoria = @IdCategoria " +
                    "WHERE Id = @IdArticulo; " +

                    "UPDATE IMAGENES SET ImagenUrl = @ImagenUrl " +
                    "WHERE IdArticulo = @IdArticulo;"
                 );

                datos.setearParametros("@Codigo", art.Codigo);
                datos.setearParametros("@Nombre", art.Nombre);
                datos.setearParametros("@Descripcion", art.Descripcion);
                datos.setearParametros("@Precio", art.Precio);
                datos.setearParametros("@IdMarca", art.Marca.Id);
                datos.setearParametros("@IdCategoria", art.Categoria.Id);
                datos.setearParametros("@ImagenUrl", art.Imagenes);
                datos.setearParametros("@IdArticulo", art.Id);

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

        public void eliminar(int id)
        {
            try
            {
                AccesoDatos datos=new AccesoDatos();
                datos.setearConsulta("DELETE FROM IMAGENES  WHERE IdArticulo = @id; "+
                                     "DELETE FROM ARTICULOS WHERE Id= @id;");
                datos.setearParametros("@id",id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Articulo> filtrar(string campo, string criterio, string filtro)
        {
            List<Articulo>lista=new List<Articulo>();
            AccesoDatos datos =new AccesoDatos();
            try
            {
                string consulta ="SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, A.Precio, " +
                                 "ISNULL(I.ImagenUrl,'') AS ImagenUrl, " +
                                 "ISNULL(M.Descripcion,'') AS Marca, " +
                                 "ISNULL(C.Descripcion,'') AS Categoria " +
                                 "FROM ARTICULOS A " +
                                 "LEFT JOIN MARCAS M ON A.IdMarca = M.Id " +
                                 "LEFT JOIN CATEGORIAS C ON A.IdCategoria = C.Id " +
                                 "LEFT JOIN IMAGENES I ON I.IdArticulo = A.Id " +
                                 "WHERE 1=1 AND ";

                if (campo == "Precio")
                {
                    switch (criterio)
                    {
                        case "Mayor a": 
                            consulta += "A.Precio > " + filtro; 
                            break;
                        case "Menor a": 
                            consulta += "A.Precio < " + filtro; 
                            break;
                        default: 
                            consulta += "A.Precio = " + filtro; 
                            break;
                    }
                }
                else if (campo == "Nombre")
                {
                    switch (criterio)
                    {
                        case "Comienza con": 
                            consulta += "A.Nombre LIKE '" + filtro + "%'"; 
                            break;
                        case "Termina con": 
                            consulta += "A.Nombre LIKE '%" + filtro + "'"; 
                            break;
                        default: 
                            consulta += "A.Nombre LIKE '%" + filtro + "%'"; 
                            break;
                    }
                }
                else if (campo == "Descripcion")
                {
                    switch (criterio)
                    {
                        case "Comienza con": 
                            consulta += "A.Descripcion LIKE '" + filtro + "%'"; 
                            break;
                        case "Termina con": 
                            consulta += "A.Descripcion LIKE '%" + filtro + "'"; 
                            break;
                        default: 
                            consulta += "A.Descripcion LIKE '%" + filtro + "%'"; 
                            break;
                    }
                }
                datos.setearConsulta( consulta );
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo a = new Articulo();
                    a.Id = (int)datos.Lector["Id"];
                    a.Codigo = (string)datos.Lector["Codigo"];
                    a.Nombre = (string)datos.Lector["Nombre"];
                    a.Descripcion = (string)datos.Lector["Descripcion"];
                    a.Precio = (decimal)datos.Lector["Precio"];
                    a.Imagenes = (string)datos.Lector["ImagenUrl"];

                    a.Marca = new Marca();
                    a.Marca.Descripcion = (string)datos.Lector["Marca"];
                    a.Categoria = new Categoria();
                    a.Categoria.Descripcion = (string)datos.Lector["Categoria"];

                    lista.Add(a);
                }
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
