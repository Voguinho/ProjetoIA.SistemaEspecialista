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

    public ApplicationDbContext()
    {
       
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
                    entry.Entity.CreatedAt = DateTime.Now;
                    break;
                case EntityState.Modified:
                    entry.Entity.UpdatedAt = DateTime.Now;
                    break;
            }
        }

        return base.SaveChangesAsync(cancellationToken);
    }

    public DbSet<TEntity> Set<TEntity>() where TEntity : Entity
    {
        return base.Set<TEntity>();
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Project>().HasKey(m => m.Id);
        builder.Entity<Objective>().HasKey(m => m.Id);
        builder.Entity<Characteristic>().HasKey(m => m.Id);
        base.OnModelCreating(builder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // connect to sqlite database
        options.UseSqlite(DbConfig.ConnectionString);
    }

}
