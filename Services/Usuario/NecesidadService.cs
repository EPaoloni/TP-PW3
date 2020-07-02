using Models.ORM;
using Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Usuario
{
    public class NecesidadService
    {
        NecesidadRepository necesidadRepo;

        public NecesidadService()
        {
            PandemiaEntities context = new PandemiaEntities();
            necesidadRepo = new NecesidadRepository(context);
        }

        public Necesidades ObtenerPorId(int id)
        {
            Necesidades necesidad = necesidadRepo.ObtenerPorId(id);

            return necesidad;
        }
    }
}
