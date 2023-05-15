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
    public class DatCategoriaProducto
    {
        #region Patron Singleton
        //Variable estática para la instancia
        //privado para evitar la instanciación directa
        private static readonly DatCategoriaProducto _instancia = new DatCategoriaProducto();
        public static DatCategoriaProducto Instancia
        {
            get
            {
                return DatCategoriaProducto._instancia;
            }
        }
        #endregion Patron Singleton

        #region Metodos
        public List<EntCategoriaProducto> ListarCategoriaPorducto()
        {
            SqlCommand cmd = null;
            List<EntCategoriaProducto> lista = new List<EntCategoriaProducto>();
            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar; //singleton
                cmd = new SqlCommand("spListarCategoriaProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntCategoriaProducto categoriaPorducto = new EntCategoriaProducto();

                    categoriaPorducto.idCategoriaProducto = Convert.ToString(dr["IdCategoriaProducto"]);
                    categoriaPorducto.nombre = Convert.ToString(dr["categoriaNombre"]);

                    lista.Add(categoriaPorducto);
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

        public bool InsertarCategoriaProducto(EntCategoriaProducto categoriaProducto)
        {
            SqlCommand cmd = null;
            bool inserta = false;
            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar;
                cmd = new SqlCommand("spInsertarCategoriaProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", categoriaProducto.nombre);

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

        public bool ModificarCategoriaProducto(EntCategoriaProducto categoriaProducto)
        {
            SqlCommand cmd = null;
            bool modifico = false;
            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar;
                cmd = new SqlCommand("spModificarCategoriaProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdCategoriaProducto", categoriaProducto.idCategoriaProducto);
                cmd.Parameters.AddWithValue("@Nombre", categoriaProducto.nombre);

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

        public bool EliminarCategoriaProducto(EntCategoriaProducto categoriaProducto)
        {
            SqlCommand cmd = null;
            bool eliminado = false;
            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar;
                cmd = new SqlCommand("spEliminarCategoriaProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdCategoriaProducto", categoriaProducto.idCategoriaProducto);

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
