using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web;

namespace Services.Usuario
{
    public class ArchivoService 
    {
        readonly string pathSitio = System.AppDomain.CurrentDomain.BaseDirectory;
        readonly string rutaSitio = HttpContext.Current.Server.MapPath("~/");

        UsuarioService usuarioSrv = new UsuarioService();

        //string nombreArchivo = usuarioSrv.ObtenerNombreUsuario("asdfghjjkkl");
        //nombreArchivo += Guid.NewGuid().ToString("N").Substring(0, 6);


        public void Guardar(HttpPostedFileBase archivo, string nombreUsuario)
        {
            


        }


    }
}
