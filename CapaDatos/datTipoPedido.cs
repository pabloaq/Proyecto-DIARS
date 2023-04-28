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
                    EntTipoPedido ci = new EntTipoPedido();

                    ci.idTipoPedido = dr["IdTipoPedido"].ToString();
                    ci.nombreTipoPedido = dr["Nombre"].ToString();


                    lista.Add(ci);
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
        #endregion Metodos
    }
}
