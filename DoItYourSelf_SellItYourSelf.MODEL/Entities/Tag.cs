using DoItYourSelf_SellItYourSelf.CORE.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoItYourSelf_SellItYourSelf.MODEL.Entities
{
    public class Tag:CoreEntity
    {
        public string TagName { get; set; }
        public string TagDescription { get; set; }
        public string TagImageUrl { get; set; }

        public List<PostTag> PostTags { get; set; }
    }
}
