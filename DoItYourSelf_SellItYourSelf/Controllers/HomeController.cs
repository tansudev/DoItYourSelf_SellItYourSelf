using DoItYourSelf_SellItYourSelf.CORE.Entity.Enums;
using DoItYourSelf_SellItYourSelf.CORE.Service;
using DoItYourSelf_SellItYourSelf.MODEL.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DoItYourSelf_SellItYourSelf.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICoreService<Post> ps;
        private readonly ICoreService<Image> img;
        public HomeController(ICoreService<Post> _ps, ICoreService<Image> _img) 
        {
            ps = _ps;
            img = _img;
        }

        readonly Image Emptyimg = new Image
        {
            ID =  new Guid("BA2AA7E6-EFD8-4E63-8C57-136065B48DDA"),
            Title = "empty",
            Status = (Status)1,
            ImageURL = "480x320.jpg"
        };

        public IActionResult Index()
        {
            List<Image> images = img.GetActive();

            List<Post> posts = ps.GetActive();
            
            foreach (var item in posts)
            {
                List<Image> image = img.GetDefault(x => x.post.ID == item.ID);
                item.Images = image;

                if (item.Images.Count() <=0 )
                {
                    item.Images.Add( Emptyimg);
                 }       
                      
            }

            string homepost = posts.OrderByDescending(x => x.ViewCount).First().Images.First().ImageURL.ToString();

            ViewBag.HomeImage = homepost;
       
            return View(posts);
        }
    }
}
