using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntComprobante
    {
        public string IdComprobante { get; set; }
        public string PedidoID { get; set; }
        public string MetodopagoID { get; set; }
        public float montoTotal { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
