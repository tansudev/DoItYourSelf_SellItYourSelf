using DoItYourSelf_SellItYourSelf.CORE.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoItYourSelf_SellItYourSelf.MODEL.Entities
{
    public class Shipper:CoreEntity
    {
        public string ShipperName { get; set; }
        public string Phone { get; set; }

        public virtual Order Order { get; set; }
    }
}
