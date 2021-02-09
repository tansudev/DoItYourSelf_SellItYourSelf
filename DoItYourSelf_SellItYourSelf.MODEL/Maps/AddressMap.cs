using DoItYourSelf_SellItYourSelf.CORE.Map;
using DoItYourSelf_SellItYourSelf.MODEL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoItYourSelf_SellItYourSelf.MODEL.Maps
{
    class AddressMap:CoreMap<Address>
    {
        public override void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Addresses");
            builder.Property(x => x.AddressTitle).HasMaxLength(50).IsRequired(true);
            builder.Property(x => x.Country).HasMaxLength(50).IsRequired(true);
            builder.Property(x => x.City).HasMaxLength(50).IsRequired(true);
            builder.Property(x => x.Disctrict).HasMaxLength(50).IsRequired(true);
            builder.Property(x => x.FullAddress).HasMaxLength(250).IsRequired(true);
            builder.Property(x => x.PostCode).HasMaxLength(20).IsRequired(false);

            base.Configure(builder);
        }
    }
}
