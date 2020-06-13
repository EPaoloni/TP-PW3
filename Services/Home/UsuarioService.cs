using Models.ORM;
using Models.Partial;
using Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Home
{
    public class UsuarioService
    {
        UsuarioRepository usuarioRepo;
        
        EmailService emailServ = new EmailService();
        //RegistrarseRepository regRepo = new RegistrarseRepository();

        public UsuarioService()
        {
            PandemiaEntities context = new PandemiaEntities();
            UsuarioRepository usuarioRepo = new UsuarioRepository(context);
            usuarioRepo = new UsuarioRepository(context);
        }
 
        public void Activar(string token)
        {
            usuarioRepo.Activar(token);
        }

        public void Agregar(RegistrarseMetaData usuarioMetaData)
        {
            // Creacion de token
            usuarioMetaData.Token = Guid.NewGuid().ToString("N").Substring(0, 16);

            // Se agrega el usuario en base de datos
            Usuarios usuario = new Usuarios();
            usuario.Email = usuarioMetaData.Email;
            usuario.Password = usuarioMetaData.Password;
            usuario.FechaNacimiento = usuarioMetaData.FechaNacimiento;
            usuario.FechaCreacion = DateTime.Today;
            usuario.TipoUsuario = usuarioRepo.BuscarTipoUsuario("Normal");
            usuario.Token = usuarioMetaData.Token;
            usuario.Activo = false;

            usuarioRepo.Crear(usuario);

            // Se envia el email de activacion
            emailServ.Enviar(usuario.Email, usuario.Token);
        }

        public bool BuscarUsuarioLogin(string email, string password)
        {
            Usuarios consulta = usuarioRepo.BuscarUsuario(email, password);

            if (consulta != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void Modificar(Usuarios usuarioAux)
        {
            usuarioRepo.GuardarModificacion(usuarioAux);
        }


    }
}
