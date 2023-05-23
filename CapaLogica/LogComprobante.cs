using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogComprobante
    {
        #region Patron Singleton
        //Variable estática para la instancia
        //privado para evitar la instanciación directa
        private static readonly LogComprobante _instancia = new LogComprobante();
        public static LogComprobante Instancia
        {
            get
            {
                return LogComprobante._instancia;
            }
        }
        #endregion Patron Singleton

        # region Metodos
        public List<EntComprobante> ListarComprobante()
        {
            return DatComprobante.Instancia.ListarComprobante();
        }

        public List<EntComprobante> buscarComprobante(string nombreCliente)
        {
            return DatComprobante.Instancia.BuscarComprobante(nombreCliente);
        }

        public void InsertarDatosComprobante(EntComprobante comprobante)
        {
            DatComprobante.Instancia.InsertaDatosComprobante(comprobante);
        }

        public float VerificarMontoTotal(EntComprobante comprobante)
        {
            return DatComprobante.Instancia.VerificarMontoTotal(comprobante);
        }
        # endregion Metodos

    }
}
