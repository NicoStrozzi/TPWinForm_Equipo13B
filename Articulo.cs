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
        public Marca marca { get; set; }
        public Categoria categoria { get; set; }
        public decimal precio
        {
            get { return precio; }
            set
            {
                if (precio > 0)
                    precio = value;
                else
                    precio = 0;
            }
        }
        public ImagenArticulo imagen { get; set; }
        public int stock { get; set; }
        public DateTime fechaAlta { get; set; }
        public bool activo { get; set; }

        

    }
}
