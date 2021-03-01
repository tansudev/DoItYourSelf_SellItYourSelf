using DoItYourSelf_SellItYourSelf.CORE.Service;
using DoItYourSelf_SellItYourSelf.MODEL.Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace DoItYourSelf_SellItYourSelf.UI.Controllers
{
    public class LoginController : Controller
    {
        private readonly ICoreService<User> us;
        private readonly ICoreService<Role> ro;

        public LoginController(ICoreService<User> _us, ICoreService<Role> _ro)
        {
            us = _us;
            ro = _ro;
        }

        public IActionResult LoginPage()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LoginPage(User user)
        {
            if (us.Any(x=>x.Email == user.Email && x.Password ==user.Password))
            {
                User logged = us.GetByDefault(x => x.Email == user.Email && x.Password == user.Password);
                string RoleName = ro.GetByID(logged.RoleID).RoleName;

                var DIYclaims = new List<Claim>()
                {
                    new Claim("ID",logged.ID.ToString()),
                    new Claim(ClaimTypes.Name, logged.Name),
                    new Claim(ClaimTypes.Surname, logged.Surname),
                    new Claim(ClaimTypes.Email, logged.Email),
                    new Claim(ClaimTypes.Role, RoleName)
                   
                };

                var userIdentity = new ClaimsIdentity(DIYclaims, "login");
                ClaimsPrincipal userprincipal = new ClaimsPrincipal(new[] { userIdentity });

                await HttpContext.SignInAsync(userprincipal);
                return RedirectToAction("AdminPage","Home", new { area = "Administrator" });
                //return RedirectToPage("Index","Home", new { area = "Administrator" });
                
            }
            return View(user);
        }
    }
}
