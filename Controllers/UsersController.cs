using ABCareApp.Models;
using ABCareApp.Repositories;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ABCareApp.Controllers
{
    public class UsersController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ApplicationDbContext _context;


        public UsersController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;

        }
        // GET: UsersController
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var usuarios = await _context.users.ToListAsync();
           
            return View(usuarios);
        }

        // GET: UsersController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UsersController/Create
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            UserRegister userRegister = new UserRegister();
            return View();
        }

        // POST: UsersController/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(UserRegister userRegister)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var user = new User()
                    {
                        UserName = userRegister.Email,
                        Email = userRegister.Email,
                        PasswordHash = userRegister.Password,
                        Name = userRegister.Name,
                        MiddleName = userRegister.MiddleName,
                        Surname = userRegister.Surname,
                    };
                    var result = await _userManager.CreateAsync(user);

                    return RedirectToAction("Index");
                }
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return View(e.Message);
            }
        }

        // GET: UsersController/Edit/5
        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View();
        }

        // POST: UsersController/Edit/5
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

        // GET: UsersController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UsersController/Delete/5
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
