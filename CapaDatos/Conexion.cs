using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion
    {
        private static readonly Conexion instancia = new Conexion();

        public static Conexion GetInstancia => instancia;

        //public SqlConnection Conectar => new SqlConnection("Data Source=.;Initial Catalog=BDWILSON;" + "Integrated Security=true;");
        public SqlConnection Conectar => new SqlConnection("Data Source = BDWILSON.mssql.somee.com; Initial Catalog = BDWILSON; Integrated Security=False; User Id= kevingm_SQLLogin_1; Password=sgb6jh3iyz"
           );
    }
}
