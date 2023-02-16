using SistemaEspecialista.Application.Interfaces.Repositories;
using SistemaEspecialista.Domain.Entities;
using SistemaEspecialista.Infrastructure.Interfaces;

namespace SistemaEspecialista.Infrastructure.Repositories;

public class ObjectiveRepository : Repository<Objective>, IObjectiveRepository
{
    public ObjectiveRepository(IApplicationDbContext dbContext) : base(dbContext)
    {
    }
}
