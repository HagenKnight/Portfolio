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

        public AccountController(IAuthService authService, IEmailService emailService)
        {
            _authService = authService;
            _emailService = emailService;
        }

        [HttpPost("Login")]
        public async Task<ActionResult<AuthResponse>> Login([FromBody] AuthRequest request)
        {
            return Ok(await _authService.Login(request));
        }

        [HttpPost("Register")]
        public async Task<ActionResult<RegistrationResponse>> Register([FromBody] RegistrationRequest request)
        {
            var emailData = new Email
            {
                To = "lordhagen@gmail.com",
                Body = "Creación de Usuario",
                Subject = $"Usuario creado: {request.Username}\nNombre Completo: {request.FirstName} {request.LastName}\nEmail: {request.Email}"
            };

            var response = await _authService.Register(request);

            bool isSentEmail = await _emailService.SendEmail(emailData);


            return Ok(response);
        }

    }
}
