using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Models.Metadata
{
    class UsuariosMetadata
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public System.DateTime FechaNacimiento { get; set; }
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public string Foto { get; set; }
        public int TipoUsuario { get; set; }
        public System.DateTime FechaCracion { get; set; }
        public bool Activo { get; set; }
        public string Token { get; set; }
    }
}
