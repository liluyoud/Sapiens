
using System.ComponentModel.DataAnnotations;

namespace Sapiens.Shared.Models;

public record Endereco
{
    [StringLength(9)]
    public string? Cep { get; set; }

    [StringLength(100)]
    public string? Logradouro { get; set; }

    [StringLength(50)]
    public string? Numero { get; set; }

    [StringLength(100)]
    public string? Complemento { get; set; }

    [StringLength(100)]
    public string? Bairro { get; set; }

    [StringLength(100)]
    public string? Municipio { get; set; }

    [StringLength(2)]
    public string? Uf { get; set; }

}
