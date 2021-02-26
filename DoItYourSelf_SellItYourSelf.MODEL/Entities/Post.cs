using DoItYourSelf_SellItYourSelf.CORE.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoItYourSelf_SellItYourSelf.MODEL.Entities
{
    public class Post: CoreEntity
    {
        public string PostTitle { get; set; }
        public string PostDetail { get; set; }
        public int? ViewCount { get; set; }
        public bool ForSale { get; set; }
        public int? Rate { get; set; }

        public Guid UserID { get; set; }
        public virtual User User { get; set; }
        public Guid CategoryID { get; set; }
        public virtual Category Category { get; set; }

        public virtual List<Product> Products { get; set; }
        public virtual List<Image> Images { get; set; }
        public virtual List<Comment> Comments { get; set; }
        public virtual List<PostTag> PostTags { get; set; }

    } 
}
