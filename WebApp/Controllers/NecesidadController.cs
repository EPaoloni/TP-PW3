using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models.ORM;
using Models.ViewModels;
using Services.Home;

namespace WebApp.Controllers
{
    public class NecesidadController : Controller
    {
        PandemiaEntities context;
        NecesidadService necesidadService;

        public NecesidadController()
        {
            context = new PandemiaEntities();
            necesidadService = new NecesidadService(context);
        }

        // GET: Perfil
        public ActionResult Inicio()
        {
            return RedirectToAction("CrearNecesidad");
        }
        public ActionResult CrearNecesidad()
        {
            ViewBag.DonacionMonetariaCod = 1;
            ViewBag.DonacionInsumosCod = 2;

            if(TempData["errorMessage"] != null)
            {
                ViewBag.errorMessage = TempData["errorMessage"];
            }

            //TODO: Hay que guardar el username en sesion al loguearse y despues de agregar los datos necesarios
            //if(Session["username"] == null)
            //{
            //    ViewBag.miPerfilError = "Debe completar sus datos en Mi Perfil para poder crear una necesidad";
            //}

            return View();
        }

        public ActionResult AltaNecesidad(NecesidadCreacion necesidad)
        {
            //necesidad.IdUsuarioCreador = int.Parse(Session["UsuarioId"].ToString());
            //Por el momento hardcodear el id de un usuario
            necesidad.IdUsuarioCreador = 3;
            string mensajeError = necesidadService.CrearNecesidad(necesidad);

            if(mensajeError != "")
            {
                TempData["errorMessage"] = mensajeError;
                return RedirectToAction("CrearNecesidad");
            }

            return RedirectToAction("Inicio", "Home");
        }

        public ActionResult DetalleNecesidad(int idNecesidad)
        {
            Necesidades necesidad = necesidadService.GetNecesidadPorId(idNecesidad);
            ViewBag.necesidad = necesidad;
            return View();
        }

        public ActionResult ModificarNecesidad(int idNecesidad)
        {
            Necesidades necesidad = necesidadService.GetNecesidadPorId(idNecesidad);


            if(necesidad == null)
            {
                ViewBag.errorMessage = "Ocurrió un error al consultar la necesidad";
            } else
            {
                NecesidadModificacion necesidadModificacion = necesidadService.GenerarNecesidadModificacion(necesidad);
                return View(necesidadModificacion);
            }

            return View();
        }

        public ActionResult RealizarModificacion(NecesidadModificacion necesidadModificacion)
        {
            necesidadService.ModificarNecesidad(necesidadModificacion);

            return View("DetalleNecesidad", necesidadModificacion.IdNecesidad);
        }

        public ActionResult BajaNecesidad(int idNecesidad)
        {
            necesidadService.BajaNecesidad(idNecesidad);

            return RedirectToAction("Inicio");
        }
    }
}