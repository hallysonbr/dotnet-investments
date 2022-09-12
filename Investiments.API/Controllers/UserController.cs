using Microsoft.AspNetCore.Mvc;

namespace Investiments.API.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
