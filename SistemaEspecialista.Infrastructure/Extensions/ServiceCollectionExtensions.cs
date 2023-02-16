using Microsoft.Extensions.DependencyInjection;
using SistemaEspecialista.Application.Interfaces.Repositories;
using SistemaEspecialista.Infrastructure.Repositories;

namespace SistemaEspecialista.Infrastructure.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IObjectiveRepository, ObjectiveRepository>();
        services.AddScoped<ICharacteristicsRepository, CharacteristicRepository>();
        services.AddScoped<IProjectRepository, ProjectRepository>();
        services.AddScoped<IUserRepository, UserRepository>();

        return services;
    }
}