using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace CapaLogica
{
    public class LogTipoPedido
    {
        #region Patron Sigleton
        private static readonly LogTipoPedido _instancia = new LogTipoPedido();
        public static LogTipoPedido Instancia
        {
            get
            {
                return LogTipoPedido._instancia;
            }
        }
        #endregion Patron Sigleton

        #region Metodos
        
        public List<EntTipoPedido> ListarTipoPedido()
        {
            try
            {
                List<EntTipoPedido> lista = datTipoPedido.Instancia.ListarTipoPedido();
                return lista;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        
        public bool AgregarTipoPedido(EntTipoPedido tipoPedido)
        {
            try
            {
                return datTipoPedido.Instancia.AgregarTipoPedido(tipoPedido);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool ModificarTipoPedido(EntTipoPedido tipoPedido)
        {
            try
            {
                return datTipoPedido.Instancia.ModificarTipoPedido(tipoPedido);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public bool EliminarTipoPedido(string idTp)
        {
            try
            {
                return datTipoPedido.Instancia.EliminarTipoPedido(idTp);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion Metodos
    }
}
