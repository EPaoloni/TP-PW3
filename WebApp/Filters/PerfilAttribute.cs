using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Mvc;
using System.Web.Routing;
using WebApp.Helpers;



namespace WebApp.Filters
{
    public class PerfilAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {

            var ruta = filterContext;

            if(SesionHelper.UserName == null)
            {
                filterContext.Result = new RedirectResult("/Perfil/Inicio");
            }
        }
    }
}