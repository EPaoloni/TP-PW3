using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if(SesionHelper.UserName == null && SesionHelper.IdUsuario != null)
            {
                string controllerName = (string)filterContext.RouteData.Values["controller"];

                if (controllerName != "Perfil")
                {
                    filterContext.Result = new RedirectToRouteResult(
                        new RouteValueDictionary {
                            {"Controller", "Perfil" },
                            {"Action", "Inicio" }
                        });
                }
            }
        }
    }
}