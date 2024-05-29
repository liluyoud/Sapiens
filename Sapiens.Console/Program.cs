using Sapiens.Shared.Entities;
using Sapiens.Shared.Enums;

var coordenador = new Coordenador();
coordenador.Nome = "Allan";
coordenador.Cpf = "123";
coordenador.Titulacao = Titulacao.Mestrado;
coordenador.Endereco = new() {
    Uf = "RO",
    Municipio = "Porto Velho"
};

var curso = new Curso();
curso.Nome = "Sistemas de Informação";
curso.CargaHoraria = 3200;
curso.Tipo = TipoCurso.Bacharelado;
curso.Coordenador = coordenador;

Console.WriteLine($"Curso:       {curso.Nome}");
Console.WriteLine($"Coordenador: {curso.Coordenador.Nome}");
Console.WriteLine($"Cidade:      {curso.Coordenador.Endereco.Municipio}");

Console.ReadLine();
