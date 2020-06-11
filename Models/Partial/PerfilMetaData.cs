using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Models.Partial
{
    public class PerfilMetaData
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string RutaFoto { get; set; }
        public HttpPostedFileBase Archivo { get;set; }
        public string Email { get; set; }
        public string NombreUsuario { get; set; }
    }
}
