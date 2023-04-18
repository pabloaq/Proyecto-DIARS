using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntUsuario
    {
        public string idusuario { get; set; }
        public string username { get; set; }
        public string contrasenia { get; set; }
        public string dni { get; set; }
        public string apellido { get; set; }
        public string nombres { get; set; }
        public int rol { get; set; }
    }
}
