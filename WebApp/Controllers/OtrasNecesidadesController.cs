using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models.ORM;
using Models.Partial;
using Services.Home;
using WebApp.Helpers;
using Services.Usuario;

namespace WebApp.Controllers
{
    [Authorize]
    public class OtrasNecesidadesController : Controller
    {
        PandemiaEntities context;
        NecesidadService necesidadService;
        DonacionService donacionService;
        PaginadorService paginadorSrv;

        public OtrasNecesidadesController()
        {
            context = new PandemiaEntities();
            necesidadService = new NecesidadService(context);
            paginadorSrv = new PaginadorService();
        }

        [HttpGet]
        public ActionResult Inicio(int pagina = 1)
        {
            List<Necesidades> necesidad = necesidadService.OtrasNecesidades(Int32.Parse(SesionHelper.IdUsuario))
                                                          .Where(a => a.FechaFin >= DateTime.Now).ToList();

            PaginadorModel lista = paginadorSrv.Paginacion(necesidad, pagina);



            return View(lista);
        }
    }
}