using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_GestionArticulos
{
    internal class Articulo
    {
        public int id { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string marca { get; set; }
        public Categoria categoria { get; set; }
        public float precio { get; set; }
        public ImagenArticulo imagen { get; set; }
        public int stock { get; set; }
        public DateTime fechaAlta { get; set; }
        public bool activo { get; set; }

        

    }
}
