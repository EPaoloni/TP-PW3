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


        public override void Modificar(Necesidades necesidad)
        {
            var necesidadOriginal = dbSet.Find(necesidad.IdNecesidad);

            if(necesidadOriginal != null)
            {
                necesidadOriginal = necesidad;
                SaveChanges(context);
            }
        }

        /// <summary>
        /// Devuelve todas las necesidades que contengan el nombre ingresado, de no existir ninguna devuelve null
        /// </summary>
        /// <param name="nombreABuscar"></param>
        /// <returns></returns>
        public List<Necesidades> BuscarPorNombre(string nombreABuscar)
        {
            var necesidadesObtenidas = dbSet.Where(necesidad => necesidad.Nombre.Contains(nombreABuscar));

            if(necesidadesObtenidas != null)
            {
                List<Necesidades> necesidades = new List<Necesidades>(necesidadesObtenidas);
                return necesidades;
            } else
            {
                return null;
            }

        }
    }
}
