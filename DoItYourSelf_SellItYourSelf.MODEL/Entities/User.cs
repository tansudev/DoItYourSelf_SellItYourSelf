using DoItYourSelf_SellItYourSelf.CORE.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoItYourSelf_SellItYourSelf.MODEL.Entities
{
    public class User: CoreEntity
    {
        public string Name{ get; set; }
        public string Surname{ get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime? Birthdate { get; set; }
        public string Gender { get; set; }
        public string ImageURL { get; set; }
        public string Phone { get; set; }
        public string AccountInfo { get; set; }

        public virtual Role Role { get; set; }
        public virtual List<Address> Addresses { get; set; }
        public virtual List<Post> Posts{ get; set; }
        public virtual List<Order> Orders { get; set; }
        public virtual List<Comment> Comments { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
