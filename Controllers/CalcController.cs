using Microsoft.AspNetCore.Mvc;
using Lr3.Net.Services;

namespace Lr3.Net.Controllers
{
    public class CalcController : Controller
    {

        private readonly CalcService _calcService;

        public CalcController(CalcService calcService)
        {
            _calcService = calcService;
        }

        public IActionResult Add(int a, int b)
        {
            var result = _calcService.Add(a, b);
            return Content($"Result of addition: {result}");
        }

        public IActionResult Subtract(int a, int b)
        {
            var result = _calcService.Subtract(a, b);
            return Content($"Result of subtraction: {result}");
        }

        public IActionResult Multiply(int a, int b)
        {
            var result = _calcService.Multiply(a, b);
            return Content($"Result of multiplication: {result}");
        }

        public IActionResult Divide(int a, int b)
        {
            try
            {
                var result = _calcService.Divide(a, b);
                return Content($"Result of division: {result}");
            }
            catch (DivideByZeroException)
            {
                return Content("Cannot divide by zero");
            }
        }
    }
}
