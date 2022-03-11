using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using WorkingWithProviders.Configurations;

namespace WorkingWithProviders.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AppConfigurationController : ControllerBase
{
    private readonly SystemInfoConfiguration _systemInfoConfiguration;

    public AppConfigurationController(IOptionsSnapshot<SystemInfoConfiguration> systemInfoConfiguration)
    {
        _systemInfoConfiguration = systemInfoConfiguration.Value;
    }
    
    [HttpGet]
    public IActionResult GetConfigs() => Ok(_systemInfoConfiguration);
}
