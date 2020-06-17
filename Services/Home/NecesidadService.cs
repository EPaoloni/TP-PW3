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

        /// <summary>
        /// Devuelve las necesidades que contengan el nombre introducido, si no hay ninguna devuelve null.
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public List<Necesidades> GetNecesidadesPorNombre(string nombre)
        {
            return necesidadRepository.BuscarPorNombre(nombre);
        }
    }
}
