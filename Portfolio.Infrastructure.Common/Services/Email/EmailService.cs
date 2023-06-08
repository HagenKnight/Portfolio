using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Portfolio.Core.Interfaces.Services;
using Portfolio.Core.Models;
using RazorLight;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Reflection;

namespace Portfolio.Infrastructure.Common.Services
{
    public class EmailService : IEmailService
    {
        public EmailSettings _emailSettings { get; }
        public ILogger<EmailService> _logger { get; }

        public EmailService(IOptions<EmailSettings> emailSettings, ILogger<EmailService> logger)
        {
            _emailSettings = emailSettings.Value;
            _logger = logger;
        }

        public async Task<bool> SendEmail(Email email, object contentData)
        {
            try
            {
                // Prepare the Email template
                //string pathFile =
                //HostingEnvironment.MapPath("~/Views/Templates/InvitacionProceso360.cshtml");
                //HttpContext.Server.MapPath("~/Views/Templates/InvitacionPlataformaLMS.cshtml");
                //var template = System.IO.File.ReadAllText(pathFile);

                string cacheKey = DateTime.Now.ToString("yyyyMMddHHmmss");
                // open template
                var template = System.IO.File.ReadAllText(email.TemplatePath);


                RazorLightEngine engine = new RazorLightEngineBuilder()
                    .UseEmbeddedResourcesProject(Assembly.GetEntryAssembly())
                    .UseMemoryCachingProvider()
                    .Build();

                string htmlContent = await engine.CompileRenderStringAsync(cacheKey, template, contentData);

                var client = new SendGridClient(_emailSettings.ApiKey);
                var subject = email.Subject;
                var to = new EmailAddress(email.To);
                var emailBody = htmlContent;
                var from = new EmailAddress
                {
                    Email = _emailSettings.FromAddress,
                    Name = _emailSettings.FromName
                };

                var sendGridMessage = MailHelper.CreateSingleEmail(from, to, subject, emailBody, emailBody);

                var response = await client.SendEmailAsync(sendGridMessage);
                if (response.StatusCode == System.Net.HttpStatusCode.OK || response.StatusCode == System.Net.HttpStatusCode.Accepted)
                {
                    return true;
                }
                else
                {
                    _logger.LogError($"El email no pudo ser enviado. Destinatario {email.To}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error at --> {ex.Message}");
                return false;
            }
        }
    }
}
