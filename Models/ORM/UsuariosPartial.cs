using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Models.Metadata;

namespace Models.ORM
{
    [MetadataType(typeof(UsuariosMetadata))]
    public partial class Usuarios
    {
        public string MensajeErrorGeneralLogin { get; set; }
    }
}
