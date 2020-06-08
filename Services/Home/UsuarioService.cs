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
        UsuarioRepository usuarioRepo = new UsuarioRepository();
        
        public void Activar(string token)
        {
            usuarioRepo.Activar(token);
        }

        public void Agregar(UsuariosMetaData usuarioMetaData)
        {
            // Creacion de token
            usuarioMetaData.Token = Guid.NewGuid().ToString("N").Substring(0, 16);

            // Se agrega el usuario en base de datos
            usuarioRepo.Agregar(usuarioMetaData);

            // Se envia el email de activacion
            emailServ.Enviar(usuarioMetaData.Email, usuarioMetaData.Token);
        }
    }
}
