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
    public class DatProducto
    {
        #region Patron Sigleton
        //Variable estática para la instancia
        //privado para evitar la instanciación directa
        private static readonly DatProducto _instancia = new DatProducto();
        public static DatProducto Instancia
        {
            get
            {
                return DatProducto._instancia;
            }
        }
        #endregion Patron Sigleton

        #region Metodos
        public List<EntProducto> ListarProducto()
        {
            SqlCommand cmd = null;
            List<EntProducto> lista = new List<EntProducto>();
            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar; //singleton
                cmd = new SqlCommand("spListarProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntProducto producto = new EntProducto();

                    producto.IdProducto = Convert.ToString(dr["IdProducto"]);
                    producto.IdCategoriaProducto = Convert.ToString(dr["IdCategoriaProducto"]);
                    producto.Nombre = Convert.ToString(dr["Nombre"]);
                    producto.Stock = Convert.ToInt32(dr["Stock"]);
                    producto.PrecioUnitario = Convert.ToDouble(dr["PrecioUnitario"]);
                    producto.FechaDeCaducidad = Convert.ToDateTime(dr["FechaCaducidad"]);

                    lista.Add(producto);
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

        #endregion Metodos
    }
}
