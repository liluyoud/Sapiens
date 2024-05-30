using Sapiens.Shared.Enums;

namespace Sapiens.Shared.Entities;

public class Professor : Funcionario
{
    public Titulacao? Titulacao { get; set; }
    public string? Formacao { get; set; }
    public bool ECoordenador { get; set; }

    public List<Disciplina>? Disciplinas => 
        Context?.Disciplinas.Where(d => d.Professor == this).ToList();
}
