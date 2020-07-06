﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models.ORM;
using Models.ViewModels;
using Services.Home;
using WebApp.Helpers;

namespace WebApp.Controllers
{
    [Authorize]
    public class NecesidadController : Controller
    {
        PandemiaEntities context;
        NecesidadService necesidadService;
        DonacionService donacionService;

        public NecesidadController()
        {
            context = new PandemiaEntities();
            necesidadService = new NecesidadService(context);
            donacionService = new DonacionService(context);
        }

        // GET: Perfil
        public ActionResult Inicio()
        {
            return RedirectToAction("CrearNecesidad");
        }
        public ActionResult CrearNecesidad()
        {
            ViewBag.DonacionMonetariaCod = 1;
            ViewBag.DonacionInsumosCod = 2;

            if(TempData["errorMessage"] != null)
            {
                ViewBag.errorMessage = TempData["errorMessage"];
            }

            if (SesionHelper.IdUsuario == null)
            {
                ViewBag.miPerfilError = "Debe completar sus datos en Mi Perfil para poder crear una necesidad";
            }

            return View();
        }

        public ActionResult AltaNecesidad(NecesidadCreacion necesidad)
        {
            necesidad.IdUsuarioCreador = int.Parse(SesionHelper.IdUsuario);
            string mensajeError = necesidadService.CrearNecesidad(necesidad);

            if(mensajeError != "")
            {
                TempData["errorMessage"] = mensajeError;
                return RedirectToAction("CrearNecesidad");
            }

            return RedirectToAction("Inicio", "Home");
        }

        public ActionResult DetalleNecesidad(int idNecesidad)
        {
            Necesidades necesidad = necesidadService.GetNecesidadPorId(idNecesidad);


            if (necesidad == null)
            {
                ViewBag.errorMessage = "Ocurrió un error al consultar la necesidad";
                return View();
            }
            else
            {
                return View(necesidad);
            }

        }

        public ActionResult ModificarNecesidad(int idNecesidad)
        {
            Necesidades necesidad = necesidadService.GetNecesidadPorId(idNecesidad);


            if(necesidad == null)
            {
                ViewBag.errorMessage = "Ocurrió un error al consultar la necesidad";
            } else
            {
                NecesidadModificacion necesidadModificacion = necesidadService.GenerarNecesidadModificacion(necesidad);
                return View(necesidadModificacion);
            }

            return View();
        }

        public ActionResult RealizarModificacion(NecesidadModificacion necesidadModificacion)
        {
            necesidadService.ModificarNecesidad(necesidadModificacion);

            return RedirectToAction("DetalleNecesidad", new { idNecesidad = necesidadModificacion.IdNecesidad });
        }

        public ActionResult BajaNecesidad(int idNecesidad)
        {
            necesidadService.BajaNecesidad(idNecesidad);

            return RedirectToAction("Inicio");
        }

        public ActionResult VotarNecesidad(int valoracion, int idNecesidad)
        {
            NecesidadesValoraciones necesidadValoracion = new NecesidadesValoraciones()
            {
                //TODO: Sacar este hardcode
                IdUsuario = 1,
                Valoracion = (valoracion == 1) ? true : false,
                IdNecesidad = idNecesidad
            };

            necesidadService.AgregarValoracionNecesidad(necesidadValoracion, context);

            return RedirectToAction("DetalleNecesidad", new { idNecesidad = idNecesidad });
        }

        public ActionResult AgregarDenuncia(int idNecesidad, int motivoDenuncia, string comentario)
        {
            DenunciaService denunciaService = new DenunciaService(context);

            int idUsuario = int.Parse(SesionHelper.IdUsuario);

            denunciaService.Crear(idNecesidad, motivoDenuncia, comentario, idUsuario);

            return RedirectToAction("DetalleNecesidad", new { idNecesidad = idNecesidad });
        }

        public ActionResult RealizarDonacionMonetaria(int idNecesidad, decimal monto, string comprobante)
        {
            DonacionesMonetarias donacionesMonetarias = new DonacionesMonetarias();
            donacionesMonetarias.ArchivoTransferencia = comprobante;
            donacionesMonetarias.Dinero = monto;
            donacionesMonetarias.FechaCreacion = DateTime.Now;
            donacionesMonetarias.IdUsuario = int.Parse(SesionHelper.IdUsuario);

            donacionesMonetarias.NecesidadesDonacionesMonetarias = necesidadService.GetNecesidadesDonacionesMonetarias(idNecesidad);


            donacionService.CrearDonacionMonetaria(donacionesMonetarias);

            return RedirectToAction("DetalleNecesidad", new { idNecesidad = idNecesidad });
        }

        public ActionResult RealizarDonacionInsumo(int idNecesidad, int insumo, int cantidad)
        {
            DonacionesInsumos donacionesInsumos = new DonacionesInsumos()
            {
                IdNecesidadDonacionInsumo = insumo,
                Cantidad = cantidad,
                FechaCreacion = DateTime.Now,
                IdUsuario = int.Parse(SesionHelper.IdUsuario),
            };

            donacionesInsumos.NecesidadesDonacionesInsumos = necesidadService.GetNecesidadesDonacionesInsumos(idNecesidad, insumo);

            donacionService.CrearDonacionInsumo(donacionesInsumos);

            return RedirectToAction("DetalleNecesidad", new { idNecesidad = idNecesidad });
        }
        [HttpGet]
        public ActionResult MisNecesidades()
        {
            return View();
        }
    }
}