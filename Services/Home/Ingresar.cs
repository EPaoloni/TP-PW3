using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Metadata;
using Models.Repository;

namespace Services.Home
{
    public class IngresarService
    {
        public bool ValidarLogin(UsuariosMetadata usuario)
        {
            UsuarioRepository usuarioRepo = new UsuarioRepository();

            bool respuesta = usuarioRepo.BuscarUsuarioLogin(usuario.Email, usuario.Password);
            
            return respuesta;
        }
    }
}
