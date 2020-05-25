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
        public ActionResult Inicio()
        {            
            return View("PublicacionMasValorada");
        }

        [HttpGet]
        public ActionResult Ingresar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ingresar(UsuariosPartial usuario)
        {
            IngresarService srvIngresar = new IngresarService();
            SesionHelper sesionHelp = new SesionHelper();

            srvIngresar.ValidarLogin(usuario);

            if (ModelState.IsValid)
            {
                if (usuario.RespuestaLogin == true)
                {
                    SesionHelper.UsuarioId = sesionHelp.GenerarID();
                    return RedirectToAction("Bienvenido");                  
                }
   
            }

            return View(usuario);

        }

        [HttpGet]
        public ActionResult Registrarse()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registrarse(UsuariosPartial usuario)
        {
            return View();
        }

        [HttpGet]
        public ActionResult Bienvenido()
        {
            return View();
        }
    }
}