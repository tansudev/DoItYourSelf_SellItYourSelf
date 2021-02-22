using DoItYourSelf_SellItYourSelf.CORE.Map;
using DoItYourSelf_SellItYourSelf.MODEL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoItYourSelf_SellItYourSelf.MODEL.Maps
{
    class OrderMap:CoreMap<Order>
    {
        public override void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");
            builder.Property(x => x.TotalAmounth).HasColumnType("money").IsRequired(true);
            builder.Property(x => x.TotalPiece).IsRequired(true);
            builder.Property(x => x.Discount).IsRequired(false);
            builder.Property(x => x.OrderDate).IsRequired(false);

            base.Configure(builder);

        }
    }
}
