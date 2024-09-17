using Microsoft.AspNetCore.Mvc;
using Lr3.Net.Services;

namespace Lr3.Net.Controllers
{
    public class TimeController : Controller
    {
        private readonly TimeAnalyzerService _timeAnalyzerService;

        public TimeController(TimeAnalyzerService timeAnalyzerService)
        {
            _timeAnalyzerService = timeAnalyzerService;
        }

        public IActionResult AnalyzeTime()
        {
            var result = _timeAnalyzerService.AnalyzeTime();
            return Content(result);
        }
    }
}
