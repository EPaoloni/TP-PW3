using Models.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels
{
    public class NecesidadCreacion
    {
        public int IdUsuarioCreador { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaFin { get; set; }
        public string TelefonoContacto { get; set; }
        public int TipoDonacion { get; set; }
        public string PathFoto { get; set; }
        public List<Referencia> Referencia { get; set; }
        public List<NecesidadesDonacionesInsumos> necesidadesDonacionesInsumos { get; set; }
        public NecesidadesDonacionesMonetarias necesidadesDonacionesMonetarias { get; set; }
    }
}
