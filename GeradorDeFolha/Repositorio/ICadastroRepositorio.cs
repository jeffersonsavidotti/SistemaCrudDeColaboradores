using GeradorDeFolha.Models;

namespace GeradorDeFolha.Repositorio
{
    public interface ICadastroRepositorio
    {
        CadastroModel ListarPorId(int id);
        List<CadastroModel> BuscarTodos();
        CadastroModel Adicionar(CadastroModel cadastro);
        CadastroModel Atualizar(CadastroModel cadastro);
        bool Apagar(int id);
    }
}
