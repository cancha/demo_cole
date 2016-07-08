using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Colegio_Jean.filtros
{
    public class VerificarLogueo : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var controlador = (Controller)context.Controller;
            String usuario = (string)context.HttpContext.Session["usuario"];
            Boolean logueado = !string.IsNullOrEmpty(usuario);
            if(!logueado){
                Debug.WriteLine("No Logueado");
                context.Result = new RedirectToRouteResult(
                    new RouteValueDictionary(
                        new { controller = "Home" , action  = "Login"}
                    )
                );
            }
            base.OnActionExecuting(context);
        }
    }
}