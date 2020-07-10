using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.ORM;

namespace Models.Repository
{
    public class DonacionInsumoRepository : BaseRepository<DonacionesInsumos>
    {
        public DonacionInsumoRepository(PandemiaEntities context) : base(context)
        {

        }

        public List<DonacionesInsumos> GetDonacionesInsumos(List<int> IdNecesidadDonacionInsumos)
        {
            var donacionesInsumosRealizadas = context.DonacionesInsumos.Where(donacion => IdNecesidadDonacionInsumos.Contains(donacion.IdNecesidadDonacionInsumo));

            if (donacionesInsumosRealizadas != null)
            {
                List<DonacionesInsumos> donacionesInsumos = new List<DonacionesInsumos>(donacionesInsumosRealizadas);

                return donacionesInsumos;
            } else
            {
                return null;
            }
        }
    }
}
