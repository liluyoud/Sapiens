using Sapiens.Shared.Enums;

namespace Sapiens.Shared.Entities;

public class Funcionario : Pessoa
{
    public decimal Salario { get; set; }
    public SituacaoFuncionario? Situacao { get; set; }
}
