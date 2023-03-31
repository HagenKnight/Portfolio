using Microsoft.AspNetCore.Mvc;
using Portfolio.WebDashboard.Models.Modals;

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


        #region Inicialización elementos de Modal Dialog
        protected void InicializeModalDialog(ShowModal option)
        {
            TempData["ShowModal"] = option;

            TempData["TypeOfLoginState"] = TypeOfLoginState.LOGIN;
            TempData["TypeOfDialog"] = string.Empty;
            TempData["Titulo"] = string.Empty;
            TempData["Mensaje"] = string.Empty;
            //TempData["ImagePath"] = string.Empty;
        }

        protected void ShowDialog(TypeOfLoginState loginState, TypeOfModalDialog type, string title, string contentText)
        {
            TempData["ShowModal"] = ShowModal.YES;
            TempData["TypeOfLoginState"] = loginState;
            TempData["TypeOfDialog"] = type.ToString();
            TempData["Titulo"] = title;
            TempData["Mensaje"] = contentText;
            //TempData["ImagePath"] = sourceImage;
        }
        #endregion
    }
}
