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
        PandemiaEntities context;
        NecesidadService necesidadService;

        public HomeController()
        {
            context = new PandemiaEntities();
            necesidadService = new NecesidadService(context);
        }

        [HttpGet]
        public ActionResult Inicio()
        {
            List<Necesidades> topNecesidades = necesidadService.GetTopNecesidades();
            ViewBag.Necesidades = topNecesidades;
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
            SesionHelper sesionHelp = new SesionHelper();

            ingresarSrv.ValidarLogin(usuario);

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
        public ActionResult Registrarse(RegistrarseMetaData usuario)
        {
            if (ModelState.IsValid)
            {
                UsuarioService usuarioSrv = new UsuarioService();
                usuarioSrv.Agregar(usuario);
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
            UsuarioService usuarioSrv = new UsuarioService();

            usuarioSrv.Activar(token);

            return RedirectToAction("Inicio");
        }

        public ActionResult BuscarPorNombre(string nombre)
        {
            List<Necesidades> necesidades = necesidadService.GetNecesidadesPorNombre(nombre);

            ViewBag.Necesidades = necesidades;

            return View("PublicacionMasValorada");
        }
    }
}