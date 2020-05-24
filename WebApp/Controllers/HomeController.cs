using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Services.Home;
using WebApp.Helpers;
using Models.ORM;

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
                    ViewBag.Action = "pv_Ingresar";
                    break;
                case "Registrarse":
                    ViewBag.Action = "pv_Registrarse";
                    break;
                default:
                    ViewBag.Action = "pv_PublicacionMasValorada";
                    break;
            } 

            return View();
        }

        [HttpPost]
        public ActionResult Ingresar(UsuariosPartial usuario)
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