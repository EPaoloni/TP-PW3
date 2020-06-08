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
        EmailService emailServ = new EmailService();
        RegistrarseRepository usuarioRepo = new RegistrarseRepository();
        
        public void Activar(string token)
        {
            usuarioRepo.Activar(token);
        }

        public void Agregar(RegistrarseMetaData usuario)
        {
            // Creacion de token
            usuario.Token = Guid.NewGuid().ToString("N").Substring(0, 16);

            // Se agrega el usuario en base de datos
            usuarioRepo.Agregar(usuario);

            // Se envia el email de activacion
            emailServ.Enviar(usuario.Email, usuario.Token);
        }
    }
}
