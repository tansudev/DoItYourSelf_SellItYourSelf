using DoItYourSelf_SellItYourSelf.CORE.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DoItYourSelf_SellItYourSelf.MODEL.Entities
{
     public class Product:CoreEntity
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int? Discount { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public int UnitInStock { get; set; }


       
        public Guid UserID { get; set; }
        public virtual User User { get; set; }
        public Guid CategoryID { get; set; }
        public virtual Category Category { get; set; }
        public Guid PostID { get; set; }
        public virtual Post Post { get; set; }       
        public virtual List<Image> Images { get; set; }
        public virtual List<Comment> Comments { get; set; }

    }
}
