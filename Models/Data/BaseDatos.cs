using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Data
{
    class BaseDatos
    {
        static private Usuario usuario { get; set; }
    }

    class Usuario
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreUsuario { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string TipoUsuario { get; set; }

        public DateTime FechaNacicmiento { get; set; }
        public DateTime FechaCreacion { get; set; }

        public bool Activo { get; set; }
    }
}
