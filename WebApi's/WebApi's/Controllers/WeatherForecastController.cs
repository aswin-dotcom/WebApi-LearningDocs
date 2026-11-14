using Microsoft.AspNetCore.Mvc;
using WebApi_s.Logging;

namespace WebApi_s.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILoggers _logger;
        public WeatherForecastController()
        {
            _logger = new LogToConsole(); // You can change this to LogToFile or LogToDb as needed
        }

        [HttpGet]

        public ActionResult Index()
        {
            _logger.Log("WeatherForecastController Index action called.");
            return Ok("");
        }
    }
}
