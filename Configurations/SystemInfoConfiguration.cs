namespace WorkingWithProviders.Configurations;

public class SystemInfoConfiguration
{
    public static string SettingsKey => "SystemInfo";

    public bool? Enabled { get; set; }
    public string? Name { get; set; }
    public string? Password { get; set; }
}
