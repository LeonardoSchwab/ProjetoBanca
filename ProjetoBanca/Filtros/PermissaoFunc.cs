using ProjetoBanca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ProjetoBanca.Filtros
{
    public class PermissaoFunc : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            PessoaFisica usuario = SessaoUsuario.UsuarioLogado();
            usuario.GetTipo();
            if (usuario.TipoID == 1)
            {
                filterContext.Result = new RedirectToRouteResult(
                    new RouteValueDictionary(
                        new { action = "Index", controller = "Venda" }));
            }
        }
    }
}