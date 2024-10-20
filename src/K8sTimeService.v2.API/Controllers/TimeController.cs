using Microsoft.AspNetCore.Mvc;

namespace K8sTimeService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TimeController : ControllerBase
    {
        private readonly ILogger<TimeController> _logger;

        public TimeController(ILogger<TimeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetTime()
        {
            var datetimeNow = DateTime.Now.ToString("HH:mm:ss");
            _logger.LogInformation("The current data is: " + datetimeNow);

            return Ok("The current data is: " + datetimeNow);
        }
    }
}
