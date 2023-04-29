﻿using CapaDatos;
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
        public bool InsertarPedido(EntPedido pedido)
        {
            return DatPedido.Instancia.InsertarPedido(pedido);
        }

        public bool ModificarEstadoPedido(EntPedido pedido)
        {
            return DatPedido.Instancia.ModificarEstadoPedido(pedido);
        }
        #endregion Metodos
    }
}
