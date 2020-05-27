using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels
{
    public class UsuarioIngresar
    {
        public string  Email { get; set; }
        public string  Password { get; set; }
        public bool RespuestaLogin { get; set; } = false;

    }
}
