using Microsoft.AspNetCore.Mvc;

namespace CS_DotnetCoreDay4.Controllers
{
    // [Route("[controller]")]
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Index(int id)
        {
            var request = HttpContext.Request;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}