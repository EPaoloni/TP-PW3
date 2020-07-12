using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Models.ViewModels
{
    public class DonacionMonetaria
    {
        public decimal Monto { get; set; }
        public HttpPostedFileBase ArchivoTransferencia { get; set; }
        public int IdUsuario { get; set; }
        public int IdNecesidad { get; set; }
    }
}
