using Microsoft.AspNetCore.Mvc;
using WebApi_s.Logging;

namespace WebApi_s.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILoggers _logger;
        public WeatherForecastController(ILoggers logger)
        {
            _logger = logger;
        }

        [HttpGet]

        public ActionResult Index()
        {
            _logger.Log("WeatherForecastController Index action called.");
            return Ok("");
        }
    }
}
