using ChatWithFriends.Data;
using ChatWithFriends.Interfaces;
using ChatWithFriends.ViewModels;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using ChatWithFriends.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace CoreMvc5_CookieAuthorization.Controllers
{
    public class AccountController : Controller
    {
        private readonly AccountContext _ctx;
        private readonly IHashService _hashService;

        public AccountController(AccountContext ctx, IHashService hashService)
        {
            _ctx = ctx;
            _hashService = hashService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginVM)
        {
            if (ModelState.IsValid)
            {
                var user = await AuthenticateUser(loginVM);

                if (user != null)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, user.Name),
                    };

                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    var authProperties = new AuthenticationProperties();

                    await HttpContext.SignInAsync(
                        CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(claimsIdentity),
                        authProperties
                    );
                    return RedirectToAction("DrinkAll", "DrinkHome");
                }

                else
                {
                    ModelState.AddModelError(string.Empty, "帳號密碼有錯!!!");
                }
            }

            return View(loginVM);
        }

        [HttpPost]
        public async Task<IActionResult> LoginDB(LoginViewModel loginVM)
        {
            if (ModelState.IsValid)
            {
                var user = await AuthenticateUser(loginVM);

                if (user != null)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, user.Name),
                    };

                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    var authProperties = new AuthenticationProperties();

                    await HttpContext.SignInAsync(
                        CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(claimsIdentity),
                        authProperties
                    );

                    return LocalRedirect("~/Reports/SalesReport");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "帳號密碼有錯!!!");
                }
            }

            return View(loginVM);
        }

        public async Task<IActionResult> Signout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return LocalRedirect("/");
        }

        public IActionResult Forbidden()
        {
            return View();
        }

        private async Task<ApplicationUser> AuthenticateUser(LoginViewModel loginVM)
        {
            var user = await _ctx.Users
                .FirstOrDefaultAsync(u => u.Name.ToUpper() == loginVM.Accont && u.Password == _hashService.SHA512Hash(loginVM.Password));

            if (user != null)
            {
                var userInfo = new ApplicationUser
                {
                    Name = user.Name
                };

                return userInfo;
            }
            else
            {
                return null;
            }
        }
    }
}
