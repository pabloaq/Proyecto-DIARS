using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DatDetallePedido
    {
        #region Patron Sigleton
        //Variable estática para la instancia
        //privado para evitar la instanciación directa
        private static readonly DatDetallePedido _instancia = new DatDetallePedido();
        public static DatDetallePedido Instancia
        {
            get
            {
                return DatDetallePedido._instancia;
            }
        }
        #endregion Patron Sigleton

        #region Metodos

        #endregion Metodos
    }
}
