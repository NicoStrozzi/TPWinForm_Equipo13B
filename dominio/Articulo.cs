using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public string Imagenes { get; set; }

        //public List<Marca> marcas { get; set; }
        //public List<Categoria> categorias { get; set; }
        //public decimal precio
        //{
        //    get { return precio; }
        //    set
        //    {
        //        if (precio > 0)
        //            precio = value;
        //        else
        //            precio = 0;
        //    }
        //}
        //public List<ImagenArticulo> imagenes { get; set; }
        //public int stock { get; set; }
        //public DateTime fechaAlta { get; set; }
        //public bool activo { get; set; }



    }
}
