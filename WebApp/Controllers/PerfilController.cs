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
        UsuarioService usuarioSrv = new UsuarioService();
        ArchivoService archivoSrv = new ArchivoService();

        [HttpGet]
        public ActionResult Inicio()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Guardar(PerfilMetaData perfil)
        {
            perfil.NombreUsuario = usuarioSrv.GenerarNombreUsuario(perfil.Nombre, perfil.Apellido);
            perfil.Email = SesionHelper.Email;
            usuarioSrv.Guardar(perfil);

            //perfil.Archivo.SaveAs(perfil.RutaFoto);

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