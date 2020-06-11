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
        const string CARPETA_ARCHIVOS = "Files";
        
        UsuarioService usuarioSrv = new UsuarioService();

        //string nombreArchivo = usuarioSrv.ObtenerNombreUsuario("asdfghjjkkl");
        //nombreArchivo += Guid.NewGuid().ToString("N").Substring(0, 6);


        public string Guardar(HttpPostedFileBase archivo, string nombreUsuario, string nombreArchivo)
        {
            string rutaCarpeta = Path.Combine(rutaSitio + "\\" + CARPETA_ARCHIVOS + "\\" + nombreUsuario);

            if (Directory.Exists(rutaCarpeta) == false)
            {
                //string ruta = Path.Combine(rutaCompleta)

                Directory.CreateDirectory(rutaCarpeta);
            }

            string rutaArchivo = rutaCarpeta + "\\" + nombreArchivo + ".png";

            archivo.SaveAs(rutaArchivo);

            return rutaArchivo;

        }


    }
}
