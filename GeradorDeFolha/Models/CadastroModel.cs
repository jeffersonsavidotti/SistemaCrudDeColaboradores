using GeradorDeFolha.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeradorDeFolha.Models;

public class CadastroModel
{
    // Informações de Cadastro

    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "O nome é obrigatório")]
#pragma warning disable CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
    public string nome { get; set; }
#pragma warning restore CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.

    [Required(ErrorMessage = "O CPF é obrigatório")]
#pragma warning disable CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
    public string cpf { get; set; }
#pragma warning restore CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.

    [Required(ErrorMessage = "O setor é obrigatório ")]
#pragma warning disable CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
    public string cargo { get; set; }
#pragma warning restore CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.

    [Required(ErrorMessage = "A data é obrigatória")]
#pragma warning disable CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
    public string AdmissaoData { get; set; }
#pragma warning restore CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.

    [Required(ErrorMessage = "O email é obrigatorio")]
    [EmailAddress(ErrorMessage = "Por favor, insira um endereço de e-mail válido.")]
#pragma warning disable CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
    public string email { get; set; }
#pragma warning restore CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.

    [Required(ErrorMessage = "A senha é obrigatoria")]
#pragma warning disable CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
    public string senha { get; set; }
#pragma warning restore CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.

    [Required(ErrorMessage = "A confirmação de senha é obrigatoria")]
    [NotMapped]
#pragma warning disable CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
    public string ConfirmarSenha { get; set; }
#pragma warning restore CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.

#pragma warning disable CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
    public string Sexo { get; set; }
#pragma warning restore CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.

    [Required(ErrorMessage = "O salario bruto é obrigatorio")]
    public double SalarioB { get; set; }

    public bool ValidarSenha(string Senha)
    {
        return senha == Senha;
    }

    public DateTime CadastroData { get; set; }

    public DateTime? AtualizacaoData { get; set; }

    [Required(ErrorMessage = "O tipo de perfil é obrigatorio")]
    public PerfilEnum Perfil { get; set; }
}
