using GeradorDeFolha.Models;

namespace GeradorDeFolha.Repositorio
{
    public interface ILoginViewRepositorio
    {
        CadastroModel BuscarPorLogin(string login);
    }
}
