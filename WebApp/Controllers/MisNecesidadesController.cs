using Services.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class MisNecesidadesController : Controller
    {

        NecesidadService necesidadSrv = new NecesidadService();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
    }
}