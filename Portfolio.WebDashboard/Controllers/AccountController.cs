using Microsoft.AspNetCore.Mvc;
using Portfolio.Application.Contracts.Identity;
using Portfolio.Application.Models.Identity;
using Portfolio.WebDashboard.Models;
using System.Net;

namespace Portfolio.WebDashboard.Controllers
{
    public class AccountController : BaseController
    {
        //private IConfiguration _config;
        private readonly IAuthService _authService;

        public AccountController(IAuthService authService, IConfiguration config) : base(config)
        {
            _authService = authService;
        }

        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(AuthRequest authData)
        {
            return Ok(await _authService.Login(authData));
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LoginA(AuthorizationViewModel authData)
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
