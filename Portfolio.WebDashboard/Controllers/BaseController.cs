using Microsoft.AspNetCore.Mvc;

namespace Portfolio.WebDashboard.Controllers
{
    public abstract class BaseController : Controller
    {
        private IConfiguration _config;

        public BaseController(IConfiguration config) => _config = config;

        protected string ApplicantEndpoint()
        {
            return $"{_config["ApiEndpoints:Url"]}{_config["ApiEndpoints:Account"]}";
        }
    }
}
