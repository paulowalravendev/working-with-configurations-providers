using Microsoft.EntityFrameworkCore;
using WorkingWithProviders.Providers.Database;

namespace WorkingWithProviders.Data;

public class WorkingWithProvidersDbContext : DbContext
{
    public WorkingWithProvidersDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<ConfigurationEntry> ConfigurationEntries { get; set; } = null!;
}