using Models.ORM;
using Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Home
{
    public class NecesidadService
    {
        public List<Necesidades> GetNecesidades(PandemiaEntities context)
        {
            NecesidadRepository necesidadRepository = new NecesidadRepository(context);

            return necesidadRepository.ObtenerTodos();
        }

        public List<Necesidades> GetTopNecesidades(PandemiaEntities context)
        {
            NecesidadRepository necesidadRepository = new NecesidadRepository(context);

            return necesidadRepository.ObtenerTopNecesidades();
        }
    }
}
