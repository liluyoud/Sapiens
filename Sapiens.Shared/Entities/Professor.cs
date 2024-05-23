using Sapiens.Shared.Enums;

namespace Sapiens.Shared.Entities;

public class Professor : Funcionario
{
    public Titulacao? Titulacao { get; set; }
    public string? Formacao { get; set; }
}
