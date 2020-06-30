using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models.ORM;
using Models.ViewModels;
using Services.Home;

namespace WebApp.Controllers
{
    public class NecesidadController : Controller
    {
        PandemiaEntities context;
        NecesidadService necesidadService;

        public NecesidadController()
        {
            context = new PandemiaEntities();
            necesidadService = new NecesidadService(context);
        }

        // GET: Perfil
        public ActionResult Inicio()
        {
            return RedirectToAction("CrearNecesidad");
        }
        public ActionResult CrearNecesidad()
        {
            ViewBag.DonacionMonetariaCod = 1;
            ViewBag.DonacionInsumosCod = 2;

            return View();
        }

        public ActionResult AltaNecesidad(NecesidadCreacion necesidad)
        {
            //necesidad.IdUsuarioCreador = int.Parse(Session["UsuarioId"].ToString());
            //Por el momento hardcodear el id de un usuario
            necesidad.IdUsuarioCreador = 3;
            necesidadService.CrearNecesidad(necesidad);
            return RedirectToAction("Inicio");
        }
    }
}