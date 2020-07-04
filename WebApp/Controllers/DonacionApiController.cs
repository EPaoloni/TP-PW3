using Models.Partial;
using Services.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApp.Controllers
{
    public class DonacionApiController : ApiController
    {
        DonacionService donacionSrv = new DonacionService();

        // Recibe id usuario
        public List<DonacionHistorialMetaData> Get(int id)
        {
            return donacionSrv.ObtenerHistorial(id);
        }
    }
}