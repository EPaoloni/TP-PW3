using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace WebApp.Helpers
{
    public class SesionHelper
    {
        public static string UsuarioId
        {
            get
            {
                return (string) HttpContext.Current.Session["UsuarioId"];
            }
            set
            {
                HttpContext.Current.Session["UsuarioId"] = value;
            }
        }

        public string GenerarID()
        {
            SessionIDManager manager = new SessionIDManager();
            string newSessionId = manager.CreateSessionID(HttpContext.Current);

            return newSessionId;
        }
    }
}