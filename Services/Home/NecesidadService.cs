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
        NecesidadRepository necesidadRepository;
        public NecesidadService(PandemiaEntities context)
        {
            necesidadRepository = new NecesidadRepository(context);
        }
        public List<Necesidades> GetNecesidades()
        {
            return necesidadRepository.ObtenerTodos();
        }

        public List<Necesidades> GetTopNecesidades()
        {
            return necesidadRepository.ObtenerTopNecesidades();
        }

        public void ModificarNecesidad(Necesidades necesidad)
        {
            necesidadRepository.Modificar(necesidad);
        }
    }
}
