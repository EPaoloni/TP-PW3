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
        
        readonly string rutaSitio = HttpContext.Current.Server.MapPath("~/");
        const string CARPETA_ARCHIVOS = "Files";
        
        public string Guardar(HttpPostedFileBase archivo, string nombreUsuario, string nombreArchivo)
        {
            string rutaRelativa = "";
          
            if (archivo != null)
            {
                string rutaCarpeta = Path.Combine(rutaSitio + CARPETA_ARCHIVOS + "\\" + nombreUsuario);

                if (Directory.Exists(rutaCarpeta) == false)
                {
                    Directory.CreateDirectory(rutaCarpeta);                    
                }

                string rutaArchivo = rutaCarpeta + "\\" + nombreArchivo + ".png";

                rutaRelativa = CARPETA_ARCHIVOS + "\\" + nombreUsuario + "\\" + nombreArchivo + ".png";
                archivo.SaveAs(rutaArchivo);
                
            }

            return rutaRelativa;

        }

    }
}
