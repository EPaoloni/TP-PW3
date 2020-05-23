using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Services.Home;
using WebApp.Helpers;
using Models.Partial;
using Models.Metadata;

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
        public ActionResult Ingresar(UsuariosMetadata usuario)
        {
            IngresarService srvIngresar = new IngresarService();
            SesionHelper sesionHelp = new SesionHelper();

            bool respuesta = srvIngresar.ValidarLogin(usuario);

            if (ModelState.IsValid)
            {
                if (respuesta == true)
                {
                    SesionHelper.UsuarioId = sesionHelp.GenerarID();
                    return RedirectToAction("Bienvenido");
                }                
            }

            return RedirectToAction("Ingresar");

        }
    }
}