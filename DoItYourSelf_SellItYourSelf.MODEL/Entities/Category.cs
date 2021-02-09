using DoItYourSelf_SellItYourSelf.CORE.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoItYourSelf_SellItYourSelf.MODEL.Entities
{
    public class Category:CoreEntity
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string CategoryImageURL { get; set; }

        public virtual List<Post> Posts { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
