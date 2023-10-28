using Microsoft.AspNetCore.Mvc;
using GeradorDeFolha.Filters;

namespace GeradorDeFolha.Controllers
{
    [UsuarioLogado]
    public class RecibosDePagController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
