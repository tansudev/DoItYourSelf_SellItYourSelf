using DoItYourSelf_SellItYourSelf.CORE.Entity.Enums;
using DoItYourSelf_SellItYourSelf.CORE.Service;
using DoItYourSelf_SellItYourSelf.MODEL.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;

namespace DoItYourSelf_SellItYourSelf.UI.Controllers
{
    [Route("/Registration")]
    public class RegistrationController : Controller
    {
        private readonly ICoreService<User> us;
        private readonly ICoreService<Role> ro;

        public RegistrationController(ICoreService<User> _us, ICoreService<Role> _ro)
        {
            us = _us;
            ro = _ro;
        }

        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Registration(User user)
        {
            User newUser = new User();
            var userRole = ro.GetByDefault(x => x.RoleName == "User");

            if (ModelState.IsValid)
            {
                //if email of user not match in table emails, create a new user
                if (!(us.Any(x => x.Email == user.Email)))
                {
                    newUser.Name = user.Name;
                    newUser.Surname = user.Surname;
                    newUser.Email = user.Email;
                    newUser.Password = user.Password;

                    newUser.RoleID = userRole.ID;
                    newUser.ID = Guid.NewGuid();
                    newUser.Status = (Status)1;
                    newUser.CreatedComputerName = System.Environment.MachineName;
                    newUser.CreatedDate = DateTime.Now;
                    newUser.CreatedIP = Dns.GetHostName();

                    us.Add(newUser);
                    return   RedirectToAction("Index", "Home");
                }
            }
            else
            {
                return BadRequest();
            }

            us.Add(user);

            return Ok("Ekleme başarılı");
        }
    }
}
