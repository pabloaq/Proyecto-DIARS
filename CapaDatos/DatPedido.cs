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
        public List<EntPedido> ListarPedido()
        {
            SqlCommand cmd = null;
            List<EntPedido> lista = new List<EntPedido>();
            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar; //singleton
                cmd = new SqlCommand("spListarPedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntPedido pedido = new EntPedido();

                    pedido.idPedido = Convert.ToString(dr["IdPedido"]);
                    pedido.nombreCliente = Convert.ToString(dr["NombreCliente"]);
                    pedido.idTipoPedido = Convert.ToString(dr["IdTipoPedido"]);
                    pedido.direccion = Convert.ToString(dr["Direccion"]);
                    pedido.fechaRegistro = Convert.ToDateTime(dr["FechaRegistro"] is DBNull ? null : dr["FechaRegistro"]);
                    pedido.estado = Convert.ToChar(dr["Estado"]);

                    lista.Add(pedido);
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

        public List<EntPedido> ListarRegistrados()
        {
            SqlCommand cmd = null;
            List<EntPedido> lista = new List<EntPedido>();
            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar; //singleton
                cmd = new SqlCommand("spListarRegistrados", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntPedido pedido = new EntPedido();

                    pedido.idPedido = Convert.ToString(dr["IdPedido"]);
                    pedido.nombreCliente = Convert.ToString(dr["NombreCliente"]);
                    pedido.idTipoPedido = Convert.ToString(dr["IdTipoPedido"]);
                    pedido.direccion = Convert.ToString(dr["Direccion"]);
                    pedido.fechaRegistro = Convert.ToDateTime(dr["FechaRegistro"] is DBNull ? null : dr["FechaRegistro"]);
                    pedido.estado = Convert.ToChar(dr["Estado"]);

                    lista.Add(pedido);
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
        //******en
        public List<EntPedido> ListarPedidosPagados()
        {
            SqlCommand cmd = null;
            List<EntPedido> lista = new List<EntPedido>();
            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar;
                cmd = new SqlCommand("spListarPedidosPagados", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntPedido pedido = new EntPedido();

                    pedido.idPedido = Convert.ToString(dr["IdPedido"]);
                    pedido.nombreCliente = Convert.ToString(dr["NombreCliente"]);
                    pedido.idTipoPedido = Convert.ToString(dr["IdTipoPedido"]);
                    pedido.direccion = Convert.ToString(dr["Direccion"]);
                    pedido.fechaRegistro = Convert.ToDateTime(dr["FechaRegistro"] is DBNull ? null : dr["FechaRegistro"]);

                    pedido.estado = Convert.ToChar(dr["Estado"]); // Leer el estado del pedido


                    lista.Add(pedido);
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

        public bool CambiarEstadoPedido(string idPedido, string nuevoEstado)
        {
            SqlCommand cmd = null;
            bool actualizado = false;
            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar;
                cmd = new SqlCommand("spCambiarEstadoPedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdPedido", idPedido);
                cmd.Parameters.AddWithValue("@NuevoEstado", nuevoEstado);

                cn.Open();
                int filasAfectadas = cmd.ExecuteNonQuery();
                if (filasAfectadas > 0)
                {
                    actualizado = true;
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
            return actualizado;
        }
        public List<EntPedido> ListarPedidosEntregados()
        {
            SqlCommand cmd = null;
            List<EntPedido> lista = new List<EntPedido>();
            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar;
                cmd = new SqlCommand("spListarPedidosEntregados", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntPedido pedido = new EntPedido();

                    pedido.idPedido = Convert.ToString(dr["IdPedido"]);
                    pedido.nombreCliente = Convert.ToString(dr["NombreCliente"]);
                    pedido.idTipoPedido = Convert.ToString(dr["IdTipoPedido"]);
                    pedido.direccion = Convert.ToString(dr["Direccion"]);
                    pedido.fechaRegistro = Convert.ToDateTime(dr["FechaRegistro"] is DBNull ? null : dr["FechaRegistro"]);

                    pedido.estado = Convert.ToChar(dr["Estado"]);

                    lista.Add(pedido);
                }
                // Ordenar la lista en orden descendente por fecha de registro
                lista = lista.OrderByDescending(p => p.fechaRegistro).ToList();
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
      
        //********///







        /*public EntPedido UltimoPedido()
        {
            SqlCommand cmd = null;
            EntPedido pedido = new EntPedido();
            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar; //singleton
                cmd = new SqlCommand("spMostrarUltimoPedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                pedido.idPedido = Convert.ToString(dr["IdPedido"]);
                pedido.nombreCliente = Convert.ToString(dr["NombreCliente"]);
                pedido.idTipoPedido = Convert.ToString(dr["IdTipoPedido"]);
                pedido.direccion = Convert.ToString(dr["Direccion"]);
                //pedido.fechaRegistro = Convert.ToDateTime(dr["FechaRegistro"] is DBNull ? null : dr["FechaRegistro"]);
                pedido.estado = Convert.ToChar(dr["Estado"]);

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return pedido;
        }*/
        #endregion Metodos

    }
}
