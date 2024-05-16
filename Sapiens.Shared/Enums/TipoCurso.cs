using System.ComponentModel;

namespace Sapiens.Shared.Enums;

public enum TipoCurso
{
    Tecnologo,
    Licenciatura,
    Bacharelado,

    [Description("Especialização")]
    Especializacao,
    
    Mestrado,
    Doutorado
}
