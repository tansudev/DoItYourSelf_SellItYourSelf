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
        [HttpGet]
        public IActionResult Categories()
        {
            List<Category> allCategoryData = _ct.GetAll();
            return View(allCategoryData);
        }


        [Route("Categories")]
        [HttpPost]
        public IActionResult CategoryAdd( Category category)
        {
            if (category ==null)
            {
                return View();
            }
            _ct.Add(category);
            _ct.Save();

            return RedirectToAction("Categories");

        }
        [Route("CategoryDelete")]
        [HttpPost]
        public IActionResult CategoryDelete(string id)
        {
            //Guid Id = Guid.Parse(id) ;

            //if (id == Guid.Empty)
            //{
            //    return View();
            //}
            //_ct.Remove(id);
            _ct.Save();

            return RedirectToAction("Categories", "", new { area = "Administrator" });
        }
        [Route("CategoryDelete")]
        [HttpGet]
        public IActionResult CategoryEdit(Guid id)
        {
            if (id == Guid.Empty)
            {
                return View();
            }

            var modal = _ct.GetByID(id);
            return RedirectToAction("Categories",modal);
        }
    }
}
