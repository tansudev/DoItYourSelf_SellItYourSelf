using DoItYourSelf_SellItYourSelf.CORE.Map;
using DoItYourSelf_SellItYourSelf.MODEL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoItYourSelf_SellItYourSelf.MODEL.Maps
{
    class TagMap:CoreMap<Tag>
    {
        public override void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.ToTable("Tags");
            builder.Property(x => x.TagName).HasMaxLength(50).IsRequired(true);
            builder.Property(x => x.TagDescription).HasMaxLength(255).IsRequired(false);
            builder.Property(x => x.TagImageUrl).HasMaxLength(255).IsRequired(false);

            base.Configure(builder);
        }
    }
}
