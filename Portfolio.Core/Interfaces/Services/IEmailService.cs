using Portfolio.Core.Models;

namespace Portfolio.Core.Interfaces.Services
{
    public interface IEmailService
    {
        Task<bool> SendEmail(Email email);
    }
}
