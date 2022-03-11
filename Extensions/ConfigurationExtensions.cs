using Microsoft.EntityFrameworkCore;
using WorkingWithProviders.Configurations;
using WorkingWithProviders.Providers.Database;
using WorkingWithProviders.Providers.KeyVault;

namespace WorkingWithProviders.Extensions;

public static class ConfigurationExtensions
{
    public static void ConfigureApp(this IHostBuilder hostBuilder)
    {
        hostBuilder.ConfigureAppConfiguration((ctx, builder) =>
        {
            var config = builder.Build();
            builder.AddConfigurationsFromEf(config);
            builder.AddConfigurationsFromKeyVault(config, ctx);
        });
    }

    public static void AddConfigurations(this IServiceCollection serviceCollection, IConfiguration configuration)
    {
        serviceCollection.Configure<SystemInfoConfiguration>(
            configuration.GetSection(SystemInfoConfiguration.SettingsKey));
    }
}
