using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Partial;
using Models.Repository;
using Models.Data;

namespace Services.Home
{
    public class IngresarService
    {
        public void ValidarLogin(UsuariosPartial usuario)
        {
            //UsuarioRepository usuarioRepo = new UsuarioRepository();


            //bool respuesta = usuarioRepo.BuscarUsuarioLogin(usuario.Email, usuario.Password);
            //usuario.RespuestaLogin = respuesta;

            UsuariosPartial usuarioConsulta = BaseDatos.usuarioStatic.Find(u => u.Email == usuario.Email && u.Password == usuario.Password);

            if (usuarioConsulta != null)
            {
                usuario.RespuestaLogin = true;
            }
            else
            {
                usuario.RespuestaLogin = false;
            }
        }
    }
}
