using Microsoft.AspNetCore.Mvc;

namespace AUT02_04.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
