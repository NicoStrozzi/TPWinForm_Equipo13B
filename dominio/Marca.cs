using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace dominio
{
    public class Marca
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string descrpcion { get; set; }

        public string paisOrigen { get; set; }
        public string logoUrl { get; set; }
    }
}
