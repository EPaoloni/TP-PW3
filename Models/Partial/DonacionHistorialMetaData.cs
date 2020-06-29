using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Partial
{
    public class DonacionHistorialMetaData
    {
        public int IdNecesidad { get; set; }
        public DateTime Fecha { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Estado { get; set; }
        public string TotalRecaudado { get; set; }
        public string MiDonacion { get; set; }
        public string Path { get; set; }
    }
}
