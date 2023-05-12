using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogCategoriaProducto
    {
        #region Patron Singleton
        //Variable estática para la instancia
        //privado para evitar la instanciación directa
        private static readonly LogCategoriaProducto _instancia = new LogCategoriaProducto();
        public static LogCategoriaProducto Instancia
        {
            get
            {
                return LogCategoriaProducto._instancia;
            }
        }
        #endregion Patron Singleton

        #region Metodos
        public List<EntCategoriaProducto> ListarCategoriaProducto()
        {
            return DatCategoriaProducto.Instancia.ListarCategoriaPorducto();
        }

        public bool insertarCategoriaProducto(EntCategoriaProducto categoriaProducto)
        {
            return DatCategoriaProducto.Instancia.InsertarCategoriaProducto(categoriaProducto);
        }

        public bool modificarCategoriaProducto(EntCategoriaProducto categoriaProducto)
        {
            return DatCategoriaProducto.Instancia.ModificarCategoriaProducto(categoriaProducto);
        }

        public bool eliminarCategoriaProducto(EntCategoriaProducto categoriaProducto)
        {
            return DatCategoriaProducto.Instancia.EliminarCategoriaProducto(categoriaProducto);
        }
        #endregion Metodos
    }
}
