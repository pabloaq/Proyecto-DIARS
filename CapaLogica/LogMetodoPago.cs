using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogMetodoPago
    {
        #region Singleton
        private static readonly LogMetodoPago _instancia = new LogMetodoPago();

        public static LogMetodoPago Instancia => _instancia;

        #endregion Singleton

        #region Metodos

        #region ListarMetodoPago
        public List<EntMetodoPago> ListarMetodoPago()
        {
            return DatMetodoPago.Instancia.ListarMetodoPago();
        }

        #endregion ListarMetodoPago

        #region InsertarMetodoPago

        public bool InsertarMetodoPago(EntMetodoPago metodoPago)
        {
            return DatMetodoPago.Instancia.InsertarMetodoPago(metodoPago);
        }

        #endregion InsertarMetodoPago

        #region ModificarMetodoPago

        public bool ModificarMetodoPago(EntMetodoPago metodoPago)
        {
            return DatMetodoPago.Instancia.ModificarMetodoPago(metodoPago);
        }

        #endregion ModificarMetodoPago

        #region EliminarMetodoPago

        public bool EliminarMetodoPago(EntMetodoPago metodoPago)
        {
            return DatMetodoPago.Instancia.EliminarMetodoPago(metodoPago);
        }

        #endregion EliminarMetodoPago


        #endregion Metodos
    }
}
