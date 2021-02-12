using DoItYourSelf_SellItYourSelf.CORE.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DoItYourSelf_SellItYourSelf.MODEL.Entities
{
    public class Order:CoreEntity
    {
        public decimal TotalAmounth { get; set; }
        public int TotalPiece { get; set; }
        public int? Discount { get; set; }
        public DateTime? OrderDate { get; set; }

        public Guid UserID { get; set; }
        public virtual User User { get; set; }   
        public virtual Address OrderAddress { get; set; }
        public virtual Payment Payment { get; set; }
        public virtual Shipper Shipper { get; set; }
        public  List<Product> Products { get; set; }
    }
}
