using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Models.Partial
{
    public class PerfilMetaData
    {
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [MayorEdad(ErrorMessage = "Debe ser mayor de 18 años")]
        public DateTime FechaNacimiento { get; set; }
        public string RutaFoto { get; set; }
        [Required]
        public HttpPostedFileBase Archivo { get;set; }
        public string Email { get; set; }
        public string NombreUsuario { get; set; }
    }
}
