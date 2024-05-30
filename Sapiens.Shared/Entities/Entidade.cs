using Sapiens.Shared.Contexts;

namespace Sapiens.Shared.Entities;

public abstract class Entidade
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public SapiensContext? Context { get; set; }

}
