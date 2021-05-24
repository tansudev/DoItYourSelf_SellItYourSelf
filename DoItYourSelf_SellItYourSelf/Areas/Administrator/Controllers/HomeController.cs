using DoItYourSelf_SellItYourSelf.CORE.Service;
using DoItYourSelf_SellItYourSelf.MODEL.Entities;
using DoItYourSelf_SellItYourSelf.SERVİCE.Base;
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
    [Route("{Area}/{Controller}")]
    public class HomeController : Controller
    {
        readonly ICoreService<Category> _ct; 
        public HomeController(ICoreService<Category> ct)
        {
            _ct = ct;
        }

        [Authorize(Roles = "Admin")]
        [Route("Adminpage")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("Logout")]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home", new { area = "" });
        }

    }
}
