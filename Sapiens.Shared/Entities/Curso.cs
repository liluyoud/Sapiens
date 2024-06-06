using Sapiens.Shared.Enums;
using System.ComponentModel.DataAnnotations;

namespace Sapiens.Shared.Entities;

public class Curso : Entidade
{
    [StringLength(100)]
    public required string Nome { get; set; }

    public int? CargaHoraria { get; set; }

    public TipoCurso Tipo { get; set; }

    public Professor? Coordenador { get; set; }

    public override string ToString()
    {
        var curso = Nome;
        if (Coordenador != null)
            curso += $" - {Coordenador.Nome}";
        if (CargaHoraria != null && CargaHoraria > 0)
            curso += $" - {CargaHoraria}h";
        return curso;
    }

    public List<Disciplina> Disciplinas { get; } = new();
        
}
