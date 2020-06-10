using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Models.Partial
{
    [MetadataType(typeof(UsuariosMetaData))]
    public partial class UsuariosPartial
    {
       
    }

    public class UsuariosMetaData
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string RepetirPassword { get; set; }
        public string Foto { get; set; }
        public int TipoUsuario { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Activo { get; set; }
        public string Token { get; set; }
        
    }

    public class EmailExisteAttribute : ValidationAttribute
    {
        //List<string> listaEmail = new List<string>()
        //{
        //    "jpabmai@gmail.com"
        //};

        //public override bool IsValid(object value)
        //{
        //    return listaEmail.Contains(value);
        //}
    }

    public class MayorEdadAttribute : ValidationAttribute
    {
        private int CalcularEdad(DateTime fechaNacimiento)
        {
            DateTime fechaActual = DateTime.Now;
            TimeSpan tiempo = fechaActual - fechaNacimiento;

            int edad = tiempo.Days / 365;

            return edad;
        }

        public override bool IsValid(object value)
        {
            int edad = CalcularEdad((DateTime)value);

            if (edad >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
