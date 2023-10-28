using Newtonsoft.Json;
using GeradorDeFolha.Models;

namespace GeradorDeFolha.Helper
{
    public class Session : ISession
    {
        private readonly IHttpContextAccessor _httpContext;

        public Session(IHttpContextAccessor httpContext)
        {
            _httpContext = httpContext;
        }

        public CadastroModel BuscarSessaoDoUsuario()
        {
#pragma warning disable CS8602 // Desreferência de uma referência possivelmente nula.
#pragma warning disable CS8600 // Conversão de literal nula ou possível valor nulo em tipo não anulável.
            string sessaoUsuario = _httpContext.HttpContext.Session.GetString("sessaoUsuarioLogado");
#pragma warning restore CS8600 // Conversão de literal nula ou possível valor nulo em tipo não anulável.
#pragma warning restore CS8602 // Desreferência de uma referência possivelmente nula.

#pragma warning disable CS8603 // Possível retorno de referência nula.
            if (string.IsNullOrEmpty(sessaoUsuario)) return null;
#pragma warning restore CS8603 // Possível retorno de referência nula.

#pragma warning disable CS8603 // Possível retorno de referência nula.
            return JsonConvert.DeserializeObject<CadastroModel>(sessaoUsuario);// transormar ele em cadastro funcionario model usando o DeserializeObject
#pragma warning restore CS8603 // Possível retorno de referência nula.
        }

        public void CriarSessaoDoUsuario(CadastroModel usuario)
        {
            string valor = JsonConvert.SerializeObject(usuario);// Aqui ele está convertendo um objeto para um padrão Json para colocar em uma string 
#pragma warning disable CS8602 // Desreferência de uma referência possivelmente nula.
            _httpContext.HttpContext.Session.SetString("sessaoUsuarioLogado", valor); // Criando a Sessão e passando o valor 
#pragma warning restore CS8602 // Desreferência de uma referência possivelmente nula.
        }

        public void RemoverSessaoUsuario()
        {
#pragma warning disable CS8602 // Desreferência de uma referência possivelmente nula.
            _httpContext.HttpContext.Session.Remove("sessaoUsuarioLogado");// Para remover a sessão
#pragma warning restore CS8602 // Desreferência de uma referência possivelmente nula.
        }
    }
}


/*public class Session : ISession
    {   
        private readonly IHttpContextAccessor _httpContext;

        public Session(IHttpContextAccessor httpContext)
        {
            _httpContext = httpContext;
        }

        public CadastroModel BuscarSessaoDoUsuario()
        {
            byte[] valor;
            string valorDecodificado = "";
            if (_httpContext.HttpContext.Session.TryGetValue("sessaoUsuarioLogado", out valor))
            {
                valorDecodificado = Encoding.UTF8.GetString(valor);
                return JsonConvert.DeserializeObject<CadastroModel>(valorDecodificado);
            }

            return null;
        }

        public void CriarSessaoDoUsuario(CadastroModel usuario)
        {
            string valor = JsonConvert.SerializeObject(usuario);
            _httpContext.HttpContext.Session.Set("sessaoUsuarioLogado", Encoding.UTF8.GetBytes(valor));
        }

        public void RemoverSessaoUsuario()
        {
            _httpContext.HttpContext.Session.Remove("sessaoUsuarioLogado");
        }
    }*/