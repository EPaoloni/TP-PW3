using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Models.Partial;
using Models.ORM;
using System.Collections;

namespace Models.Repository
{
    public class NecesidadRepository : BaseRepository<Necesidades>
    {
        public NecesidadRepository(PandemiaEntities context) : base(context)
        {

        }

        public List<Necesidades> ObtenerTopNecesidades()
        {
            var TopNecesidades = context.Necesidades.OrderByDescending(necesidad => necesidad.Valoracion).Take(5);

            List<Necesidades> necesidades = new List<Necesidades>(TopNecesidades);

            return necesidades;
        }
    }
}
