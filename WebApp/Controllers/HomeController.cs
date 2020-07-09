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
using System.Web.Security;

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
            List<Necesidades> necesidades = necesidadService.GetTopNecesidades();

            ViewBag.necesidades = necesidades;

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
                    SesionHelper.Email = usuario.Email;
                    SesionHelper.UserName = usuario.UserName;
                    SesionHelper.IdUsuario = usuario.IdUsuario.ToString();
                    SesionHelper.TipoUsuario = usuario.TipoUsuario;
                    FormsAuthentication.SetAuthCookie(SesionHelper.IdUsuario, false);

                    if (usuario.Activo == true)
                    {
                        return RedirectToAction("Inicio", "Perfil");
                    }
                    else
                    {
                        return View(usuario);
                    }                 
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
            NecesidadService necesidadService = new NecesidadService(context);

            List<Necesidades> necesidades = necesidadService.GetNecesidades(context);

            return necesidades[0].Nombre;

        }

        [HttpGet]
        public ActionResult Error(int error = 0)
        {
            MensajeError mensajeError = new MensajeError();

            switch (error)
            {
                case 505:
                    mensajeError.Codigo = "505";
                    mensajeError.Titulo = "Ocurrio un error inesperado";                    
                    break;

                case 404:
                    mensajeError.Codigo = "404";
                    mensajeError.Titulo = "Página no encontrada";                    
                    break;

                default:
                    mensajeError.Codigo = "Error al mostrar la pagina web";
                    mensajeError.Titulo = "Error inesperado";                    
                    break;
            }

            return View("~/Views/Shared/_ErrorPage.cshtml", mensajeError);
        }

        [Authorize]
        [HttpGet]
        public ActionResult Salir()
        {
            SesionHelper.EliminarSesion();
            FormsAuthentication.SignOut();

            return RedirectToAction("Inicio");
        }

        [Authorize]
        [HttpGet]
        public ActionResult AcercaDe()
        {
            return View();
        }
    }
}