using Microsoft.EntityFrameworkCore;
using Sapiens.Shared.Contexts;
using Sapiens.Shared.Entities;

var context = new SapiensContext();
context.Database.Migrate();

var lilo = new Professor();
lilo.Nome = "Liluyoud Cury de Lacerda";
lilo.Cpf = "111.111.111-11";

var alan = new Professor();
alan.Nome = "Allan Gurgel";
alan.Cpf = "222.222.222-22";

var curso = new Curso();
curso.Nome = "Sistemas de Informação";
curso.CargaHoraria = 3200;
curso.Coordenador = alan;

context.Add(lilo);
context.Add(alan);
context.Add(curso);

context.SaveChanges();

Console.ReadLine();