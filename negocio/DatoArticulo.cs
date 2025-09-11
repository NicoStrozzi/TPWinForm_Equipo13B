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
    public class DatoArticulo
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
                    aux.marca = new Marca();
                    aux.marca.descripcion = (string)lector["Marca"];
                    aux.categoria=new Categoria();
                    aux.categoria.descripcion = (string)lector["Categoria"];
                    aux.precio = (decimal)lector["Precio"];
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

    }
}
