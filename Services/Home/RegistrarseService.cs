using Models.ORM;
using Models.Partial;
using Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Services.Home
{
    public class RegistrarseService
    {
        UsuarioRepository usuarioRepo;
        
        EmailService emailServ = new EmailService();

        public RegistrarseService()
        {
            PandemiaEntities context = new PandemiaEntities();
            usuarioRepo = new UsuarioRepository(context);
        }
 
        public void Activar(string token)
        {
            usuarioRepo.Activar(token);
        }

        public void Agregar(RegistrarseMetaData usuarioMetaData)
        {
            // Creacion de token
            Guid g = Guid.NewGuid();
            string GuidString = Convert.ToBase64String(g.ToByteArray()).Substring(0, 16);
            usuarioMetaData.Token = GuidString;

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

    }
}
