using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace ConfigDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigController : ControllerBase
    {
        private readonly AppSettings _appSettings;

        public ConfigController(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        [HttpGet]
        public IActionResult GetConfig()
        {
            return Ok(_appSettings);
        }
    }
}