using Models.Partial;
using Services.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class MisDonacionesController : Controller
    {
        DonacionService donacionSrv = new DonacionService();

        [HttpGet]
        public ActionResult Inicio()
        {
            int idUsuario = 10;
            List<DonacionHistorialMetaData> lista = donacionSrv.GetMisDonaciones(idUsuario);

            return View(lista);
        }
    }
}