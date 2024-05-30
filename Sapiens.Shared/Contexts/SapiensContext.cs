using Sapiens.Shared.Entities;

namespace Sapiens.Shared.Contexts;

public class SapiensContext
{
    public List<Curso> Cursos { get; set; }
    public List<Professor> Professores { get; set; }
    public List<Disciplina> Disciplinas { get; set; }
    public List<Aluno> Alunos { get; set; }

    public SapiensContext()
    {
        Cursos = new();
        Professores = new();
        Disciplinas = new();
        Alunos = new();
    }

    public void AdicionaCurso(Curso curso)
    {
        curso.Context = this;
        Cursos.Add(curso);
    }

    public void AdicionaProfessor(Professor professor)
    {
        professor.Context = this;
        Professores.Add(professor);
    }

    public void AdicionaDisciplina(Disciplina disciplina)
    {
        disciplina.Context = this;
        Disciplinas.Add(disciplina);
    }

    public void AdicionaAluno(Aluno aluno)
    {
        aluno.Context = this;
        Alunos.Add(aluno);
    }
}
