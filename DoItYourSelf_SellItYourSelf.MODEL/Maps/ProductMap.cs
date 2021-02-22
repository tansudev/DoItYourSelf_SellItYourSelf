using DoItYourSelf_SellItYourSelf.CORE.Map;
using DoItYourSelf_SellItYourSelf.MODEL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoItYourSelf_SellItYourSelf.MODEL.Maps
{
    class ProductMap:CoreMap<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.Property(x => x.ProductName).HasMaxLength(100).IsRequired(true);
            builder.Property(x => x.Description).HasMaxLength(255).IsRequired(false);
            builder.Property(x => x.Price).HasColumnType("money").IsRequired(true);
            builder.Property(x => x.Discount).IsRequired(false);
            builder.Property(x => x.Size).HasMaxLength(5).IsRequired(true);
            builder.Property(x => x.Color).HasMaxLength(20).IsRequired(false);
            builder.Property(x => x.UnitInStock).IsRequired(true);

            base.Configure(builder);
        }
    }
}
