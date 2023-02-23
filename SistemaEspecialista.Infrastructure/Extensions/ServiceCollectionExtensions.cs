<<<<<<< HEAD
﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SistemaEspecialista.Application.Interfaces.Repositories;
using SistemaEspecialista.Infrastructure.Data;
using SistemaEspecialista.Infrastructure.Interfaces;
=======
﻿using Microsoft.Extensions.DependencyInjection;
using SistemaEspecialista.Application.Interfaces.Repositories;
>>>>>>> 036467759c8d5552bc628ac9f89d023a2d75a419
using SistemaEspecialista.Infrastructure.Repositories;

namespace SistemaEspecialista.Infrastructure.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
<<<<<<< HEAD
        services.AddSingleton<IApplicationDbContext, ApplicationDbContext>();
        services.AddSingleton<IProjectRepository, ProjectRepository>();
        services.AddSingleton<IObjectiveRepository, ObjectiveRepository>();
        services.AddSingleton<ICharacteristicsRepository, CharacteristicRepository>();
        services.AddSingleton<IApplicationDbContext, ApplicationDbContext>();
        services.AddDbContext<ApplicationDbContext>();
=======
        services.AddScoped<IObjectiveRepository, ObjectiveRepository>();
        services.AddScoped<ICharacteristicsRepository, CharacteristicRepository>();
        services.AddScoped<IProjectRepository, ProjectRepository>();
        services.AddScoped<IUserRepository, UserRepository>();

>>>>>>> 036467759c8d5552bc628ac9f89d023a2d75a419
        return services;
    }
}