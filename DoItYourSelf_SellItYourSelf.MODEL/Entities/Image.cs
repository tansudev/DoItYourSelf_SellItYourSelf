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

        public virtual Post post { get; set; }
        public virtual Product product { get; set; }

    }
}
