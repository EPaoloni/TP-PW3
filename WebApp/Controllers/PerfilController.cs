using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class PerfilController : Controller
    {
        // GET: Perfil
        public ActionResult Inicio()
        {
            return RedirectToAction("Datos");
        }
        public ActionResult Datos()
        {
            return View();
        }

        public ActionResult MisDonaciones()
        {
            return View();
        }
    }
}