using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

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
        public bool InsertarDetallePedido(EntDetallePedido DetallePedido)
        {
            SqlCommand cmd = null;
            bool inserta = false;
            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar;
                cmd = new SqlCommand("spInsertarDetallePedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdProducto", DetallePedido.idProducto);
                cmd.Parameters.AddWithValue("@IdPedido", DetallePedido.idPedido);
                cmd.Parameters.AddWithValue("@cantidad", DetallePedido.cantidad);

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
        #endregion Metodos
    }
}
