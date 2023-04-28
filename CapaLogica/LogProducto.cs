﻿using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogProducto
    {
        #region Patron Sigleton
        //Variable estática para la instancia
        //privado para evitar la instanciación directa
        private static readonly LogProducto _instancia = new LogProducto();
        public static LogProducto Instancia
        {
            get
            {
                return LogProducto._instancia;
            }
        }
        #endregion Patron Sigleton

        #region Metodos

        public List<EntProducto> ListarProducto()
        {
            return DatProducto.Instancia.ListarProducto();
        }

        #endregion Metodos
    }
}
