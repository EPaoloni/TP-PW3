using Models.ORM;
using Models.Partial;
using Services.Home;
using Services.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Helpers;

namespace WebApp.Controllers
{
    public class MisDonacionesController : Controller
    {
        HistorialDonacionService donacionSrv = new HistorialDonacionService();
        NecesidadService NecesidadSrv = new NecesidadService(new PandemiaEntities());

        [HttpGet]
        public ActionResult Inicio()
        {           
            List<DonacionHistorialMetaData> lista = donacionSrv.GetMisDonaciones(SesionHelper.IdUsuario);

            return View(lista);
        }

        [HttpGet]
        // Recibe id necesidad
        public ActionResult VerDetalle(int id)
        {
            Necesidades necesidad = NecesidadSrv.ObtenerPorId(id);

            return PartialView("pv_DonacionDetalle", necesidad);
        }
    }
}