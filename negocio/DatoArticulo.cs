using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using System.Data.SqlClient;

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
                comando.CommandText = "Select Id, Codigo, Nombre, Descripcion From ARTICULOS";
                

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)lector["Id"];
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];

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
