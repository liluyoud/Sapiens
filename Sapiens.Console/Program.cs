using Sapiens.Shared.Contexts;
using Sapiens.Shared.Entities;
using Sapiens.Shared.Enums;

var context = new SapiensContext();

// curso
var curso = new Curso();
curso.Nome = "Sistemas de Informação";
curso.CargaHoraria = 3200;
curso.Tipo = TipoCurso.Bacharelado;
context.AdicionaCurso(curso);

// professor
var professor = new Professor();
professor.Nome = "Liluyoud Cury de Lacerda";
professor.Cpf = "123";
professor.Titulacao = Titulacao.Mestrado;
professor.Endereco = new() {
    Uf = "RO",
    Municipio = "Porto Velho"
};
curso.Coordenador = professor;
context.AdicionaProfessor(professor);

// disciplina
var poo = new Disciplina();
poo.Nome = "Programação Orientada a Objetos";
poo.Curso = curso;
poo.Professor = professor;
context.AdicionaDisciplina(poo);

// disciplina
var alg = new Disciplina();
alg.Nome = "Algoritmos";
alg.Curso = curso;
alg.Professor = professor;
context.AdicionaDisciplina(alg);


Console.WriteLine($"Disciplinas do Curso {curso.Nome}:");
foreach (var item in curso.Disciplinas)
{
    Console.WriteLine($" . {item.Nome} - Prof. {item.Professor?.Nome}");
}

Console.ReadLine();
