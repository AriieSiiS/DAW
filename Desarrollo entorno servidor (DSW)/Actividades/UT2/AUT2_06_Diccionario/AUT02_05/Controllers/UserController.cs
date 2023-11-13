using AUT02_05.Data;
using AUT02_05.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AUT02_05.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly DiccionarioContext _diccionarioContext;

        public UserController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<IdentityUser> signInManager, DiccionarioContext diccionarioContext)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _diccionarioContext = diccionarioContext;
        }

        [Authorize(Roles = "admin")]
        public IActionResult Index()
        {
            var frasesCount = _diccionarioContext.Frases.ToList();
            ViewBag.Frases = frasesCount;

            return View();
        }
        public IActionResult Premium()
        {
            return View();
        }
        public async Task<IActionResult> AssignPremiumRole()
        {
            var user = await _userManager.GetUserAsync(User);

            await _userManager.AddToRoleAsync(user, "premium");
            await _signInManager.RefreshSignInAsync(user);
            return RedirectToAction("Index", "Espengs");
        }
    }
}
