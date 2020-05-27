using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Models.Partial
{
    public partial class UsuariosPartial
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        [Range(18,99,ErrorMessage = "Debe ser mayor de 18 años")]
        public System.DateTime FechaNacimiento { get; set; }
        public string UserName { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        [EmailAddress(ErrorMessage = "Formato de email incorrecto")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        public string Password { get; set; }
        public string RepetirPassword { get; set; }
        public string Foto { get; set; }
        public int TipoUsuario { get; set; }
        public System.DateTime FechaCrecion { get; set; }
        public bool Activo { get; set; }
        public string Token { get; set; }
        public bool RespuestaLogin { get; set; } = false;
    }

    public class EmailExisteAttribute : ValidationAttribute
    {
        List<string> listaEmail = new List<string>()
        {
            "jpabmai@gmail.com"
        };

        public override bool IsValid(object value)
        {
            return listaEmail.Contains(value);
        }
    }
}
