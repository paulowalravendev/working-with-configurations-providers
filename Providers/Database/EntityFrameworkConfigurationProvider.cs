using Microsoft.EntityFrameworkCore;
using WorkingWithProviders.Data;

namespace WorkingWithProviders.Providers.Database;

public class EntityFrameworkConfigurationProvider : ConfigurationProvider
{
    public EntityFrameworkConfigurationProvider(Action<DbContextOptionsBuilder> optionsAction)
    {
        OptionsAction = optionsAction;
    }

    public Action<DbContextOptionsBuilder> OptionsAction { get; }

    public override void Load()
    {
        var builder = new DbContextOptionsBuilder<WorkingWithProvidersDbContext>();
        OptionsAction(builder);
        using var dbContext = new WorkingWithProvidersDbContext(builder.Options);
        Data = dbContext.ConfigurationEntries.Any()
            ? dbContext.ConfigurationEntries.ToDictionary(c => c.Key, c => c.Value)
            : new Dictionary<string, string>();
    }
}
