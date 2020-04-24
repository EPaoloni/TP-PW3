using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Inicio()
        {
            return View();
        }
        
        [HttpGet]
        public ActionResult Ingresar()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Registrarse()
        {
            return View();
        }


    }
}