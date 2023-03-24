using Microsoft.AspNetCore.Mvc;
using Portfolio.WebDashboard.Models;
using System.Net;

namespace Portfolio.WebDashboard.Controllers
{
    public class AccountController : BaseController
    {
        private IConfiguration _config;

        public AccountController(IConfiguration config) : base(config)
        {
        }

        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(AuthorizationViewModel authData)
        {
            if (ModelState.IsValid)
            {
                string endpoint = ApplicantEndpoint();

                using (var httpClient = new HttpClient())
                {
                    using (var response = await httpClient.PostAsJsonAsync($"{endpoint}", authData))
                    {
                        if (response.StatusCode == HttpStatusCode.OK)
                        {
                            string apiResponse = await response.Content.ReadAsStringAsync();
                            return RedirectToAction("Index", "Home");

                        }
                        else if (response.StatusCode == HttpStatusCode.BadRequest)
                        {
                            return View();
                        }
                        else
                        {
                            return View();
                        }

                    }
                }

            }
            else
                return View();
        }


        public IActionResult Recovery()
        {
            return View();
        }
    }
}
