using Models.ORM;
using Models.Partial;
using Services.Usuario;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Helpers;

namespace WebApp.Controllers
{
    public class PerfilController : Controller
    {
        PerfilService perfilSrv = new PerfilService();

        [HttpGet]
        public ActionResult Inicio()
        {
            PerfilMetaData perfil = perfilSrv.ObtenerPerfil();

            return View(perfil);
        }

        [HttpPost]
        public ActionResult Guardar(PerfilMetaData perfil)
        {
            perfil.NombreUsuario = perfilSrv.GenerarNombreUsuario(perfil.Nombre, perfil.Apellido);
            //perfil.Email = SesionHelper.Email;
            perfil.Email = "test@ayudando.com.ar";
            //usuarioSrv.Guardar(perfil);
            perfilSrv.Guardar(perfil);

            return RedirectToAction("Inicio");
        }
        
        public ActionResult Datos()
        {
            return View();
        }

        public ActionResult MisDonaciones()
        {
            return View();
        }
    }
}