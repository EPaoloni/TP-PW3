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
        EmailService emailServ = new EmailService();
        RegistrarseRepository regRepo = new RegistrarseRepository();
        PerfilRepository perfilRepo = new PerfilRepository();


        public void Activar(string token)
        {
            regRepo.Activar(token);
        }

        public void Agregar(RegistrarseMetaData usuario)
        {
            // Creacion de token
            usuario.Token = Guid.NewGuid().ToString("N").Substring(0, 16);

            // Se agrega el usuario en base de datos
            regRepo.Agregar(usuario);

            // Se envia el email de activacion
            emailServ.Enviar(usuario.Email, usuario.Token);
        }

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

    }
}
