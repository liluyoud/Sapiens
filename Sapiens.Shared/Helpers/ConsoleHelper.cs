using Sapiens.Shared.Contexts;
using Microsoft.EntityFrameworkCore;
using Sapiens.Shared.Entities;

namespace Sapiens.Shared.Helpers;

public static class ConsoleHelper
{
    public static SapiensContext context = new();

    public static void Menu()
    {
        CriarTitulo("Sapiens - Sistema Acadêmico");
        Console.WriteLine(" [1] Cursos");
        Console.WriteLine(" [2] Disciplinas");
        Console.WriteLine(" [3] Professores");
        Console.WriteLine(" [4] Alunos");
        Console.WriteLine(" [5] Matricula");
        Console.WriteLine(" [8] Fazer Migração");
        Console.WriteLine("\n [9] Sair");
        Console.WriteLine("-----------------------------------");
        Console.Write(" \nOpção: ");
        var opcao = Console.ReadLine();
        switch (opcao)
        {
            case "1": MenuCurso(); break;
            case "2": MenuAluno(); break;
            case "3": MenuAluno(); break;
            case "4": MenuAluno(); break;
            case "5": MenuAluno(); break;
            case "8": FazerMigracao(); break;
        }
    }

    #region Curso

    public static void MenuCurso()
    {
        CriarTitulo("Sapiens - Cadastro de Cursos");
        var opcao = "";
        Console.WriteLine(" [1] Listar");
        Console.WriteLine(" [2] Consultar");
        Console.WriteLine(" [3] Adicionar");
        Console.WriteLine(" [4] Remover");
        Console.WriteLine("\n [9] Voltar");
        Console.WriteLine("-----------------------------------");
        Console.Write(" \nOpção: ");
        opcao = Console.ReadLine();
        switch (opcao)
        {
            case "1": ListarCursos(); break;
            case "2": ConsultarCurso(); break;
            case "3": AdicionarCurso(); break;
            case "4": RemoverCurso(); break;
            case "9": Menu(); break;
        }
    }

    public static void ListarCursos()
    {
        CriarTitulo("Sapiens - Lista de Cursos");
        var cursos = context.Cursos.Include(c => c.Coordenador).OrderBy(c => c.Nome).ToList();
        foreach (var curso in cursos)
        {
            Console.WriteLine($"{curso.Id} - {curso.Nome} ({curso.Coordenador?.Nome})");
        }
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("[Enter] para continuar");
        Console.ReadLine();
        MenuCurso();
    }

    public static void ConsultarCurso()
    {
        CriarTitulo("Sapiens - Consultar Curso");
        Console.Write("Termo de pesquisa: ");
        var termo = Console.ReadLine();
        if (termo != null)
        {
            termo = termo.ToLower();
            var cursos = context.Cursos.Where(c => c.Nome != null && c.Nome.ToLower().Contains(termo)).ToList();
            foreach (var curso in cursos)
            {
                Console.WriteLine($"{curso.Nome} ({curso.CargaHoraria}h)");
            }
        }

        Console.WriteLine("-----------------------------------");
        Console.WriteLine("[Enter] para continuar");
        Console.ReadLine();
        MenuCurso();
    }

    public static void AdicionarCurso()
    {
        CriarTitulo("Sapiens - Adicionar Curso");

        Console.Write("Nome do Curso: ");
        var nome = Console.ReadLine();
        Console.Write("Carga Horária: ");
        var ch = Convert.ToInt32(Console.ReadLine());

        var curso = new Curso();
        curso.Nome = nome;
        curso.CargaHoraria = ch;
        context.Add(curso);
        context.SaveChanges();

        Console.WriteLine("-----------------------------------");
        Console.WriteLine("Curso Adicionado. \n[Enter] para continuar");
        Console.ReadLine();
        MenuCurso();
    }

    public static void RemoverCurso()
    {
        CriarTitulo("Sapiens - Remover Curso");
        Console.WriteLine("-----------------------------------");
        Console.Write("Id do Curso para excluir: ");
        var id = Convert.ToInt32(Console.ReadLine());
        var curso = context.Cursos.Find(id);
        if (curso != null)
        {
            context.Remove(curso);
            context.SaveChanges();
            Console.WriteLine("Curso excluído.");
        }
        else
        {
            Console.WriteLine("Curso inexistente.");
        }
        Console.WriteLine("[Enter] para continuar");
        Console.ReadLine();
        MenuCurso();
    }
    #endregion

    public static void MenuAluno()
    {
        CriarTitulo("Sapiens - Cadastro de Alunos");
        var opcao = "";
        Console.WriteLine(" [1] Consultar");
        Console.WriteLine(" [2] Adicionar");
        Console.WriteLine(" [3] Remover");
        Console.WriteLine("\n [9] Voltar");
        Console.WriteLine("-----------------------------------");
        Console.Write(" \nOpção: ");
        opcao = Console.ReadLine();
        switch (opcao)
        {
            case "1": ConsularAluno(); break;
            case "2": AdicionarAluno(); break;
            case "3": RemoverAluno(); break;
            case "9": Menu(); break;
        }
    }

    public static void ConsularAluno()
    {
        CriarTitulo("Sapiens - Consultar Aluno");
        Console.Write("Termo da pesquisa [Enter para todos]: ");
        var termo = Console.ReadLine();
        if (termo == "")
        {
            var alunos = context.Alunos.ToList();
            foreach (var aluno in alunos)
            {
                Console.WriteLine($"{aluno.Cpf}: {aluno.Nome}");
            }
        }
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("[Enter] para continuar");
        Console.ReadLine();
        MenuAluno();
    }

    public static void AdicionarAluno()
    {
        CriarTitulo("Sapiens - Adicionar Aluno");
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("[Enter] para continuar");
        Console.ReadLine();
        MenuAluno();
    }

    public static void RemoverAluno()
    {
        CriarTitulo("Sapiens - Remover Aluno");
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("[Enter] para continuar");
        Console.ReadLine();
        MenuAluno();
    }

    public static void FazerMigracao()
    {
        Console.WriteLine("Iniciando migração");
        context.Database.Migrate();
        Console.WriteLine("Migração Finalizada");
        Console.WriteLine("[Enter] para continuar");
        Console.ReadLine();
    }

    public static void CriarTitulo(string titulo)
    {
        Console.Clear();
        Console.WriteLine("-----------------------------------");
        Console.WriteLine($" {titulo}");
        Console.WriteLine("-----------------------------------");
    }
}
