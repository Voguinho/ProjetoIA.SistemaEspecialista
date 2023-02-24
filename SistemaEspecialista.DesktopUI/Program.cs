using Microsoft.Extensions.DependencyInjection;
using SistemaEspecialista.DesktopUI.Views;
using SistemaEspecialista.Infrastructure.Extensions;

namespace SistemaEspecialista.DesktopView;

internal static class Program
{
    public static IServiceProvider ServiceProvider { get; set; }

    static void ConfigureServices()
    {
        var services = new ServiceCollection();
        services.AddInfrastructure();
        ServiceProvider = services.BuildServiceProvider();
    }

    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        ConfigureServices();
        System.Windows.Forms.Application.Run(new MainForm());
    }
}