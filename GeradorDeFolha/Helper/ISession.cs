using GeradorDeFolha.Models;

namespace GeradorDeFolha.Helper
{
    public interface ISession
    {
        void CriarSessaoDoUsuario(CadastroModel usuario);
        void RemoverSessaoUsuario();
        CadastroModel BuscarSessaoDoUsuario();
    }
}
