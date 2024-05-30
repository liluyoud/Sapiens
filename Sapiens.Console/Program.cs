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
var lilo = new Professor();
lilo.Nome = "Liluyoud Cury de Lacerda";
lilo.Cpf = "111";
lilo.Titulacao = Titulacao.Mestrado;
lilo.Endereco = new() {
    Uf = "RO",
    Municipio = "Porto Velho"
};
context.AdicionaProfessor(lilo);

var alan = new Professor();
alan.Nome = "Allan Gurgel";
alan.Cpf = "222";
alan.Titulacao = Titulacao.Mestrado;
alan.ECoordenador = true;
alan.Endereco = new()
{
    Uf = "RO",
    Municipio = "Porto Velho"
};
curso.Coordenador = alan;
context.AdicionaProfessor(alan);

// disciplina
var poo = new Disciplina();
poo.Nome = "Programação Orientada a Objetos";
poo.Curso = curso;
poo.Professor = lilo;
context.AdicionaDisciplina(poo);

// disciplina
var alg = new Disciplina();
alg.Nome = "Algoritmos";
alg.Curso = curso;
alg.Professor = lilo;
context.AdicionaDisciplina(alg);

// disciplina
var bd = new Disciplina();
bd.Nome = "Banco de Dados";
bd.Curso = curso;
bd.Professor = alan;
context.AdicionaDisciplina(bd);


// consulta por curso
Console.WriteLine($"Disciplinas do Curso {curso.Nome}:");
foreach (var disciplina in curso.Disciplinas)
{
    Console.WriteLine($" . {disciplina.Nome} - Prof. {disciplina.Professor?.Nome}");
}

// consulta por professor
Console.WriteLine($"Disciplinas do Professor {lilo.Nome}:");
foreach (var disciplina in lilo.Disciplinas!)
{
    Console.WriteLine($" . {disciplina.Nome} - {disciplina.Curso?.Nome}");
}

// consulta por professor
Console.WriteLine($"Disciplinas do Professor {alan.Nome}:");
foreach (var disciplina in alan.Disciplinas!)
{
    Console.WriteLine($" . {disciplina.Nome} - {disciplina.Curso?.Nome}");
}
Console.ReadLine();