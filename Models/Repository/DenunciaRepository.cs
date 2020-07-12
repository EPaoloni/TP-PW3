using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.ORM;

namespace Models.Repository
{
    public class DenunciaRepository : BaseRepository<Denuncias>
    {
        public DenunciaRepository(PandemiaEntities context) : base(context)
        {

        }
        public int GetIdUltimaDenuncia()
        {
            return context.Denuncias.Select(o => o.IdDenuncia).DefaultIfEmpty(0).Max();
        }

        public int GetCantidadDenunciasMismaNecesidad(int idNecesidad)
        {
            return context.Denuncias.Where(o => o.IdNecesidad == idNecesidad).Count();
        }

        public void PasarNecesidadARevision(int idNecesidad)
        {
            Necesidades necesidad = context.Necesidades.SingleOrDefault(o => o.IdNecesidad == idNecesidad);

            //TODO: Verificar que el estado de revision sea 3
            necesidad.Estado = 2;

            context.SaveChanges();
        }
     
        public void Desestimar(int idDenuncia, DenunciasEstado estado)
        {
            Denuncias reg = ObtenerPorId(idDenuncia);
            reg.DenunciasEstado = estado;

            context.SaveChanges();
        }

        public void Aceptar(int idDenuncia, DenunciasEstado estado)
        {
            Denuncias reg = ObtenerPorId(idDenuncia);
            reg.DenunciasEstado = estado;

            context.SaveChanges();
        }
    }
}
