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

<<<<<<< HEAD
    public ApplicationDbContext()
    {
       
=======
    private readonly User _currentUser;
    private readonly IIdentityService _identityService;
    private readonly IConfiguration _configuration;

    public ApplicationDbContext(IIdentityService identityService, IConfiguration configuration)
    {
        _identityService = identityService;
        _currentUser = _identityService.GetCurrentUser();
        _configuration = configuration;
>>>>>>> 036467759c8d5552bc628ac9f89d023a2d75a419
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
                    entry.Entity.CreatedAt = DateTime.Now;
                    break;
                case EntityState.Modified:
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
<<<<<<< HEAD
        return base.Set<TEntity>();
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Project>().HasKey(m => m.Id);
        builder.Entity<Objective>().HasKey(m => m.Id);
        builder.Entity<Characteristic>().HasKey(m => m.Id);
        base.OnModelCreating(builder);
=======
        options.UseMySql(_configuration.GetConnectionString("ApplicationDatabase"), ServerVersion.AutoDetect(_configuration.GetConnectionString("ApplicationDatabase")));
>>>>>>> 036467759c8d5552bc628ac9f89d023a2d75a419
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // connect to sqlite database
        options.UseSqlite(DbConfig.ConnectionString);
    }

}
