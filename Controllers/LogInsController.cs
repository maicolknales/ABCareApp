using ABCareApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;

namespace ABCareApp.Controllers
{
    public class LogInsController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public LogInsController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Access(LogIn _login )
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = await _signInManager.PasswordSignInAsync(_login.Email,_login.Password, _login.RememberMe, lockoutOnFailure: false);
                    
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index","Home");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Acceso invalido");
                        return RedirectToAction("Index", "LogIns");
                    }
                }
                return RedirectToAction("Index","LogIns");
            }
            catch (Exception e)
            {
                return View(e.Message);
            }
        }
    }        
    
}
