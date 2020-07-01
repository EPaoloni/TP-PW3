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
        public ActionResult Inicio(PerfilMetaData perfil)
        {
            if (ModelState.IsValid)
            {
                perfil.NombreUsuario = perfilSrv.GenerarNombreUsuario(perfil.Nombre, perfil.Apellido);
                //perfil.Email = SesionHelper.Email;
                perfil.Email = "Maria.Perez.2@outlook.com";
                //usuarioSrv.Guardar(perfil);
                perfilSrv.Guardar(perfil);
            }
            
            return View(perfil);
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