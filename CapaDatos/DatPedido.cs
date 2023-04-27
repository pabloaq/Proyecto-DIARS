using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DatPedido
    {
        #region Patron Sigleton
        //Variable estática para la instancia
        //privado para evitar la instanciación directa
        private static readonly DatPedido _instancia = new DatPedido();
        public static DatPedido Instancia
        {
            get
            {
                return DatPedido._instancia;
            }
        }
        #endregion Patron Sigleton

        #region Metodos

        #endregion Metodos

    }
}
