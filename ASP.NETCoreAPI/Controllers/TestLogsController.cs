using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Serilog.Core;

namespace ASP.NETCoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestLogsController : ControllerBase
    {
        private readonly ILogger logger;

        public TestLogsController(ILogger logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            logger.LogTrace("This is a TRACE log message.");
            logger.LogDebug("This is a DEBUG log message.");
            logger.LogInformation("This is an INFORMATION log message.");
            logger.LogWarning("This is a WARNING log message.");
            logger.LogError("This is an ERROR log message.");
            logger.LogCritical("This is a CRITICAL log message.");
            return Ok("Log messages have been generated. Check your logging output.");
        }
    }
}
