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
    [Authorize]
    public class DenunciaController : Controller
    {
        DenunciaService denunciaSrv = new DenunciaService();

        [HttpGet]
        public ActionResult Inicio()
        {
            List<Denuncias> denuncia = denunciaSrv.ObtenerTodosPendientes()
                                                  .OrderBy(n => n.FechaCreacion)
                                                  .ToList();

            return View(denuncia);
        }

        [HttpGet]
        // Recibe id denuncia
        public ActionResult Desestimar(int id)
        {
            denunciaSrv.Desestimar(id);

            return RedirectToAction("Inicio");
        }

        [HttpGet]
        // Recibe id denuncia
        public ActionResult Aceptar(int id)
        {
            denunciaSrv.Aceptar(id);

            return RedirectToAction("Inicio");
        }

        [HttpGet]
        // Recibe id denuncia
        public ActionResult VerComentarios(int id)
        {
            Denuncias denuncia = denunciaSrv.ObtenerPorId(id);

            return PartialView("pv_DenunciaComentarios", denuncia); 
        }

        [HttpGet]
        // Recibe id denuncia
        public ActionResult VerDetalle(int id)
        {
            Denuncias denuncia = denunciaSrv.ObtenerPorId(id);

            return PartialView("pv_DenunciaDetalle", denuncia);
        }

    }
}