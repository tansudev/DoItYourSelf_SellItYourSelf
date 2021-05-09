using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoItYourSelf_SellItYourSelf.UI.Areas.Administrator.Controllers
{
    [Area("Administrator")]  
    public class HomeController : Controller
    {
        
        [Authorize(Roles = "Admin")]

        public IActionResult Index()
        {
            return View();
        }


        //[Authorize]
        //public IActionResult AdminPage()
        //{
        //    return View();
        //}

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home", new { area = "" });
        }
    }
}
