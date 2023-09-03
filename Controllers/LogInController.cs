using ABCareApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ABCareApp.Controllers
{
    public class LogInController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public LogInController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        // GET: LogInController
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        // GET: LogInController/Access
        [HttpPost]
        public async Task<IActionResult> Access(LogIn _login)
        {
            if (ModelState.IsValid)
            {
                LogIn signedUser = UserManager.FindByEmail(_login.Email);
                var result = await _signInManager.PasswordSignInAsync(_login., _login.Password, _login.RememberMe, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Acceso invalido");
                    return View(_login);
                }
            }
            
            return View(_login);
        }

        // GET: LogInController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LogInController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LogInController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LogInController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LogInController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LogInController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LogInController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
