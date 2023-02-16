using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
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
    private readonly IConfiguration _configuration;

    public ApplicationDbContext(IIdentityService identityService, IConfiguration configuration)
    {
        _identityService = identityService;
        _currentUser = _identityService.GetCurrentUser();
        _configuration = configuration;
    }

    public void Dispose() => base.Dispose();

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

    public new DbSet<TEntity> Set<TEntity>() where TEntity : Entity
    {
        return base.Set<TEntity>();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseMySql(_configuration.GetConnectionString("ApplicationDatabase"), ServerVersion.AutoDetect(_configuration.GetConnectionString("ApplicationDatabase")));
    }
}
