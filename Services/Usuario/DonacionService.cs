using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.ORM;
using Models.Partial;
using Models.Repository;

namespace Services.Usuario
{
    public class DonacionService
    {
        //DonacionesTipo donacionTipoRepo;
        DonacionInsumoRepository donacionInsumoRepo;
        DonacionMonetariaRepository donacionMonetariaRepo;
        public DonacionService()
        {
            PandemiaEntities context = new PandemiaEntities();
            //donacionTipoRepo = new DenunciaTipoRepository(context);
            donacionInsumoRepo = new DonacionInsumoRepository(context);
            donacionMonetariaRepo = new DonacionMonetariaRepository(context);
        }

        public List<DonacionHistorialMetaData> ObtenerHistorial()
        {
            List<DonacionHistorialMetaData> listaHistorial = new List<DonacionHistorialMetaData>();

            // Obtener Necesidad Monetaria
            List<DonacionesMonetarias> listaMonetaria = donacionMonetariaRepo.ObtenerTodos();

            foreach (DonacionesMonetarias donacionMonetaria in listaMonetaria)
            {
                DonacionHistorialMetaData donacionHistoria = new DonacionHistorialMetaData();
                donacionHistoria.IdNecesidad = donacionMonetaria.IdNecesidadDonacionMonetaria;
                donacionHistoria.Nombre = donacionMonetaria.NecesidadesDonacionesMonetarias.Necesidades.Nombre;
                donacionHistoria.Fecha = donacionMonetaria.FechaCreacion;
                donacionHistoria.Tipo = donacionMonetaria.NecesidadesDonacionesMonetarias.Necesidades.DonacionesTipo.Descripcion;
                donacionHistoria.Estado = donacionMonetaria.NecesidadesDonacionesMonetarias.Necesidades.NecesidadesEstado.Descripcion;
                donacionHistoria.TotalRecaudado = donacionMonetaria.NecesidadesDonacionesMonetarias.Dinero.ToString();
                donacionHistoria.MiDonacion = donacionMonetaria.Dinero.ToString();

                listaHistorial.Add(donacionHistoria);
            }

            // Obtener Necesidad Insumo
            List<DonacionesInsumos> listaInsumo = donacionInsumoRepo.ObtenerTodos();

            foreach (DonacionesInsumos donacionInsumo in listaInsumo)
            {
                DonacionHistorialMetaData donacionHistoria = new DonacionHistorialMetaData();
                donacionHistoria.IdNecesidad = donacionInsumo.IdNecesidadDonacionInsumo;
                donacionHistoria.Nombre = donacionInsumo.NecesidadesDonacionesInsumos.Necesidades.Nombre;
                donacionHistoria.Fecha = donacionInsumo.FechaCreacion;
                donacionHistoria.Tipo = donacionInsumo.NecesidadesDonacionesInsumos.Necesidades.DonacionesTipo.Descripcion;
                donacionHistoria.Estado = donacionInsumo.NecesidadesDonacionesInsumos.Necesidades.DonacionesTipo.Descripcion;
                donacionHistoria.TotalRecaudado = donacionInsumo.NecesidadesDonacionesInsumos.Cantidad.ToString();
                donacionHistoria.MiDonacion = donacionInsumo.Cantidad.ToString();

                listaHistorial.Add(donacionHistoria);
            }

            return listaHistorial.OrderBy(h => h.Fecha).ToList();
        }
    }
}
