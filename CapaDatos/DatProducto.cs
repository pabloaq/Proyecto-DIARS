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
                    producto.PrecioUnitario = float.Parse(Convert.ToString(dr["PrecioUnitario"]));
                    producto.FechaCaducidad = Convert.ToDateTime(dr["FechaCaducidad"] is DBNull ? null : dr["FechaCaducidad"]);

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

        public bool InsertarProducto(EntProducto Producto)
        {
            SqlCommand cmd = null;
            bool inserta = false;
            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar;
                cmd = new SqlCommand("spInsertarProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdCategoriaProducto", Producto.IdCategoriaProducto);
                cmd.Parameters.AddWithValue("@Nombre", Producto.Nombre);
                cmd.Parameters.AddWithValue("@Stock", Producto.Stock);
                cmd.Parameters.AddWithValue("@PrecioUnitario", Producto.PrecioUnitario);
                cmd.Parameters.AddWithValue("@FechaCaducidad", Producto.FechaCaducidad);

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

        public bool ModificarProducto(EntProducto Producto)
        {
            SqlCommand cmd = null;
            bool modificado = false;
            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar;
                cmd = new SqlCommand("spModificarProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdProducto", Producto.IdProducto);
                cmd.Parameters.AddWithValue("@IdCategoriaProducto", Producto.IdCategoriaProducto);
                cmd.Parameters.AddWithValue("@Nombre", Producto.Nombre);
                cmd.Parameters.AddWithValue("@Stock", Producto.Stock);
                cmd.Parameters.AddWithValue("@PrecioUnitario", Producto.PrecioUnitario);
                cmd.Parameters.AddWithValue("@FechaCaducidad", Producto.FechaCaducidad);

                cn.Open();

                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    modificado = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally { cmd.Connection.Close(); }

            return modificado;
        }

        public bool EliminarProducto(EntProducto Producto)
        {
            SqlCommand cmd = null;
            bool eliminado = false;
            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar;
                cmd = new SqlCommand("spEliminarProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdProducto", Producto.IdProducto);

                cn.Open();

                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    eliminado = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally { cmd.Connection.Close(); }

            return eliminado;
        }

        #endregion Metodos
    }
}
