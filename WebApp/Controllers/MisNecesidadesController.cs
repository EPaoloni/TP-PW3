﻿using Models.ORM;
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
    [Authorize]
    public class MisNecesidadesController : Controller
    {

        NecesidadService necesidadSrv = new NecesidadService(new PandemiaEntities());

        [HttpGet]
        public ActionResult Inicio()
        {
            List<Necesidades> necesidad = necesidadSrv.ObtenerPorUsuario(Int32.Parse(SesionHelper.IdUsuario));

            return View(necesidad);  
        }

        [HttpGet]
        // Recibe id necesidad
        public ActionResult VerDetalle(int id)
        {
            Necesidades necesidad = necesidadSrv.ObtenerPorId(id);

            return PartialView("pv_NecesidadDetalle", necesidad);
        }

        [HttpGet]
        public ActionResult Modificar(int id)
        {
            Necesidades necesidad = necesidadSrv.ObtenerPorId(id);

            return PartialView("pv_NecesidadModificar", necesidad);
        }

        [HttpPost]
        public ActionResult Modificar(Necesidades necesidad)
        {
            necesidadSrv.Modificar(necesidad);

            return RedirectToAction("Inicio");
        }
    }
}