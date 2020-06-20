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
