using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using GeradorDeFolha.Models;

namespace GeradorDeFolha.ViewComponents
{
    public class Menu : ViewComponent
    {
#pragma warning disable CS1998 // O método assíncrono não possui operadores 'await' e será executado de forma síncrona
        public async Task<IViewComponentResult> InvokeAsync()
#pragma warning restore CS1998 // O método assíncrono não possui operadores 'await' e será executado de forma síncrona
        {
#pragma warning disable CS8600 // Conversão de literal nula ou possível valor nulo em tipo não anulável.
            string sessionUsuario = HttpContext.Session.GetString("sessaoUsuarioLogado");
#pragma warning restore CS8600 // Conversão de literal nula ou possível valor nulo em tipo não anulável.

#pragma warning disable CS8603 // Possível retorno de referência nula.
            if (string.IsNullOrEmpty(sessionUsuario)) return null;
#pragma warning restore CS8603 // Possível retorno de referência nula.

#pragma warning disable CS8600 // Conversão de literal nula ou possível valor nulo em tipo não anulável.
            CadastroModel usuario = JsonConvert.DeserializeObject<CadastroModel>(sessionUsuario);
#pragma warning restore CS8600 // Conversão de literal nula ou possível valor nulo em tipo não anulável.
            return View(usuario);
        }
    }
}
