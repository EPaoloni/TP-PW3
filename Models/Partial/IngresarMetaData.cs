using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Models.Partial
{

    public class IngresarMetaData
    {
        [Required(ErrorMessage = "Campo requerido")]
        [EmailAddress(ErrorMessage = "Formato de email incorrecto")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$", ErrorMessage = "Formato de password incorrecto")]
        public string Password { get; set; }
        public bool RespuestaLogin { get; set; } = false;
    }
}
