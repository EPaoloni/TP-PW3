﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class NecesidadController : Controller
    {
        // GET: Perfil
        public ActionResult Inicio()
        {
            return RedirectToAction("CrearNecesidad");
        }
        public ActionResult CrearNecesidad()
        {
            return View();
        }

        [HttpGet]
        public ActionResult MisNecesidades()
        {
            return View();
        }
    }
}