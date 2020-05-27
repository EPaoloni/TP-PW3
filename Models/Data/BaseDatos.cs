using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Partial;

namespace Models.Data
{
    public class BaseDatos
    {
        public static List<UsuariosPartial> usuarioStatic = new List<UsuariosPartial>
        {
            new UsuariosPartial {
                IdUsuario = 1,
                Email = "jpabmai@gmail.com",
                Password = "Pablo2020",
                TipoUsuario = 1,
                Token = "0A0WhCnC7YKkb9r3qeX6"
            }
        };
    }

}
