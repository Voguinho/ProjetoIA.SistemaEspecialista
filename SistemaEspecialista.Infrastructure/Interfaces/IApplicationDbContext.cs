using Microsoft.EntityFrameworkCore;
using SistemaEspecialista.Domain.Entities;

namespace SistemaEspecialista.Infrastructure.Interfaces;

public interface IApplicationDbContext
{
    public DbSet<Project> Projects { get; set; }
    public DbSet<Objective> Objectives { get; set; }
    public DbSet<Characteristic> Characteristics { get; set; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());
    void Dispose();
    DbSet<TEntity> Set<TEntity>() where TEntity : Entity;
}
