using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaLogica
{
    public class LogCategoriaMetodoPago
    {
        #region Singleton

        public static readonly LogCategoriaMetodoPago _instacia = new LogCategoriaMetodoPago();

        public static LogCategoriaMetodoPago Instancia{ 
            get { return _instacia; }
        }

        #endregion Singleton

        #region Metodos

        #region ListarCategoriaMetodoPago

        public List<EntCategoriaMetodoPago> ListarCategoriaMetodoPago()
        {
            return DatCategoriaMetodoPago.Instancia.ListarCategoriaMetodoPago();
        }

        #endregion ListarCategoriaMetodoPago

        #region InsertarCategoriaMetodoPago
        
        public bool InsertarCategoriaMetodoPago(EntCategoriaMetodoPago CategoriaMetodoPago)
        {
            return DatCategoriaMetodoPago.Instancia.InsertarCategoriaMetodoPago(CategoriaMetodoPago);
        }

        #endregion InsertarCategoriaMetodoPago

        #region ModificarCategoriaMetodoPago
        public bool ModificarCategoriaMetodoPago(EntCategoriaMetodoPago CategoriaMetodoPago)
        {
            return DatCategoriaMetodoPago.Instancia.ModificarCategoriaMetodoPago(CategoriaMetodoPago);
        }

        #endregion ModificarCategoriaMetodoPago

        #region EliminarCategoriaMetodoPago
        public bool EliminarCategoriaMetodoPago(EntCategoriaMetodoPago CategoriaMetodoPago)
        {
            return DatCategoriaMetodoPago.Instancia.EliminarCategoriaMetodoPago(CategoriaMetodoPago);
        }

        #endregion EliminarCategoriaMetodoPago

        #endregion Metodos
    }
}
