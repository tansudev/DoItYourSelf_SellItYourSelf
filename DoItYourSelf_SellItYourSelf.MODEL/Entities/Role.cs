using DoItYourSelf_SellItYourSelf.CORE.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoItYourSelf_SellItYourSelf.MODEL.Entities
{
    public class Role:CoreEntity
    {
        public string RoleName { get; set; }
        public string Description { get; set; }
    }
}
