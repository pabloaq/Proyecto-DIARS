using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DatCategoriaMetodoPago
    {
        #region Sigleton
        //Variable estática para la instancia
        //privado para evitar la instanciación directa
        private static readonly DatCategoriaMetodoPago _instancia = new DatCategoriaMetodoPago();
        public static DatCategoriaMetodoPago Instancia
        {
            get { return _instancia; }
        }

        #endregion

        #region Metodos

        #region ListarCategoriaMetodoPago

        public List<EntCategoriaMetodoPago> ListarCategoriaMetodoPago()
        {
            SqlCommand cmd = null;
            List<EntCategoriaMetodoPago> lista = new List<EntCategoriaMetodoPago>();

            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar;
                cmd = new SqlCommand("spListarCategoriaMetodoPago", cn);
                cmd.CommandType= CommandType.StoredProcedure;
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    EntCategoriaMetodoPago categoriaMetodoPago = new EntCategoriaMetodoPago();
                    categoriaMetodoPago.IdCategoriaMetodoPago = Convert.ToString(dr["IdCategoriaMetodoPago"]);
                    categoriaMetodoPago.Nombre = Convert.ToString(dr["Nombre"]);

                    lista.Add(categoriaMetodoPago);
                }


            }catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close(); 
            }

            return lista;
        }

        #endregion ListarCategoriaMetodoPago

        #region InsertarCategoriaMetodoPago

        public bool InsertarCategoriaMetodoPago(EntCategoriaMetodoPago CategoriaMetodoPago)
        {
            SqlCommand cmd = null;
            bool inserto = false;

            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar;
                cmd = new SqlCommand("spInsertarCategoriaMetodoPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdCategoriaMetodoPago", CategoriaMetodoPago.IdCategoriaMetodoPago);
                cmd.Parameters.AddWithValue("@Nombre", CategoriaMetodoPago.Nombre);

                cn.Open();

                int i = cmd.ExecuteNonQuery();

                if(i > 0)
                {
                    inserto = true;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close( );
            }

            return inserto;
        }

        #endregion InsertarCategoriaMetodoPago

        #region ModificarCategoriaMetodoPago

        public bool ModificarCategoriaMetodoPago(EntCategoriaMetodoPago CategoriaMetodoPago)
        {
            SqlCommand cmd = null;
            bool modifico = false;

            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar;
                cmd = new SqlCommand("spModificarCategoriaMetodoPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdCategoriaMetodoPago", CategoriaMetodoPago.IdCategoriaMetodoPago);
                cmd.Parameters.AddWithValue("@Nombre", CategoriaMetodoPago.Nombre);

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

        #endregion ModificarCategoriaMetodoPago

        #region EliminarCategoriaMetodoPago

        public bool EliminarCategoriaMetodoPago(EntCategoriaMetodoPago CategoriaMetodoPago)
        {
            SqlCommand cmd = null;
            bool elimino = false;

            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar;
                cmd = new SqlCommand("spEliminarCategoriaMetodoPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdCategoriaMetodoPago", CategoriaMetodoPago.IdCategoriaMetodoPago);

                cn.Open();

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

        #endregion EliminarCategoriaMetodoPago

        #endregion Metodos
    }
}
