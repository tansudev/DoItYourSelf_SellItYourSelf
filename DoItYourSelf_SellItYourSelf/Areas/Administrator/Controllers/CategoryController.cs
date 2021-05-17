using DoItYourSelf_SellItYourSelf.CORE.Service;
using DoItYourSelf_SellItYourSelf.MODEL.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoItYourSelf_SellItYourSelf.UI.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    [Route("{Area}/")]
    public class CategoryController : Controller
    {
        readonly ICoreService<Category> _ct;

        public CategoryController(ICoreService<Category> ct)
        {
            _ct = ct;
        }

        [Route("Categories")]
        public IActionResult Categories()
        {
            List<Category> allCategoryData = _ct.GetAll();
            return View(allCategoryData);
        }
    }
}
