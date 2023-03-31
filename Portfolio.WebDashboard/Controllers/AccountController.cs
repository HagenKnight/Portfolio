using Microsoft.AspNetCore.Mvc;
using Portfolio.Application.Contracts.Identity;
using Portfolio.Application.Models.Identity;
using Portfolio.Infrastructure.Identity.Authorization;
using Portfolio.WebDashboard.Models;
using Portfolio.WebDashboard.Models.Modals;
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
            InicializeModalDialog(ShowModal.NO);
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(AuthRequest authData)
        {
            try
            {
                var response = await _authService.Login(authData);
                if (response != null)
                {
                    // Set Dialog Modal
                    TempData["TypeOfLoginState"] = TypeOfLoginState.LOGGED;

                    // Set values for session dashboard
                    ViewBag.Email = response.Email;

                    return RedirectToAction("Index", "Home");
                }
                else 
                    return View();
            }
            catch (AuthorizationException ex)
            {
                switch (ex.Code)
                {
                    case "401":
                        ShowDialog(TypeOfLoginState.LOGIN, TypeOfModalDialog.ERROR, "Unauthorized",
                               ex.Message);

                        return View();
                    case "403":
                        ShowDialog(TypeOfLoginState.LOGIN, TypeOfModalDialog.INFORMATION, "Forbidden",
                               ex.Message);
                        return View();
                    default:
                        ShowDialog(TypeOfLoginState.LOGIN, TypeOfModalDialog.ERROR, "Authentication Error",
                               ex.Message);
                        return View();
                }
            }
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


        public ActionResult Logout()
        {
            // Borra la cookie utilizada para establecer Sesión

            return RedirectToAction("Login", "Account");
        }

        public IActionResult Recovery()
        {
            return View();
        }
    }
}
