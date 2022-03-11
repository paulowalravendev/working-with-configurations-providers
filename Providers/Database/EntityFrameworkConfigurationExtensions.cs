using Microsoft.EntityFrameworkCore;

namespace WorkingWithProviders.Providers.Database;

public static class EntityFrameworkConfigurationExtensions
{
    public static void AddConfigurationsFromEf(this IConfigurationBuilder builder, IConfiguration config) =>
        builder.AddEfConfiguration(o => { o.UseSqlServer(config.GetConnectionString("DefaultConnection")); });

    private static void AddEfConfiguration(this IConfigurationBuilder builder,
        Action<DbContextOptionsBuilder> optionsAction) =>
        builder.Add(new EntityFrameworkConfigurationSource(optionsAction));
}
