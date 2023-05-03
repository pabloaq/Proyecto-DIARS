using CapaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DatMetodoPago
    {
        #region Singleton

        private static readonly DatMetodoPago _instancia = new DatMetodoPago();

        public static DatMetodoPago Instancia { get { return _instancia; } }

        #endregion Singleton

        #region Metodos

        #region ListarMetodoPago

        public List<EntMetodoPago> ListarMetodoPago()
        {
            SqlCommand cmd = null;
            List<EntMetodoPago> lista = new List<EntMetodoPago>();

            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar;
                cmd = new SqlCommand("spListarMetodoPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    EntMetodoPago metodoPago = new EntMetodoPago();
                    metodoPago.idMetodoPago = Convert.ToString(dr["IdMetodoPago"]);
                    metodoPago.idCategoriaMetodoPago = Convert.ToString(dr["IdCategoriaMetodoPago"]);
                    metodoPago.nombre = Convert.ToString(dr["nombre"]);

                    lista.Add(metodoPago);
                }

            }catch(Exception ex) {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }

            return lista;
        }


        #endregion ListarMetodoPago

        #region InsertarMetodoPago
        public bool InsertarMetodoPago(EntMetodoPago metodoPago)
        {

            SqlCommand cmd = null;
            bool inserto = false;

            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar;
                cmd = new SqlCommand("spInsertarMetodoPago", cn);
                cmd.CommandType= CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdMetodoPago", metodoPago.idMetodoPago);
                cmd.Parameters.AddWithValue("@IdCategoriaMetodoPago", metodoPago.idCategoriaMetodoPago);
                cmd.Parameters.AddWithValue("@nombre", metodoPago.nombre);

                cn.Open();

                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    inserto = true;
                }

            }catch(Exception ex) {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close( );
            }

            return inserto;
        }


        #endregion InsertarMetodoPago

        #region ModificarMetodoPago

        public bool ModificarMetodoPago(EntMetodoPago metodoPago)
        {

            SqlCommand cmd = null;
            bool modifico = false;

            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar;
                cmd = new SqlCommand("spModificarMetodoPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdMetodoPago", metodoPago.idMetodoPago);
                cmd.Parameters.AddWithValue("@IdCategoriaMetodoPago", metodoPago.idCategoriaMetodoPago);
                cmd.Parameters.AddWithValue("@nombre", metodoPago.nombre);

                cn.Open();

                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    modifico = true;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }

            return modifico;
        }

        #endregion ModificarMetodoPago

        #region EliminarMetodoPago

        public bool EliminarMetodoPago(EntMetodoPago metodoPago)
        {
            SqlCommand cmd = null;
            bool elimino = false;

            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar;
                cmd = new SqlCommand("spEliminarMetodoPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdMetodoPago", metodoPago.idMetodoPago);

                cn.Open() ;

                int i = cmd.ExecuteNonQuery();  

                if (i > 0)
                {
                    elimino = true;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                 cmd.Connection.Close();
            }

            return elimino;

        }

        #endregion EliminarMetodoPago


        #endregion Metodos

    }
}
