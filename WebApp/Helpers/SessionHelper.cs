using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Helpers
{
    public class SesionHelper
    {
        public static string IdUsuario
        {
            get
            {
                return HttpContext.Current.Session["IdUsuario"] as string;
            }
            set
            {
                HttpContext.Current.Session["IdUsuario"] = value;
            }
        }

        public static string UserName
        {
            get
            {
                return HttpContext.Current.Session["UserName"] as string;
            }
            set
            {
                HttpContext.Current.Session["UserName"] = value;
            }
        }

        public static string Email
        {
            get
            {
                return HttpContext.Current.Session["Email"] as string;
            }
            set
            {
                HttpContext.Current.Session["Email"] = value;
            }
        }

        public static void EliminarSesion()
        {           
            HttpContext.Current.Session.Contents.Abandon();
        }
    }
}