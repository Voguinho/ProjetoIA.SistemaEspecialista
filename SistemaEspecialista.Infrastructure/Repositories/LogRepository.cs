using SistemaEspecialista.Application.Interfaces.Repositories;
using SistemaEspecialista.Domain.Entities;
using SistemaEspecialista.Infrastructure.Interfaces;

namespace SistemaEspecialista.Infrastructure.Repositories;

public class LogRepository : Repository<Log>, ILogRepository
{
    public LogRepository(IApplicationDbContext dbContext) : base(dbContext)
    {
    }
}
