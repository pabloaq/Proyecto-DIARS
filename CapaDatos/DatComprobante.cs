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
    public class DatComprobante
    {
        #region Patron Singleton
        //Variable estática para la instancia
        //privado para evitar la instanciación directa
        private static readonly DatComprobante _instancia = new DatComprobante();
        public static DatComprobante Instancia
        {
            get
            {
                return DatComprobante._instancia;
            }
        }
        #endregion Patron Singleton

        #region Metodos

        public bool InsertaDatosComprobante(EntComprobante comprobante)
        {
            SqlCommand cmd = null;
            Boolean insertar = false;

            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar;
                cmd = new SqlCommand("spInsertarComprobante", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdPedido", comprobante.PedidoID);
                cmd.Parameters.AddWithValue("@MetodoPago", comprobante.MetodopagoID);
                cmd.Parameters.AddWithValue("@MontoTotal", comprobante.montoTotal);

                cn.Open();

                if (cmd.ExecuteNonQuery() > 0)
                {
                    insertar = true;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            finally
            {
                cmd.Connection.Close();
            }
            return insertar;
        }

        public float VerificarMontoTotal(EntComprobante comprobante)
        {

            SqlCommand cmd = null;

            float total = 1;

            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar;
                cmd = new SqlCommand("spPrecioTotal", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdPedido", comprobante.PedidoID);
                SqlParameter totalPago = new SqlParameter("@Total", 0);
                totalPago.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(totalPago);

                cn.Open();
                cmd.ExecuteNonQuery();
                total = float.Parse(cmd.Parameters["@Total"].Value.ToString());

            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            finally
            {
                cmd.Connection.Close();
            }
            return total;

        }


        #endregion Metodos
    }
}
