using Microsoft.EntityFrameworkCore;
using WorkingWithProviders.Data;
using WorkingWithProviders.Providers.Database;

namespace WorkingWithProviders.Extensions;

public static class EntityFrameworkExtensions
{
    public static void AddDbContext(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSqlServer<WorkingWithProvidersDbContext>(configuration.GetConnectionString("DefaultConnection"));
    }
}