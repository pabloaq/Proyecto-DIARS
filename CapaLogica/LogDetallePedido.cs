using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class LogDetallePedido
    {
        #region Patron Sigleton
        //Variable estática para la instancia
        //privado para evitar la instanciación directa
        private static readonly LogDetallePedido _instancia = new LogDetallePedido();
        public static LogDetallePedido Instancia
        {
            get
            {
                return LogDetallePedido._instancia;
            }
        }
        #endregion Patron Sigleton

        #region Metodos
        public List<EntDetallePedido> ListarDetallePedido()
        {
            return DatDetallePedido.Instancia.ListarDetallePedido();
        }

        public List<EntDetallePedido> buscarDetallePedido(string nombreCliente)
        {
            return DatDetallePedido.Instancia.BuscarDetallePedido(nombreCliente);
        }

        public bool InsertarDetallePedido(EntDetallePedido detallePedido)
        {
            return DatDetallePedido.Instancia.InsertarDetallePedido(detallePedido);
        }
        #endregion Metodos
    }
}
