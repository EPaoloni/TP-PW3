using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.ORM;
using Models.Partial;
using Models.Repository;

namespace Services.Home
{
    public class IngresarService
    {
        UsuarioRepository usuarioRepo;

        public IngresarService()
        {
            PandemiaEntities context = new PandemiaEntities();
            usuarioRepo = new UsuarioRepository(context);
        }

        public void ValidarLogin(IngresarMetaData usuarioMetaData)
        {
            Usuarios usuario = usuarioRepo.BuscarUsuario(usuarioMetaData.Email, usuarioMetaData.Password);

            if (usuario != null)
            {
                usuarioMetaData.RespuestaLogin = true;
                usuarioMetaData.IdUsuario = usuario.IdUsuario;
                usuarioMetaData.UserName = usuario.UserName;
            }
        }

    }
}
