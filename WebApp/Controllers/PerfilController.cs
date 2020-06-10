using Models.Partial;
using Services.Home;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class PerfilController : Controller
    {
        UsuarioService usuarioSrv = new UsuarioService();

        [HttpGet]
        public ActionResult Inicio()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Guardar(PerfilMetaData perfil)
        {
            string rutaSitio = Server.MapPath("~/");
            string nombreArchivo = usuarioSrv.ObtenerNombreUsuario("asdfghjjkkl");
            nombreArchivo += Guid.NewGuid().ToString("N").Substring(0, 6);
            perfil.RutaFoto = Path.Combine(rutaSitio + "Files\\" + nombreArchivo + ".png");

            perfil.Archivo.SaveAs(perfil.RutaFoto);

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