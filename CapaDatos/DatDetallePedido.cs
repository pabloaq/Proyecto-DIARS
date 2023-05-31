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
        public List<EntDetallePedido> ListarDetallePedido()
        {
            SqlCommand cmd = null;
            List<EntDetallePedido> lista = new List<EntDetallePedido>();
            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar; //singleton
                cmd = new SqlCommand("spListarDetallePedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntDetallePedido detallePedido = new EntDetallePedido();

                    detallePedido.idProducto = Convert.ToString(dr["Nombre"]);
                    detallePedido.idPedido = Convert.ToString(dr["NombreCliente"]);
                    detallePedido.cantidad = Convert.ToInt32(dr["cantidad"]);

                    lista.Add(detallePedido);
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }

        public List<EntDetallePedido> BuscarDetallePedido(string nombreCliente)
        {
            SqlCommand cmd = null;
            List<EntDetallePedido> lista = new List<EntDetallePedido>();
            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar; //singleton
                cmd = new SqlCommand("spBuscarDetallePedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@NombreCliente", nombreCliente);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntDetallePedido detallePedido = new EntDetallePedido();

                    detallePedido.idProducto = Convert.ToString(dr["Nombre"]);
                    detallePedido.idPedido = Convert.ToString(dr["NombreCliente"]);
                    detallePedido.cantidad = Convert.ToInt32(dr["cantidad"]);

                    lista.Add(detallePedido);
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }

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

        //****/
        public List<EntDetallePedido> BuscarDetallePedidoID(string idPedido)
        {
            SqlCommand cmd = null;
            List<EntDetallePedido> lista = new List<EntDetallePedido>();

            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar;
                cmd = new SqlCommand("spBuscarDetallePedidoID", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdPedido", idPedido);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    EntDetallePedido detallePedido = new EntDetallePedido();

                    detallePedido.idProducto = Convert.ToString(dr["Nombre"]);
                    detallePedido.idPedido = Convert.ToString(dr["NombreCliente"]);
                    detallePedido.cantidad = Convert.ToInt32(dr["cantidad"]);

                    lista.Add(detallePedido);
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar el detalle del pedido: " + ex.Message);
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Connection.Close();
                }
            }

            return lista;
        }/*
        public List<EntDetallePedido> ListarDetallePedidoPorIdPedido(string idPedido)
        {
            SqlCommand cmd = null;
            List<EntDetallePedido> lista = new List<EntDetallePedido>();
            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar; //singleton
                cmd = new SqlCommand("spListarDetallePedidoPorIdPedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdPedido", idPedido);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntDetallePedido detallePedido = new EntDetallePedido();

                    detallePedido.idProducto = Convert.ToString(dr["Nombre"]);
                    detallePedido.idPedido = Convert.ToString(dr["NombreCliente"]);
                    detallePedido.cantidad = Convert.ToInt32(dr["cantidad"]);

                    lista.Add(detallePedido);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }*/
        ///****/
        #endregion Metodos
    }
}
