using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.ORM;
using Models.Partial;

namespace Services.Usuario
{
    public class PaginadorService
    {
        public PaginadorModel Paginacion(List<Necesidades> lista, int pagina)
        {
            PaginadorModel paginador = new PaginadorModel();

            paginador.TotalDeRegistros = lista.Count();
            paginador.PaginaActual = pagina;

            paginador.Lista = lista.Skip((pagina - 1) * paginador.RegistrosPorPagina)
                                   .Take(paginador.RegistrosPorPagina).ToList();

            return paginador;
        }
    }
}
