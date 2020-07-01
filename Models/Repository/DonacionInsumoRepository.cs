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
    }
}
