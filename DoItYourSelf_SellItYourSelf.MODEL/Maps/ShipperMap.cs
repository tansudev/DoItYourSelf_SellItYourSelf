using DoItYourSelf_SellItYourSelf.CORE.Map;
using DoItYourSelf_SellItYourSelf.MODEL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoItYourSelf_SellItYourSelf.MODEL.Maps
{
    class ShipperMap:CoreMap<Shipper>
    {
        public override void Configure(EntityTypeBuilder<Shipper> builder)
        {
            builder.ToTable("Shippers");
            builder.Property(x => x.ShipperName).HasMaxLength(255).IsRequired(true);
            builder.Property(x => x.Phone).HasMaxLength(16).IsRequired(false);

            base.Configure(builder);
        }
    }
}
