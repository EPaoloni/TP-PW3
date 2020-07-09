﻿using Models.ORM;
using Models.Partial;
using Services.Usuario;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Filters;
using WebApp.Helpers;

namespace WebApp.Controllers
{
    public class PerfilController : Controller
    {
        PerfilService perfilSrv = new PerfilService();

        [Perfil]
        [HttpGet]
        public ActionResult Inicio()
        {
            PerfilMetaData perfil = perfilSrv.ObtenerPerfil(SesionHelper.Email);

            return View(perfil);
        }

        [HttpPost]
        public ActionResult Inicio(PerfilMetaData perfil)
        {
            if (ModelState.IsValid)
            {
                perfil.NombreUsuario = perfilSrv.GenerarNombreUsuario(perfil.Nombre, perfil.Apellido);
                perfil.Email = SesionHelper.Email;                
                
                perfilSrv.Guardar(perfil);
            }
            
            return View(perfil);
        }
        
        public ActionResult MisDonaciones()
        {
            return View();
        }
    }
}