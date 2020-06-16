using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Partial
{
    public class MotivoDenunciaMetaData
    {
        public int IdMotivoDenuncia { get; set; }
        public string Descripcion { get; set; }
        public virtual DenunciaMetaData Denuncias { get; set; }
    }
}
