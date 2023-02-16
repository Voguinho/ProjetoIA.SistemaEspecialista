using Microsoft.EntityFrameworkCore;
using SistemaEspecialista.Application.Interfaces.Services;
using SistemaEspecialista.Domain.Entities;
using SistemaEspecialista.Infrastructure.Interfaces;

namespace SistemaEspecialista.Infrastructure.Data;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public DbSet<Project> Projects { get; set; }
    public DbSet<Objective> Objectives { get; set; }
    public DbSet<Characteristic> Characteristics { get; set; }

    private readonly User _currentUser;
    private readonly IIdentityService _identityService;

    public ApplicationDbContext(IIdentityService identityService)
    {
        _identityService = identityService;
        _currentUser = _identityService.GetCurrentUser();
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public override Task<int> SaveChangesAsync(
               CancellationToken cancellationToken = new CancellationToken())
    {
        foreach (var entry in ChangeTracker.Entries<Entity>())
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Entity.CreatedBy = _currentUser.Email;
                    entry.Entity.CreatedAt = DateTime.Now;
                    break;
                case EntityState.Modified:
                    entry.Entity.UpdatedBy = _currentUser.Email;
                    entry.Entity.UpdatedAt = DateTime.Now;
                    break;
            }
        }

        return base.SaveChangesAsync(cancellationToken);
    }

    public DbSet<TEntity> Set<TEntity>() where TEntity : Entity
    {
        throw new NotImplementedException();
    }
}
