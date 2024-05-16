using Sapiens.Shared.Entities;
using Sapiens.Shared.Enums;

var curso = new Curso("Sistemas de Informação");
curso.CargaHoraria = 3200;
curso.Tipo = TipoCurso.Bacharelado;

Console.WriteLine(curso);
Console.ReadLine();
