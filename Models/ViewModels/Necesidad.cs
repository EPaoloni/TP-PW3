using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.ViewModels
{
    public class Necesidad
    {
        public string Titulo { get; set; }
        public string PathFoto { get; set; }
        public string NombreUsuario { get; set; }
        public int Valoracion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string LinkDetalle { get; set; }
    }
}