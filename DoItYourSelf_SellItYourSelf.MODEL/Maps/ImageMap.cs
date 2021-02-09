using DoItYourSelf_SellItYourSelf.CORE.Map;
using DoItYourSelf_SellItYourSelf.MODEL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;


namespace DoItYourSelf_SellItYourSelf.MODEL.Maps
{
    class ImageMap:CoreMap<Image>
    {
        public override void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.ToTable("Images");
            builder.Property(x => x.ImageURL).HasMaxLength(255).IsRequired(true);
            builder.Property(x => x.Title).HasMaxLength(100).IsRequired(true);

            base.Configure(builder);
        }
    }
}
