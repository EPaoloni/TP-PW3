using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Inicio(string id)
        {
            switch (id)
            {
                case "Ingresar":
                    ViewBag.Action = id;
                    break;
                case "Registrarse":
                    ViewBag.Action = id;
                    break;
                default:
                    ViewBag.Action = "PublicacionMasValorada";
                    break;
            } 

            return View();
        }
        
        [HttpGet]
        public ActionResult Ingresar()
        {
            return PartialView("pv_Ingresar");
        }

        [HttpGet]
        public PartialViewResult Registrarse()
        {
            return PartialView("pv_Registrarse");
        }


    }
}