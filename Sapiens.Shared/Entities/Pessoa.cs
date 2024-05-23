using Sapiens.Shared.Enums;
using Sapiens.Shared.Models;
using System.ComponentModel.DataAnnotations;

namespace Sapiens.Shared.Entities;

public class Pessoa
{
    [StringLength(255)]
    public string? Nome { get; set; }

    [StringLength(14)]
    public string? Cpf { get; set; }

    [StringLength(100)]
    public string? Email { get; set;}

    [StringLength(20)]
    public string? Telefone { get; set; }

    public string? Foto { get; set; }

    public Endereco? Endereco { get; set; }
    public Sexo? Sexo { get; set; }
    public EstadoCivil? EstadoCivil { get; set; }
    public CorOuRaca? CorOuRaca { get; set; }
    public bool? PCD { get; set; }

    [StringLength(5)]
    public string? TipoSanguinio { get; set; }

    [StringLength(100)]
    public string? LinkedIn { get; set; }

    [StringLength(100)]
    public string? Instagram { get; set; }

    [StringLength(100)]
    public string? Twitter { get; set; }

    [StringLength(100)]
    public string? Facebook { get; set; }

    [StringLength(100)]
    public string? TikTok { get; set; }
}
