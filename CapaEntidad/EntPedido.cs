using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntPedido
    {
        public string idPedido { get; set; }
        public string idTipoPedido { get; set; }
        public string nombreCliente { get; set; }
        public string direccion { get; set; }
        public DateTime fechaRegistro { get; set; }
        public char estado { get; set; }
    }
}
