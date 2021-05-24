
using DoItYourSelf_SellItYourSelf.CORE.Service;
using DoItYourSelf_SellItYourSelf.MODEL.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static DoItYourSelf_SellItYourSelf.UI.Helper;

namespace DoItYourSelf_SellItYourSelf.UI.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    [Route("{Area}/{Controller}")]
    public class UsersController : Controller
    {
        readonly ICoreService<User> _us;
        readonly ICoreService<Address> _ad;
        readonly ICoreService<Product> _pr;

        public UsersController(ICoreService<User> us, ICoreService<Address> ad, ICoreService<Product> pr)
        {
            _us = us;
            _ad = ad;
            _pr = pr;
        }

        [Route("Users")]
        [HttpGet]
        public async Task<IActionResult> Users()
        {
            List<User> allUsers = _us.GetAll();
            //List<Address> addresses = _ad.GetAll();
            //List<Product> products = _pr.GetAll();

            //return View(Tuple.Create<List<User>,Address,List<Product>>(new List<User>(),new Address(),new List<Product>()));

            return View(allUsers);
        }


        [Route("UserAct/{id:Guid}")]
        [HttpGet]
        public IActionResult AddOrEditUser(Guid id)
        {
            User userModal = new User();
            if (id == Guid.Empty)
            {
                return View(new User());
            }
            else
            {           
                //Guid ids = ToGuid(id);
                userModal = _us.GetByID(id);
                if (userModal == null)
                {
                    return NotFound();
                }
                return View(userModal);
            }
        }

        [Route("UserAct/{id:Guid}")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddOrEditUser(Guid id, [Bind("Name,Surname,Email,Phone,AccountInfo")] User usermodal)
        {
            User userMod = new User();
            
            if (ModelState.IsValid)
            {
                //İnsert
          
                if (id == Guid.Empty)
                {
                    _us.Add(usermodal);                  
                    _us.Save();                
                }
                //Update
                else
                {
                    userMod = _us.GetByID(id);
                    userMod.Name = usermodal.Name;
                    try
                    {
                        _us.Update(usermodal);
                        _us.Save();
                    }
                    catch (Exception)
                    {
                        if (!UserModalExists(id))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                    
                }
                return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this,"Users",_us.GetAll().ToList()) });
            }

            return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "AddOrEditUser",usermodal)});
        }


        // GET: Transaction/Delete/5
        public IActionResult UserDelete(Guid id)
        {
            if (id == Guid.Empty)
            {
                return NotFound();
            }

            User userModel = _us.GetByID(id);
            if (userModel == null)
            {
                return NotFound();
            }

            return View(userModel);
        }

        // POST: Transaction/Delete/5
        [HttpPost, ActionName("Delete")]
      
        public IActionResult DeleteConfirmed(Guid id)
        {
            User userModel =  _us.GetByID(id); 
            _us.Remove(userModel);
             _us.Save();
            return Json(new { html = Helper.RenderRazorViewToString(this, "_ViewAll", _us.GetAll().ToList()) });
        }


        private bool UserModalExists(Guid id)
        {
            return _us.Any(x => x.ID == id);
        }
        public static Guid ToGuid(int value)
        {
            byte[] bytes = new byte[16];
            BitConverter.GetBytes(value).CopyTo(bytes, 0);
            return new Guid(bytes);
        }
    }
}
