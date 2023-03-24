using Microsoft.AspNetCore.Mvc;

namespace Portfolio.WebDashboard.Controllers
{
    public class ResumeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
