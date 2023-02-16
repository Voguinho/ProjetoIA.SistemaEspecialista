using SistemaEspecialista.Application.Interfaces.Repositories;
using SistemaEspecialista.Domain.Entities;
using SistemaEspecialista.Infrastructure.Interfaces;

namespace SistemaEspecialista.Infrastructure.Repositories;

internal class UserRepository : Repository<User>, IUserRepository
{
    public UserRepository(IApplicationDbContext dbContext) : base(dbContext){}
}
