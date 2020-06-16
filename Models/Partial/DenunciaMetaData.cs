using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Partial
{
    public class DenunciaMetaData
    {
        public DateTime FechaCreacion { get; set; }
        public int Estado { get; set; }
        public List<string> DenunciasComentario { get; set; }
        public string MotivoDenuncia { get; set; }
        public UsuariosMetaData Usuario { get; set; }
        public NecesidadesMetaData Necesidad { get; set; }
    }
}
