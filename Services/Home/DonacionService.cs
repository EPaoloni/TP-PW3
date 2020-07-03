using Models.ORM;
using Models.Repository;
using Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Home
{
    public class DonacionService
    {
        DonacionMonetariaRepository donacionMonetariaRepository;
        DonacionInsumoRepository donacionInsumoRepository;
        public DonacionService(PandemiaEntities context)
        {
            donacionMonetariaRepository = new DonacionMonetariaRepository(context);
            donacionInsumoRepository = new DonacionInsumoRepository(context);
        }

        public void CrearDonacionMonetaria(DonacionesMonetarias donacionesMonetarias)
        {
            donacionMonetariaRepository.Crear(donacionesMonetarias);
        }

        public void CrearDonacionInsumo(DonacionesInsumos donacionesInsumos)
        {
            donacionInsumoRepository.Crear(donacionesInsumos);
        }
    }
}
