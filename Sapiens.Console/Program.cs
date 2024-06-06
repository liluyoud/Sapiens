using Microsoft.EntityFrameworkCore;
using Sapiens.Shared.Contexts;
using Sapiens.Shared.Entities;

var context = new SapiensContext();

FazerMigracao();

CriarTitulo("Sapiens - Sistema Acadêmico");

void FazerMigracao()
{
    Console.WriteLine("Iniciando migração");
    context.Database.Migrate();
    Console.WriteLine("Migração Finalizada");
    Console.WriteLine("[Enter] para continuar");
    Console.ReadLine();
}

void CriarTitulo(string titulo)
{
    Console.Clear();
    Console.WriteLine("-----------------------------------");
    Console.WriteLine($" {titulo}");
    Console.WriteLine("-----------------------------------");
}

void AdicionaAluno()
{
    CriarTitulo("Sapiens - Adicionar Aluno");
    Console.WriteLine("[Enter] para continuar");
    Console.ReadLine();

}
