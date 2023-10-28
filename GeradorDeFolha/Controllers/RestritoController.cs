using Microsoft.AspNetCore.Mvc;
using GeradorDeFolha.Filters;

namespace GeradorDeFolha.Controllers
{
    [UsuarioLogado]
    public class RestritoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
