using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.ORM;
using Models.Partial;
using Models.Repository;

namespace Services.Usuario
{
    public class PerfilService
    {
        UsuarioRepository usuarioRepo;

        public PerfilService()
        {
            PandemiaEntities context = new PandemiaEntities();
            usuarioRepo = new UsuarioRepository(context);
        }

        public string GenerarNombreUsuario(string nombre, string apellido)
        {
            string nombreUsuario = "";

            int cantUsuario = usuarioRepo.ValidarNombreUsuario(nombre, apellido);

            if (cantUsuario > 1)
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

        public PerfilMetaData ObtenerPerfil()
        {
            Usuarios usuario = usuarioRepo.ObtenerPorEmail("Maria.Perez.2@outlook.com");

            PerfilMetaData perfil = new PerfilMetaData();
            perfil.Nombre = usuario.Nombre != null ? usuario.Nombre : "";
            perfil.Apellido = usuario.Apellido != null ? usuario.Apellido : "";
            perfil.FechaNacimiento = usuario.FechaNacimiento;
            perfil.RutaFoto = usuario.Foto != null ? usuario.Foto : "";

            return perfil;
        }

        public void Guardar(PerfilMetaData perfil)
        {
            ArchivoService archivoSrv = new ArchivoService();

            string rutaAux = archivoSrv.Guardar(perfil.Archivo, perfil.NombreUsuario, "perfil"); ;

            if (rutaAux != "")
            {
                perfil.RutaFoto = rutaAux;
            }            
 
            usuarioRepo.GuardarModificacion(perfil);
        }

        public void Modificar(PerfilMetaData usuarioAux)
        {
            usuarioRepo.GuardarModificacion(usuarioAux);
        }

        
    }
}
