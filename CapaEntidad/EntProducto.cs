using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntProducto
    {
        public string IdProducto { get; set; }
        public string IdCategoriaProducto { get; set; }
        public string Nombre { get;set; }
        public int Stock { get; set; }
        public float PrecioUnitario { get; set; }
        public DateTime? FechaCaducidad { get; set; }
    }
}
