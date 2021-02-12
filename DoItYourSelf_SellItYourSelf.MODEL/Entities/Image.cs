using DoItYourSelf_SellItYourSelf.CORE.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoItYourSelf_SellItYourSelf.MODEL.Entities
{
    public class Image:CoreEntity
    {
        public string ImageURL { get; set; }
        public string Title { get; set; }

        public Guid PostID { get; set; }
        public virtual Post Post { get; set; }
        public Guid ProductID { get; set; }
        public virtual Product Product { get; set; }
    }
}
