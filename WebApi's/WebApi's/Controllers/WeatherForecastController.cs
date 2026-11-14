using Microsoft.AspNetCore.Mvc;
using WebApi_s.Logging;

namespace WebApi_s.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _Logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _Logger = logger;
        }

        [HttpGet()]

        public ActionResult Index()
        {
            _Logger.LogTrace("This is a trace log message.");
            _Logger.LogDebug("This is a debug log message.");
            _Logger.LogInformation("This is an information log message.");
            _Logger.LogWarning("This is a warning log message.");
            _Logger.LogError("This is an error log message.");
            _Logger.LogCritical("This is a critical log message.");
            //_Logger.Log(LogLevel.None, "This is a none log message.");
            return Ok("Logs have been written to the console.");
        }
    }
}
