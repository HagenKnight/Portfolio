using Microsoft.AspNetCore.Mvc;

namespace Portfolio.WebDashboard.Controllers
{
    public class WorkerProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
