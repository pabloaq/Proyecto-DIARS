using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntDetallePedido
    {
        public string idProducto { get; set; }
        public string idPedido { get; set; }
        public int cantidad { get; set; }
    }
}
