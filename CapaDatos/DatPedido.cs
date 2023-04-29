using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
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
        public bool InsertarPedido(EntPedido Pedido)
        {
            SqlCommand cmd = null;
            bool inserta = false;
            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar;
                cmd = new SqlCommand("spInsertarPedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@NombreCliente", Pedido.nombreCliente);
                cmd.Parameters.AddWithValue("@IdTipoPedido", Pedido.idTipoPedido);
                cmd.Parameters.AddWithValue("@Direccion", Pedido.direccion);

                cn.Open();

                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally { cmd.Connection.Close(); }

            return inserta;
        }

        public bool ModificarEstadoPedido(EntPedido Pedido)
        {
            SqlCommand cmd = null;
            bool modifico = false;
            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar;
                cmd = new SqlCommand("spModificarEstadoPedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdPedido", Pedido.idPedido);
                cmd.Parameters.AddWithValue("@Estado", Pedido.estado);

                cn.Open();

                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    modifico = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally { cmd.Connection.Close(); }

            return modifico;
        }
        #endregion Metodos

    }
}
