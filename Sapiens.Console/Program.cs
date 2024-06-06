using Microsoft.EntityFrameworkCore;
using Sapiens.Shared.Contexts;

var context = new SapiensContext();

FazerMigracao();
Menu();


void FazerMigracao()
{
    Console.WriteLine("Iniciando migração");
    context.Database.Migrate();
    Console.WriteLine("Migração Finalizada");
    Console.WriteLine("[Enter] para continuar");
    Console.ReadLine();
}

void Menu()
{
    CriarTitulo("Sapiens - Sistema Acadêmico");
    var opcao = "";
    Console.WriteLine(" [1] Cursos");
    Console.WriteLine(" [2] Disciplinas");
    Console.WriteLine(" [3] Professores");
    Console.WriteLine(" [4] Alunos");
    Console.WriteLine(" [5] Matricula");
    Console.WriteLine("\n [9] Sair");
    Console.WriteLine("-----------------------------------");
    Console.Write(" \nOpção:");
    opcao = Console.ReadLine();
    switch (opcao)
    {
        case "1": MenuAluno(); break;
        case "2": MenuAluno(); break;
        case "3": MenuAluno(); break;
        case "4": MenuAluno(); break;
        case "5": MenuAluno(); break;
    }
}

void MenuAluno()
{
    CriarTitulo("Sapiens - Cadastro de Alunos");
    var opcao = "";
    Console.WriteLine(" [1] Consultar");
    Console.WriteLine(" [2] Adicionar");
    Console.WriteLine(" [3] Remover");
    Console.WriteLine("\n [9] Voltar");
    Console.WriteLine("-----------------------------------");
    Console.Write(" \nOpção:");
    opcao = Console.ReadLine();
    switch (opcao)
    {
        case "1": ConsularAluno(); break;
        case "2": AdicionarAluno(); break;
        case "3": RemoverAluno(); break;
        case "9": Menu(); break;
    }
    MenuAluno();
}

void ConsularAluno()
{
    CriarTitulo("Sapiens - Consultar Aluno");
    Console.WriteLine("-----------------------------------");
    Console.WriteLine("[Enter] para continuar");
    Console.ReadLine();
}

void AdicionarAluno()
{
    CriarTitulo("Sapiens - Adicionar Aluno");
    Console.WriteLine("-----------------------------------");
    Console.WriteLine("[Enter] para continuar");
    Console.ReadLine();
}

void RemoverAluno()
{
    CriarTitulo("Sapiens - Remover Aluno");
    Console.WriteLine("-----------------------------------");
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
