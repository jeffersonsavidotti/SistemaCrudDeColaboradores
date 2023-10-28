using GeradorDeFolha.Data;
using GeradorDeFolha.Models;

namespace GeradorDeFolha.Repositorio
{
    public class LoginViewRepositorio : ILoginViewRepositorio
    {
        private readonly DataContext _context;

        public LoginViewRepositorio(DataContext context)
        {
            _context = context;
        }

        public CadastroModel BuscarPorLogin(string login)
        {
#pragma warning disable CS8603 // Possível retorno de referência nula.
            return _context.CadastroModel.FirstOrDefault(
                x => x.email.ToUpper() == login.ToUpper()
            );
        }
#pragma warning restore CS8603 // Possível retorno de referência nula.
    }
}
