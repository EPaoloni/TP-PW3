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

        public decimal GetTotalRecaudadoMonetaria(int IdNecesidadDonacionMonetaria)
        {
            return donacionMonetariaRepository.GetTotalRecaudadoMonetaria(IdNecesidadDonacionMonetaria);
        }

        public List<DonacionesInsumos> GetTotalRecaudadoInsumos(List<int> idNecesidadesDonacionesABuscar)
        {
            List<DonacionesInsumos> donaciones = donacionInsumoRepository.GetDonacionesInsumos(idNecesidadesDonacionesABuscar);

            if (donaciones == null)
            {
                return null;
            }

            List<DonacionesInsumos> totalPorInsumo = new List<DonacionesInsumos>();

            foreach(DonacionesInsumos donacion in donaciones)
            {
                if(totalPorInsumo.Any(item => item.IdNecesidadDonacionInsumo == donacion.IdNecesidadDonacionInsumo))
                {
                    DonacionesInsumos contadorInsumo = totalPorInsumo.First(item => item.IdNecesidadDonacionInsumo == donacion.IdNecesidadDonacionInsumo);
                    contadorInsumo.Cantidad += donacion.Cantidad;
                } else
                {
                    totalPorInsumo.Add(donacion);
                }
            }

            return totalPorInsumo;

        }
    }
}
