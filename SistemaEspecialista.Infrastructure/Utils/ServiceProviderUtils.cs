using Microsoft.Extensions.DependencyInjection;
using SistemaEspecialista.Infrastructure.Extensions;

namespace SistemaEspecialista.Infrastructure.Utils;

public static class ServiceProviderUtils
{
    public static ServiceProvider GetServiceProvider()
    {
        var services = new ServiceCollection().AddInfrastructure();
        var servicesProvider = services.BuildServiceProvider();
        return servicesProvider;
    }

    public static T GetService<T>() where T : notnull
    {
        var serviceProvider = GetServiceProvider();
        if (serviceProvider is null)
            throw new Exception("Service provider não encontrado");

        return serviceProvider.GetRequiredService<T>();
    }
}
