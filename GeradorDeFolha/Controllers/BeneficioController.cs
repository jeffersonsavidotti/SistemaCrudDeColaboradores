using Microsoft.AspNetCore.Mvc;
using GeradorDeFolha.Filters;
using GeradorDeFolha.Repositorio;

namespace GeradorDeFolha.Controllers
{
    [UsuarioLogado]
    public class BeneficioController : Controller
    {
        private readonly Helper.ISession _session;

        public BeneficioController(
            ILoginViewRepositorio loginviewrepositorio,
            Helper.ISession session
        )
        {
            _session = session;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
