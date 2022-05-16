using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using CourseWork.Models;
using CourseWork.ViewModels;
using CourseWork.Models.Contexts;

namespace CourseWork.Controllers
{
    public class AccountController : Controller
    {
        private ApplicationContext context;

        public AccountController(ApplicationContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = await context.Users.FirstOrDefaultAsync(u => u.Email == model.Email);
                if (user == null)
                {
                    user = AddUser(model);
                    Authenticate(user);
                    return RedirectToAction("Index", "Home");
                }
                else
                    ModelState.AddModelError("", "Incorrect username and/or password");
            }
            return View(model);
        }

        private User AddUser(RegisterViewModel model)
        {
            User user = new User
            {
                Email = model.Email,
                Password = model.Password,
                Registration = DateTime.Now,
                Authorization = DateTime.Now,
                Role = "user",
                Blocked = false
            };
            context.Users.Add(user);
            context.SaveChanges();
            return user;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = await context.Users
                    .FirstOrDefaultAsync(u => u.Email == model.Email && u.Password == model.Password);
                if (user != null)
                {
                    Authenticate(user);
                    return RedirectToAction("Index", "Home");
                }
                else
                    ModelState.AddModelError("", "Incorrect username and/or password");
            }
            return View(model);
        }

        private void Authenticate(User user)
        {
            user.Authorization = DateTime.Now;
            context.SaveChanges();
            SetClaims(user);
        }

        private async void SetClaims(User user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.Email),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Role)
            };
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType,
                ClaimsIdentity.DefaultRoleClaimType);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }
    }
}
