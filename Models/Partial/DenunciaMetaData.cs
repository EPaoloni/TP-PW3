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
        public string Comentarios { get; set; }
        public int IdUsuario { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public int Estado { get; set; }
        public virtual MotivoDenunciaMetaData MotivoDenuncia { get; set; }
        //public virtual Usuarios Usuarios { get; set; }
    }
}
