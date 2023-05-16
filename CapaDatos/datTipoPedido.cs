using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Configuration;

namespace CapaDatos
{
    public class datTipoPedido
    {
        #region Patron Sigleton
        private static readonly datTipoPedido _instancia = new datTipoPedido();
        public static datTipoPedido Instancia
        {
            get
            {
                return datTipoPedido._instancia;
            }
        }
        #endregion Patron Sigleton

        #region Metodos


        public List<EntTipoPedido> ListarTipoPedido()
        {
            SqlCommand cmd = null;
            List<EntTipoPedido> lista = new List<EntTipoPedido>();

            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar;
                cmd = new SqlCommand("spListarTipoPedio", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntTipoPedido listaTipoCliente = new EntTipoPedido();

                    listaTipoCliente.idTipoPedido = dr["IdTipoPedido"].ToString();
                    listaTipoCliente.nombreTipoPedido = dr["Nombre"].ToString();


                    lista.Add(listaTipoCliente);
                }
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }

        public bool AgregarTipoPedido(EntTipoPedido tipoPedido)
        {
            SqlCommand cmd = null;
            bool resultado = false;

            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar;
                cmd = new SqlCommand("spAgregarTipoPedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@NombreTipoPedido", tipoPedido.nombreTipoPedido);
                cn.Open();
                // Se ejecuta el comando SQL
                int i = cmd.ExecuteNonQuery();// filas que serán afectadas si el valor es correcto
                // Si se afectaron filas, se indica que se agregó correctamente el tipo de pedido
                if (i > 0)
                {
                    resultado = true;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }

            return resultado;
        }

        public bool ModificarTipoPedido(EntTipoPedido tipoPedido)
        {
            SqlCommand cmd = null;
            bool resultado = false;

            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar;
                cmd = new SqlCommand("spModificarTipoPedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdTipoPedido", tipoPedido.idTipoPedido);
                cmd.Parameters.AddWithValue("@NombreTipoPedido", tipoPedido.nombreTipoPedido);
                cn.Open();

                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    resultado = true;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }

            return resultado;
        }
        public bool EliminarTipoPedido(string idTp)
        {
            bool eliminado = false;
            SqlConnection cn = null;
            SqlCommand cmd = null;

            try
            {
                cn = Conexion.GetInstancia.Conectar;
                cmd = new SqlCommand("spEliminarTipoPedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdTipoPedido", idTp);

                cn.Open();
                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    eliminado = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cn != null && cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                if (cmd != null)
                {
                    cmd.Dispose();
                }
            }

            return eliminado;
        }



        #endregion Metodos
    }
}
