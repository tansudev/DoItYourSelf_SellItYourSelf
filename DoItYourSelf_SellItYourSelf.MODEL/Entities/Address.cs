using DoItYourSelf_SellItYourSelf.CORE.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoItYourSelf_SellItYourSelf.MODEL.Entities
{
   public class Address:CoreEntity
    {
        public string AddressTitle { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Disctrict { get; set; }
        public string FullAddress { get; set; }
        public string PostCode { get; set; }

        public Guid UserID { get; set; }
        public virtual User User { get; set; }
        public virtual Order Order{ get; set; }
    }
}
