using Sapiens.Shared.Enums;
using System.ComponentModel.DataAnnotations;

namespace Sapiens.Shared.Entities;

public class Disciplina : Entidade
{
    [StringLength(100)]
    public string? Nome { get; set; }

    public TipoDisciplina Tipo { get; set; }

    public  int? CursoId { get; set; }
    public Curso? Curso { get; set; }

    public int? ProfessorId { get; set; }
    public Professor? Professor { get; set; }

    public List<Matricula> Matriculas { get; } = new();
}
