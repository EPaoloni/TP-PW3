using Models.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Partial
{
    public class PaginadorModel
    {
        public readonly int RegistrosPorPagina = 6;
        public int PaginaActual { get; set; }
        public int TotalDeRegistros { get; set; }
        public List<Necesidades> Lista { get; set; }
    }
}
