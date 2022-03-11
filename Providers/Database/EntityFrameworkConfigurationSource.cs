using Microsoft.EntityFrameworkCore;

namespace WorkingWithProviders.Providers.Database;

public class EntityFrameworkConfigurationSource : IConfigurationSource
{
    private readonly Action<DbContextOptionsBuilder> _optionsAction;

    public EntityFrameworkConfigurationSource(Action<DbContextOptionsBuilder> optionsAction)
    {
        _optionsAction = optionsAction;
    }

    public IConfigurationProvider Build(IConfigurationBuilder _)
    {
        return new EntityFrameworkConfigurationProvider(_optionsAction);
    }
}