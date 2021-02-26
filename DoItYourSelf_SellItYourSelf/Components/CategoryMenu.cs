using DoItYourSelf_SellItYourSelf.CORE.Service;
using DoItYourSelf_SellItYourSelf.MODEL.Context;
using DoItYourSelf_SellItYourSelf.MODEL.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoItYourSelf_SellItYourSelf.UI.Controllers
{
    public class CategoryMenu : ViewComponent
    { 
        //reading category info from server data 
        private readonly ICoreService<Category> ct;
        public CategoryMenu(ICoreService<Category> _ct)
        {
            ct = _ct;
        }
        //Sending category list to the components view
        public IViewComponentResult Invoke()
        {
            var result = ct.GetActive();
            return View(result);
        }
    }
}
