using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ITDeveloper.Mvc.Controllers {
    public class LoggerController : Controller {
        private readonly ILogger<LoggerController> _logger;

        public LoggerController(ILogger<LoggerController> logger) {
            _logger = logger;
        }

        public IActionResult Index() {
            var mgsLogger = "Teste de Log";

            _logger.Log(LogLevel.Critical, mgsLogger);
            _logger.Log(LogLevel.Warning, mgsLogger);
            _logger.Log(LogLevel.Trace, mgsLogger);
            _logger.LogError(mgsLogger);
            _logger.LogInformation(mgsLogger);

            return View();
        }
    }
}