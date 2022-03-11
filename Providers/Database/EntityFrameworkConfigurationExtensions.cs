using Microsoft.EntityFrameworkCore;

namespace WorkingWithProviders.Providers.Database;

public static class EntityFrameworkConfigurationExtensions
{

    public static void AddEfConfiguration(this IConfigurationBuilder builder,
        Action<DbContextOptionsBuilder> optionsAction) =>
        builder.Add(new EntityFrameworkConfigurationSource(optionsAction));
}
