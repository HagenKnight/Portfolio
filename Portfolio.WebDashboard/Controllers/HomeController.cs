using Microsoft.AspNetCore.Mvc;
using Portfolio.WebDashboard.Models;
using Portfolio.WebDashboard.Models.Modals;
using System.Diagnostics;

namespace Portfolio.WebDashboard.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IConfiguration config) : base(config)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            if (TempData["ShowModal"] == null)
                InicializeModalDialog(ShowModal.NO);

            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult Error404()
        {
            return View();
        }

        public IActionResult Error500()
        {
            return View();
        }
    }
}