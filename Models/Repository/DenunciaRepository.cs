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
    public class DenunciaRepository : BaseRepository<ORM.Denuncias>
    {

        public DenunciaRepository(PandemiaEntities context) : base(context)
        {

        }

        public int GetIdUltimaDenuncia()
        {
            return context.Denuncias.Max(o => o.IdDenuncia);
        }

        public int GetCantidadDenunciasMismaNecesidad(int idNecesidad)
        {
            return context.Denuncias.Where(o => o.IdNecesidad == idNecesidad).Count();
        }

        public void PasarNecesidadARevision(int idNecesidad)
        {
            Necesidades necesidad = context.Necesidades.SingleOrDefault(o => o.IdNecesidad == idNecesidad);

            //TODO: Verificar que el estado de revision sea 3
            necesidad.Estado = 3;

            context.SaveChanges();
        }

        public override void Modificar(Denuncias entity)
        {
            throw new NotImplementedException();
        }
    }
}
