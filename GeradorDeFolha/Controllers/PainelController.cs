using Microsoft.AspNetCore.Mvc;
using GeradorDeFolha.Filters;
using GeradorDeFolha.Models;
using GeradorDeFolha.Repositorio;
using System.Text;

namespace GeradorDeFolha.Controllers
{
    [UsuarioVerificacaoPerfil]
    public class PainelController : Controller
    {
        private readonly ICadastroRepositorio _cadastroFuncionarioRepositorio;

        public PainelController(
            ICadastroRepositorio cadastroRepositorio
        )
        {
            _cadastroFuncionarioRepositorio = cadastroRepositorio;
        }

        //CadastroModel teste = new CadastroModel();
        public IActionResult Index()
        {
            List<CadastroModel> Funcionarios =
                _cadastroFuncionarioRepositorio.BuscarTodos();
            return View(Funcionarios);
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {
            CadastroModel funcionario = _cadastroFuncionarioRepositorio.ListarPorId(id);
            return View(funcionario);
        }

        public IActionResult GerarHolerite(int id)
        {
            CadastroModel funcionario = _cadastroFuncionarioRepositorio.ListarPorId(id);
            return View(funcionario);
        }

        public IActionResult Excluir(int id)
        {
            CadastroModel colaborador = _cadastroFuncionarioRepositorio.ListarPorId(id);
            return View(colaborador);
        }

        public IActionResult Apagar(int id)
        {
            try
            {
                bool apagado = _cadastroFuncionarioRepositorio.Apagar(id);

                if (apagado) TempData["MensagemSucesso"] = "Usuário apagado com sucesso!"; else TempData["MensagemErro"] = "Ops, não conseguimos apagar seu usuário, tente novamante!";
                return RedirectToAction("Index");
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos apagar seu usuário, tente novamante, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Cadastro(CadastroModel cadastro)
        {
            //------------------------------//
            try
            {
                if (ModelState.IsValid)
                {
                    Console.WriteLine("Cadastro" + cadastro);
                    string senha = cadastro.senha;
                    string encodedStr = Convert.ToBase64String(Encoding.UTF8.GetBytes(senha));
                    cadastro.senha = encodedStr;
                    string sexo = cadastro.Sexo;
                    _cadastroFuncionarioRepositorio.Adicionar(cadastro);
                    cadastro = _cadastroFuncionarioRepositorio.Adicionar(cadastro);
                    TempData["MensagemSucesso"] = "Colaborador cadastrado com sucesso!";
                    return RedirectToAction("Index");
                }

                return View(cadastro);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos cadastrar seu colaborador, tente novamante, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Editar(CadastroModel cadastro)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Console.WriteLine("Cadastro" + cadastro);
                    string senha = cadastro.senha;
                    string encodedStr = Convert.ToBase64String(Encoding.UTF8.GetBytes(senha));
                    cadastro.senha = encodedStr;
                    _cadastroFuncionarioRepositorio.Atualizar(cadastro);
                    cadastro = _cadastroFuncionarioRepositorio.Atualizar(cadastro);
                    TempData["MensagemSucesso"] = "Colaborador alterado com sucesso!";
                    return RedirectToAction("Index");
                }

                return View(cadastro);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos atualizar seu colaborador, tente novamante, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult GerarHolerite(CadastroModel cadastro)
        {
            if (
                string.IsNullOrEmpty(cadastro.nome)
                || string.IsNullOrEmpty(cadastro.senha)
                || string.IsNullOrEmpty(cadastro.email)
            )
            {
                ModelState.AddModelError(
                    "",
                    "Por favor, preencha todos os campos antes de cadastrar."
                );
                return View(cadastro);
            }
            Console.WriteLine("Cadastro" + cadastro);
            _cadastroFuncionarioRepositorio.Atualizar(cadastro);
            return RedirectToAction("Index");
        }
    }
}
