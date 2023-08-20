using Database.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Database.Controllers
{
    public class XCController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public XCController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}