using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models.ORM;
using Services.Home;
using WebApp.Helpers;

namespace WebApp.Controllers
{
    [Authorize]
    public class OtrasNecesidadesController : Controller
    {
        PandemiaEntities context;
        NecesidadService necesidadService;
        DonacionService donacionService;

        public OtrasNecesidadesController()
        {
            context = new PandemiaEntities();
            necesidadService = new NecesidadService(context);
        }


        [HttpGet]
        public ActionResult Inicio()
        {
            List<Necesidades> necesidad = necesidadService.OtrasNecesidades(Int32.Parse(SesionHelper.IdUsuario));

            return View(necesidad);
        }
    }
}