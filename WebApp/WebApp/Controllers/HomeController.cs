using System.Web.Mvc;
using WebApp.Core.Interfaces;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        IUserService _UserService;
        public HomeController(IUserService UserService)
        {
            this._UserService = UserService;
        }
       
    }
}
