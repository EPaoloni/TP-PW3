using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Services.Usuario;
using Models.Partial;

namespace WebApp.Controllers
{
    public class DenunciaController : Controller
    {
        DenunciaService denunciaSrv = new DenunciaService();

        [HttpGet]
        public ActionResult Inicio()
        {
            List<DenunciaMetaData> denuncia = denunciaSrv.ObtenerTodos();

            return View(denuncia);
        }
    }
}