using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ProjetoBanca.Filtros
{
    public class AutorizacaoFilterColab : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            object colabLogado = filterContext.HttpContext.Session["colabLogado"];

            if (colabLogado == null)
            {
                filterContext.Result = new RedirectToRouteResult(
                    new RouteValueDictionary(
                        new { action = "LoginColaborador", controller = "Login" }));
            }
        }
    }
}