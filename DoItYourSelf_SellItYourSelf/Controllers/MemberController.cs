using DoItYourSelf_SellItYourSelf.CORE.Service;
using DoItYourSelf_SellItYourSelf.MODEL.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoItYourSelf_SellItYourSelf.UI.Controllers
{
    [Route("{Controller}")]
    [Authorize]
    public class MemberController : Controller
    {
        readonly ICoreService<Comment> _com;
        readonly ICoreService<Product> _prd;
        readonly ICoreService<Post> _post;
        readonly ICoreService<Tag> _tag;
        public MemberController(ICoreService<Comment> com, ICoreService<Product> prd, ICoreService<Post> post, ICoreService<Tag> tag)
        {
          _com=com;
            _prd = prd;
            _post = post;
            _tag = tag;

        }
        public IActionResult MemberPage()
        {
            //Guid currentUser = HttpContext.User.Claims.First();
            Guid currentUser = Guid.Parse( HttpContext.User.Claims.First().Value);

            List<Comment> comment = _com.GetActive().ToList();
            List<Product> product = _prd.GetActive().ToList();
            List<Post> post = _post.GetActive().Where(x=>x.UserID==currentUser).ToList();
            List<Tag> tags = _tag.GetActive().ToList();


            var tupleData = new Tuple<List<Comment>, List<Product>, List<Post>, List<Tag>>(comment, product, post, tags);
            return View(tupleData);
        }
    }
}
