using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Application.Contracts.Identity;
using Portfolio.Application.Models.Identity;
using Portfolio.Core.Interfaces.Services;
using Portfolio.Core.Models;

namespace Portfolio.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly IEmailService _emailService;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public AccountController(IAuthService authService, IEmailService emailService, IWebHostEnvironment webHostEnvironment)
        {
            _authService = authService;
            _emailService = emailService;
            _webHostEnvironment = webHostEnvironment;
        }

        [HttpPost("Login")]
        public async Task<ActionResult<AuthResponse>> Login([FromBody] AuthRequest request)
        {
            return Ok(await _authService.Login(request));
        }

        [HttpPost("Register")]
        public async Task<ActionResult<RegistrationResponse>> Register([FromBody] RegistrationRequest request)
        {
            string webRootPath = _webHostEnvironment.WebRootPath;
            string contentRootPath = _webHostEnvironment.ContentRootPath;
            string path = "";
            path = Path.Combine(contentRootPath, "EmailTemplates", "PasswordResetTemplate.cshtml");

            var emailData = new Email
            {
                To = "giovannigarcia.de@gmail.com",
                Subject = $"Creación de Usuario {request.Username}",
                Body = $"Usuario creado: {request.Username}\nNombre Completo: {request.FirstName} {request.LastName}\nEmail: {request.Email}",
                TemplatePath = path
            };

            var response = await _authService.Register(request);

            RecoveryModel recoveryData = new RecoveryModel
            {
                Email = request.Email,
                FullName = request.FullName
            };

            bool isSentEmail = await _emailService.SendEmail(emailData, recoveryData);


            return Ok(response);
        }

    }
}
