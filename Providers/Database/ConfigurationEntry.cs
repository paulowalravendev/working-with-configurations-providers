using System.ComponentModel.DataAnnotations;

namespace WorkingWithProviders.Providers.Database;

public class ConfigurationEntry
{
    [Key] [Required] public string Key { get; set; }
    [Required] public string Value { get; set; }
}