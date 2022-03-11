using WorkingWithProviders.Configurations;

namespace WorkingWithProviders.Extensions;

public static class ConfigurationExtensions
{
    public static void AddConfigurations(this IServiceCollection serviceCollection, IConfiguration configuration)
    {
        serviceCollection.Configure<SystemInfoConfiguration>(
            configuration.GetSection(SystemInfoConfiguration.SettingsKey));
    }
}
