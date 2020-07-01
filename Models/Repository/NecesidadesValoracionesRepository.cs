using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Models.Partial;
using Models.ORM;
using System.Collections;
using Models.ViewModels;
using System.CodeDom;

namespace Models.Repository
{
    public class NecesidadesValoracionesRepository : BaseRepository<ORM.NecesidadesValoraciones>
    {

        public NecesidadesValoracionesRepository(PandemiaEntities context) : base(context)
        {

        }

        public int ContarValoracionesNecesidad(int idNecesidad)
        {
            int cantidadValoraciones = context.NecesidadesValoraciones.Where(o => o.IdNecesidad == idNecesidad).Count();

            return cantidadValoraciones;
        }

        public override void Modificar(NecesidadesValoraciones entity)
        {
            throw new NotImplementedException();
        }
    }
}
