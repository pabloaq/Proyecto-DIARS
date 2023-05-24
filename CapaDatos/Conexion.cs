using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion
    {
        private static readonly Conexion instancia = new Conexion();

        public static Conexion GetInstancia => instancia;

        public SqlConnection Conectar => new SqlConnection("Data Source=.;Initial Catalog=BDWILSON;" + "Integrated Security=true;");
    }
}
