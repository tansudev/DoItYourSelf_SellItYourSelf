using System;
using System.Collections.Generic;
using System.Text;

namespace DoItYourSelf_SellItYourSelf.MODEL.Entities
{
    public class PostTag
    {
        public Guid PostID { get; set; }
        public Guid TagID { get; set; }
        public Post Post { get; set; }
        public Tag Tag { get; set; }
    }
}
