using Microsoft.AspNetCore.Mvc;

namespace Portfolio.WebDashboard.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
