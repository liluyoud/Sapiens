using Sapiens.Shared.Contexts;
using Sapiens.Shared.Entities;

namespace Sapiens.Shared.Extensions;

public static class ContextExtension
{
    public static List<Disciplina> AdicionaCoordendor (this Curso curso, SapiensContext context)
    {
        return context.Disciplinas.Where(d => d.Equals(curso)).ToList();
    }
}
