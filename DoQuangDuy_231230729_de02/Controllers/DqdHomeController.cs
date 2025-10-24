using System.Diagnostics;
using DoQuangDuy_231230729_de02.Models;
using Microsoft.AspNetCore.Mvc;

namespace DoQuangDuy_231230729_de02.Controllers
{
    public class DqdHomeController : Controller
    {
        private readonly ILogger<DqdHomeController> _logger;

        public DqdHomeController(ILogger<DqdHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult DqdIndex()
        {
            return View();
        }

        public IActionResult DqdPrivacy()
        {
            return View();
        }

        public IActionResult DqdAbout()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult DqdError()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
