﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Home
{
    class RegistrarseService
    {
        //UsuarioRepository usuarioRepo = new UsuarioRepository();

        public void Activar(string pToken)
        {
            var usuario = (from us in ctx.Usuarios
                           where us.Token == pToken
                           select us).FirstOrDefault();

            if (usuario != null)
            {
                usuario.Activo = true;

                ctx.SaveChanges();
            }

        }
    }
}
