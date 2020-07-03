using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace WebApp.Helpers
{
    public class SesionHelper
    {

        public static int IdUsuario { get; set; }

        public static string  email { get; set; }

        static SesionHelper()
        {
            IdUsuario = 12;
            email = "Javier.Garcia@hotmail.com";
        }
    }
}