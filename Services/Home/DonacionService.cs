using Models.ORM;
using Models.Repository;
using Models.ViewModels;
using Services.Usuario;
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
        NecesidadService necesidadService;
        public DonacionService(PandemiaEntities context)
        {
            donacionMonetariaRepository = new DonacionMonetariaRepository(context);
            donacionInsumoRepository = new DonacionInsumoRepository(context);
            necesidadService = new NecesidadService(context);
        }

        public void CrearDonacionMonetaria(DonacionMonetaria donacion)
        {
            string path = GuardarArchivo(donacion);

            DonacionesMonetarias donacionesMonetarias = new DonacionesMonetarias()
            {
                ArchivoTransferencia = path,
                Dinero = donacion.Monto,
                IdUsuario = donacion.IdUsuario,
                FechaCreacion = DateTime.Now,
                NecesidadesDonacionesMonetarias = necesidadService.GetNecesidadesDonacionesMonetarias(donacion.IdNecesidad)
            };

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

            foreach(int idNecesidadDonacion in idNecesidadesDonacionesABuscar)
            {
                DonacionesInsumos item = new DonacionesInsumos()
                {
                    IdNecesidadDonacionInsumo = idNecesidadDonacion,
                    Cantidad = 0,
                };
                totalPorInsumo.Add(item);
            }

            foreach(DonacionesInsumos donacion in donaciones)
            {
                if(totalPorInsumo.Any(item => item.IdNecesidadDonacionInsumo == donacion.IdNecesidadDonacionInsumo))
                {
                    DonacionesInsumos contadorInsumo = totalPorInsumo.First(item => item.IdNecesidadDonacionInsumo == donacion.IdNecesidadDonacionInsumo);
                    contadorInsumo.Cantidad += donacion.Cantidad;
                }
            }

            return totalPorInsumo;

        }
        public string GuardarArchivo(DonacionMonetaria donacion)
        {
            ArchivoService archivoService = new ArchivoService();

            string rutaAux = archivoService.Guardar(donacion.ArchivoTransferencia, "comprobantes-necesidad-" + donacion.IdNecesidad.ToString(), "donacion-usuario-" + donacion.IdUsuario.ToString());

            return rutaAux;
        }
    }
}
