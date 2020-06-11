using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Partial;
using Models.Repository;

namespace Services.Usuario
{
    public class UsuarioService
    {
        PerfilRepository perfilRepo = new PerfilRepository();

        public string GenerarNombreUsuario(string nombre, string apellido)
        {
            string nombreUsuario = "";

            int cantUsuario = perfilRepo.ValidarNombreUsuario(nombre, apellido);

            if (cantUsuario > 0)
            {
                nombreUsuario = nombre + "." + apellido + cantUsuario;
            }
            else
            {
                nombreUsuario = nombre + "." + apellido;
            }

            return nombreUsuario;
        }

        public string ObtenerNombreUsuario(string token)
        {
            return "userTest";
        }

        public string ObtenerToken(string email)
        {
            return "d1s24d5674e6";
        }

        public void Guardar(PerfilMetaData perfil)
        {
            ArchivoService archivoSrv = new ArchivoService();
            PerfilRepository perfilRepo = new PerfilRepository();

            perfil.RutaFoto = archivoSrv.Guardar(perfil.Archivo, perfil.NombreUsuario, "perfil");

            perfilRepo.Guardar(perfil);
        }
    }
}
