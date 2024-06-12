using Lucky.Date;
using Lucky.Date.Models.Account;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Lucky.controllers
{
    public class AccountController : Controller
    {
        private AppDbContent context;
        public AccountController(AppDbContent _context)
        {
            context = _context;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [System.Web.Mvc.ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model)
        {
            bool a = false;
            if (ModelState.IsValid)
            {

                if (model.Login == null)
                {
                    ModelState.AddModelError("", "Введите логин");
                    a = true;
                }
                if (model.Password == null)
                {
                    ModelState.AddModelError("", "Введите пароль");
                    a = true;
                }
               if(a== false)
                {
                    User user = await context.User
                                        .Include(u => u.Role)
                                        .FirstOrDefaultAsync(u => u.Login == model.Login && u.Password == model.Password);
                    if (user != null)
                    {
                        await Authenticate(user); // аутентификация
                        if (user.Role.Name == "user")
                            return RedirectToAction("Index", "Home");
                        else
                            return RedirectToAction("Read", "CRUD");
                    }
                    else
                        ModelState.AddModelError("", "Некорректные логин и(или) пароль");
                }
                
            }
            return View(model);
        }
        private async Task Authenticate(User user)
        {
            // создаем один claim
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.Login),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Role?.Name)
            };
            // создаем объект ClaimsIdentity
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType,
                ClaimsIdentity.DefaultRoleClaimType);
            // установка аутентификационных куки
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }
        [HttpGet]
        public async Task<IActionResult> Lagout()
        {
            // удаляем аутентификационные куки
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                User user = await context.User.FirstOrDefaultAsync(u => u.Login == model.Email);
                if (user == null)
                {
                    // добавляем пользователя в бд
                    context.User.Add(new User { Login = model.Email, Password = model.Password, RoleId = 2 });
                    await context.SaveChangesAsync();

                 

                    return RedirectToAction("Login", "Account");
                }
                else
                    ModelState.AddModelError("", "Такой пользователь уже есть");
            }
            return View(model);
        }
    }
}
