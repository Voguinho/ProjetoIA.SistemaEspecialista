using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SistemaEspecialista.Application.Interfaces.Repositories;
using SistemaEspecialista.Infrastructure.Data;
using SistemaEspecialista.Infrastructure.Interfaces;
using SistemaEspecialista.Infrastructure.Repositories;
using SistemaEspecialista.Infrastructure.Utils;

namespace SistemaEspecialista.Infrastructure.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddSingleton<IApplicationDbContext, ApplicationDbContext>();
        services.AddSingleton<IProjectRepository, ProjectRepository>();
        services.AddSingleton<IObjectiveRepository, ObjectiveRepository>();
        services.AddSingleton<ICharacteristicsRepository, CharacteristicRepository>();
        services.AddDbContext<ApplicationDbContext>();
        return services;
    }
}