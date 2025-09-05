using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_GestionArticulos
{
    internal class ImagenArticulo
    {
        public int id { get; set; }
        public int idArticulo { get; set; }
        public string url { get; set; }
        public int orden { get; set; }
        public bool esPrincipal { get; set; }
        public string descripcion { get; set; }
        public string formato { get; set; }
        public int tamanio { get; set; }
        public DateTime fechaSubida { get; set; }

    }
}
