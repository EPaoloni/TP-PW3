using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Models.Partial
{
    public class RegistrarseMetaData
    {
        [Required(ErrorMessage = "Campo requerido")]
        [EmailAddress(ErrorMessage = "Formato de email incorrecto")]
        public string Email { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        [Required(ErrorMessage = "Campo requerido")]        
        [MayorEdad(ErrorMessage = "Debe ser mayor de 18 años")]
        public DateTime FechaNacimiento { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$", ErrorMessage = "Formato de password incorrecto")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [Compare("Password", ErrorMessage = "Las contraseñas deben coincidir")]
        public string RepetirPassword { get; set; }
        public int TipoUsuario { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Activo { get; set; }
        public string Token { get; set; }

    }
}
