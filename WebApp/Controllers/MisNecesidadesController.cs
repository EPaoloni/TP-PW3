using Models.ORM;
using Services.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Helpers;

namespace WebApp.Controllers
{
    public class MisNecesidadesController : Controller
    {

        NecesidadService necesidadSrv = new NecesidadService();

        [HttpGet]
        public ActionResult Inicio()
        {
            List<Necesidades> necesidad = necesidadSrv.ObtenerPorUsuario(SesionHelper.IdUsuario);

            return View(necesidad);  
        }

        [HttpGet]
        // Recibe id necesidad
        public ActionResult VerDetalle(int id)
        {
            Necesidades necesidad = necesidadSrv.ObtenerPorId(id);

            return PartialView("pv_NecesidadDetalle", necesidad);
        }
    }
}