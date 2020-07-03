using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Services.Home;
using WebApp.Helpers;
using Models.Partial;
using Models.ORM;
using WebApp.ViewModels;

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
        public ActionResult Ingresar(IngresarMetaData usuario)
        {
            IngresarService ingresarSrv = new IngresarService();

            ingresarSrv.ValidarLogin(usuario);

            if (ModelState.IsValid)
            {
                if (usuario.RespuestaLogin == true)
                {
                    //SesionHelper.UsuarioId = SesionHelper.GenerarID();
                    UsuarioLogeadoHelper.Email = SesionHelper.email;
                    UsuarioLogeadoHelper.NombreUsuario = "Nombre.Apellido";
                    return RedirectToAction("Inicio","Perfil");                  
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
        public ActionResult Registrarse(RegistrarseMetaData usuario)
        {
            if (ModelState.IsValid)
            {
                RegistrarseService usuarioSrv = new RegistrarseService();
                usuarioSrv.Agregar(usuario);
                return RedirectToAction("Ingresar");
            }

            return View(usuario);
        }

        [HttpGet]
        public ActionResult Bienvenido()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Activar(string token)
        {
            RegistrarseService usuarioSrv = new RegistrarseService();

            usuarioSrv.Activar(token);

            return RedirectToAction("Inicio");
        }

        public string GetAllNecesidades()
        {
            PandemiaEntities context = new PandemiaEntities();
            NecesidadService necesidadService = new NecesidadService();

            List<Necesidades> necesidades = necesidadService.GetNecesidades(context);

            return necesidades[0].Nombre;

        }
    }
}