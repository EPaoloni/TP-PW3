using Models.ORM;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels
{
    public class NecesidadCreacion
    {
        [Required]
        public int IdUsuarioCreador { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public DateTime FechaFin { get; set; }
        [Required]
        public string TelefonoContacto { get; set; }
        [Required]
        public int TipoDonacion { get; set; }
        [Required]
        public string Foto { get; set; }
        [Required]
        public List<Referencia> Referencia { get; set; }
        public List<NecesidadDonacionInsumo> NecesidadesDonacionesInsumos { get; set; }
        public NecesidadDonacionMonetaria NecesidadDonacionMonetaria { get; set; }
    }
}
