using GeradorDeFolha.Data;
using GeradorDeFolha.Models;

namespace GeradorDeFolha.Repositorio
{
    public class CadastroRepositorio : ICadastroRepositorio
    {
        private readonly DataContext _context;

        public CadastroRepositorio(DataContext context)
        {
            _context = context;
        }

        public CadastroModel ListarPorId(int id)
        {
#pragma warning disable CS8603 // Possível retorno de referência nula.
            return _context.CadastroModel.FirstOrDefault(x => x.Id == id);
#pragma warning restore CS8603 // Possível retorno de referência nula.
        }

        public List<CadastroModel> BuscarTodos()
        {
            return _context.CadastroModel.ToList();
        }

        public CadastroModel Adicionar(CadastroModel cadastro)
        {
            cadastro.CadastroData = DateTime.Now;
            Console.WriteLine("Cadastro: " + cadastro.ToString());
            _context.CadastroModel.Add(cadastro);
            _context.SaveChanges();
            return cadastro;
        }

        public CadastroModel Atualizar(CadastroModel cadastro)
        {
            CadastroModel cadastroDB = ListarPorId(cadastro.Id);
            if (cadastroDB == null)
                throw new System.Exception("Houve um erro na atualização do funcionario!");

            cadastroDB.nome = cadastro.nome;
            cadastroDB.email = cadastro.email;
            cadastroDB.cpf = cadastro.cpf;
            cadastroDB.AdmissaoData = cadastro.AdmissaoData;
            cadastroDB.AtualizacaoData = DateTime.Now;
            cadastroDB.senha = cadastro.senha;
            cadastroDB.ConfirmarSenha = cadastro.ConfirmarSenha;
            cadastroDB.cargo = cadastro.cargo;
            cadastroDB.SalarioB = cadastro.SalarioB;
            ;
            cadastroDB.Sexo = cadastro.Sexo;
            cadastroDB.Perfil = cadastro.Perfil;

            Console.WriteLine("Cadastro: " + cadastroDB.ToString());
            _context.CadastroModel.Update(cadastroDB);
            _context.SaveChanges();
            return cadastroDB;
        }
        public bool Apagar(int id)
        {
            CadastroModel usuarioDB = ListarPorId(id);

            if (usuarioDB == null) throw new Exception("Houve um erro na deleção do usuário!");

            _context.CadastroModel.Remove(usuarioDB);
            _context.SaveChanges();

            return true;
        }
    }
}
