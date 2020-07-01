using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Models.Partial;
using Services.Usuario;

namespace WebAPI.Controllers
{
    public class MisDonacionesController : ApiController
    {
        DonacionService donacionSrv = new DonacionService();
        public List<DonacionHistorialMetaData> Get()
        {
            return donacionSrv.ObtenerHistorial(10);
        }
    }
}
