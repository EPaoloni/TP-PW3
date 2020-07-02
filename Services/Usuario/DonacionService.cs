using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Models.ORM;
using Models.Partial;
using Models.Repository;
using Newtonsoft.Json;

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

        public List<DonacionHistorialMetaData> ObtenerHistorial(int idUsuario)
        {
            List<DonacionHistorialMetaData> listaHistorial = new List<DonacionHistorialMetaData>();

            // Obtener Necesidad Monetaria
            List<DonacionesMonetarias> listaMonetaria = donacionMonetariaRepo.ObtenerTodos();

            var queryMonetaria = from m in listaMonetaria
                                 where m.IdUsuario == idUsuario
                                 select m;

            foreach (DonacionesMonetarias donacionMonetaria in queryMonetaria)
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

            var queryInsumo = from i in listaInsumo
                              where i.IdUsuario == idUsuario
                              select i;

            foreach (DonacionesInsumos donacionInsumo in queryInsumo)
            {
                DonacionHistorialMetaData donacionHistoria = new DonacionHistorialMetaData();
                donacionHistoria.IdNecesidad = donacionInsumo.IdNecesidadDonacionInsumo;
                donacionHistoria.Nombre = donacionInsumo.NecesidadesDonacionesInsumos.Necesidades.Nombre;
                donacionHistoria.Fecha = donacionInsumo.FechaCreacion;
                donacionHistoria.Tipo = donacionInsumo.NecesidadesDonacionesInsumos.Necesidades.DonacionesTipo.Descripcion;
                donacionHistoria.Estado = donacionInsumo.NecesidadesDonacionesInsumos.Necesidades.NecesidadesEstado.Descripcion;
                donacionHistoria.TotalRecaudado = donacionInsumo.NecesidadesDonacionesInsumos.Cantidad.ToString();
                donacionHistoria.MiDonacion = donacionInsumo.Cantidad.ToString();

                listaHistorial.Add(donacionHistoria);
            }

            return listaHistorial.OrderBy(h => h.Fecha).ToList();
        }

        public List<DonacionHistorialMetaData> GetMisDonaciones(int id)
        {
            var url = $"http://localhost:53008/Api/Rest/"+id;
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            using (WebResponse response = request.GetResponse())
            {
                using (Stream strReader = response.GetResponseStream())
                {
                    if (strReader == null) return new List<DonacionHistorialMetaData>();
                    using (StreamReader objReader = new StreamReader(strReader))
                    {
                        string responseBody = objReader.ReadToEnd();
                        var result = JsonConvert.DeserializeObject<List<DonacionHistorialMetaData>>(responseBody);
                        return result;
                    }
                }
            }
        }
    }
}
