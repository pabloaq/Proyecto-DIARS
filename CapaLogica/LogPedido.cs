using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogPedido
    {
        #region Patron Sigleton
        //Variable estática para la instancia
        //privado para evitar la instanciación directa
        private static readonly LogPedido _instancia = new LogPedido();
        public static LogPedido Instancia
        {
            get
            {
                return LogPedido._instancia;
            }
        }
        #endregion Patron Sigleton

        #region Metodos
        public List<EntPedido> ListarPedido()
        {
            return DatPedido.Instancia.ListarPedido();
        }

        public List<EntPedido> ListarRegistrados()
        {
            return DatPedido.Instancia.ListarRegistrados();
        }

        public bool InsertarPedido(EntPedido pedido)
        {
            return DatPedido.Instancia.InsertarPedido(pedido);
        }

        public bool ModificarEstadoPedido(EntPedido pedido)
        {
            return DatPedido.Instancia.ModificarEstadoPedido(pedido);
        }
        //---ess
        public List<EntPedido> ListarPedidosPagados()
        {
            List<EntPedido> pedidos = DatPedido.Instancia.ListarPedidosPagados();
            
            pedidos = pedidos.OrderByDescending(p => p.fechaRegistro).ToList();
            return pedidos;
        }

        public bool CambiarEstadoPedido(string idPedido, string nuevoEstado)
        {
            return DatPedido.Instancia.CambiarEstadoPedido(idPedido, nuevoEstado);
        }
        public List<EntPedido> ListarPedidosEntregados()
        {
            return DatPedido.Instancia.ListarPedidosEntregados();
        }

        //---ess

        /*public EntPedido UltimoPedido()
        {
            return DatPedido.Instancia.UltimoPedido();
        }*/
        #endregion Metodos
    }
}
