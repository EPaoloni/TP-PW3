using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels
{
    class Registrar
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string RePassword { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
