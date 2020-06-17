using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Partial
{
    public class DenunciaMetaData
    {
        public int IdDenuncia { get; set; }
        public int IdNecesidad { get; set; }
        public int IdMotivo { get; set; }
        public int IdComentarios { get; set; }
        public int IdUsuario { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int Estado { get; set; }

        public UsuariosMetaData Usuarios { get; set; }
        public string DenunciasComentario { get; set; }
        public string DenunciasEstado { get; set; }
        public string MotivoDenuncia { get; set; }
        public NecesidadesMetaData Necesidades { get; set; }
    }
}
