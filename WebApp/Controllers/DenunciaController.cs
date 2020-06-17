using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Services.Usuario;
using Models.Partial;
using Models.ORM;

namespace WebApp.Controllers
{
    public class DenunciaController : Controller
    {
        DenunciaService denunciaSrv = new DenunciaService();

        [HttpGet]
        public ActionResult Inicio()
        {
            List<Denuncias> denuncia = denunciaSrv.ObtenerTodos();

            return View(denuncia);
        }
    }
}