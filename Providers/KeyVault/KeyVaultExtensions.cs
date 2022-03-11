using Microsoft.Azure.KeyVault;
using Microsoft.Azure.Services.AppAuthentication;
using Microsoft.Extensions.Configuration.AzureKeyVault;

namespace WorkingWithProviders.Providers.KeyVault;

public static class KeyVaultExtensions
{
    public static void AddConfigurationsFromKeyVault(this IConfigurationBuilder builder, IConfiguration config,
        HostBuilderContext ctx)
    {
        if (!ctx.HostingEnvironment.IsProduction()) return;
        var tokenProvider = new AzureServiceTokenProvider();
        var kvClient = new KeyVaultClient((authority, resource, scope) =>
            tokenProvider.KeyVaultTokenCallback(authority, resource, scope));
        builder.AddAzureKeyVault(config.GetValue<string>("KeyVault:BaseUrl"), kvClient,
            new DefaultKeyVaultSecretManager());
    }
}