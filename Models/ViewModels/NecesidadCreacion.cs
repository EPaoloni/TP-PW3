using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels
{
    class NecesidadCreacion
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaFin { get; set; }
        public string TelefonoContacto { get; set; }
        public int TipoDonacion { get; set; }
        public string PathFoto { get; set; }
        public List<Referencia> Referencia { get; set; }
    }
}
