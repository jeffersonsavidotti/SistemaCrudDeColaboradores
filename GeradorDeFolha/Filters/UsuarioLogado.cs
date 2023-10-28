using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using GeradorDeFolha.Models;

namespace GeradorDeFolha.Filters
{
    public class UsuarioLogado : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
#pragma warning disable CS8600 // Conversão de literal nula ou possível valor nulo em tipo não anulável.
            string sessaoUsuario = context.HttpContext.Session.GetString("sessaoUsuarioLogado");
#pragma warning restore CS8600 // Conversão de literal nula ou possível valor nulo em tipo não anulável.

            if (string.IsNullOrEmpty(sessaoUsuario))
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary { { "controller", "Login" }, { "action", "Index" } });
            }
            else
            {
#pragma warning disable CS8600 // Conversão de literal nula ou possível valor nulo em tipo não anulável.
                CadastroModel usuario = JsonConvert.DeserializeObject<CadastroModel>(sessaoUsuario);
#pragma warning restore CS8600 // Conversão de literal nula ou possível valor nulo em tipo não anulável.

                if (usuario == null)
                {
                    context.Result = new RedirectToRouteResult(new RouteValueDictionary { { "controller", "Login" }, { "action", "Index" } });
                }
            }

            base.OnActionExecuting(context);
        }
    }
}