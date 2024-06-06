using Sapiens.Shared.Enums;
using System.ComponentModel.DataAnnotations;

namespace Sapiens.Shared.Entities;

public abstract class Pessoa : Entidade
{
    [StringLength(255)]
    [Required]
    public string? Nome { get; set; }

    [StringLength(14)]
    [Required]
    public string? Cpf { get; set; }

    [StringLength(100)]
    public string? Email { get; set;}

    [StringLength(20)]
    public string? Telefone { get; set; }

    public Sexo? Sexo { get; set; }
  
    public EstadoCivil? EstadoCivil { get; set; }
    
    public CorOuRaca? CorOuRaca { get; set; }
    
    public bool? PCD { get; set; }

    [StringLength(5)]
    public TipoSanguinio? TipoSanguinio { get; set; }

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
