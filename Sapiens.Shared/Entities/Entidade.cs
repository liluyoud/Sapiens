using Sapiens.Shared.Contexts;

namespace Sapiens.Shared.Entities;

public abstract class Entidade
{
    public Guid Id { get; set; } = new Guid();
    public SapiensContext? Context { get; set; }

}
