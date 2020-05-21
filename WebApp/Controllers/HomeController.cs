using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models.ViewModels;
using Services.Home;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Inicio()
        {
            /*switch (id)
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
            }*/ 

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

        [HttpPost]
        public ActionResult Autorizacion(UsuarioIngresar usuario)
        {

            IngresarService srvIngresar = new IngresarService();
            srvIngresar.ValidarUsuario(usuario);

            return View();
        }
    }
}